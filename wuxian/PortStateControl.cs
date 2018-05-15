using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace wuxian
{
	public partial class PortStateControl : UserControl
	{
		public struct DataUnit
		{
			public DateTime Time;
			public float Voltage;
			public float Current;
			public float Battery;
			public float Distance;
			public float Height;

			public DataUnit(DateTime dt, float[] data)
			{
				Time = dt;
				if (data.Length == 5)
				{
					Voltage = data[0];
					Current = data[1];
					Battery = data[2];
					Distance = data[3];
					Height = data[4];
				}
				else
				{
					Voltage = 0.0f;
					Current = 0.0f;
					Battery = 0.0f;
					Distance = 0.0f;
					Height = 0.0f;
				}
			}

			public override string ToString()
			{
				return string.Format("{0:N2}, {1:N2}, {2:N2}, {3:N2}, {4:N2}", Voltage, Current, Battery, Distance, Height);
			}
		}

		private SerialPort SelectedSerialPort = new SerialPort();
		private Form_SerialPortSetting.SerialPortConfig SelectedSerialConfig;
		private string[] SerialPortList = new string[0];
		public Timer TimerGetData = new Timer();
		public List<DataUnit> DataUnits = new List<DataUnit>(240);
		public DataUnit d1 = new DataUnit();

		public string value = "";

		public delegate void delegateRun();
		public event delegateRun eventRun;

		public PortStateControl()
		{
			InitializeComponent();

			SelectedSerialPort.DataReceived += new SerialDataReceivedEventHandler(SelectedSerialPort_DataReceived);

			BackColor = Color.FromArgb(64, 0, 0, 0);

			SelectedSerialConfig.BaudRate = 115200;
			SelectedSerialConfig.DataBits = 8;
			SelectedSerialConfig.StopBits = StopBits.One;
			SelectedSerialConfig.Parity = Parity.None;

			SelectedSerialPort.BaudRate = SelectedSerialConfig.BaudRate;
			SelectedSerialPort.DataBits = SelectedSerialConfig.DataBits;
			SelectedSerialPort.StopBits = SelectedSerialConfig.StopBits;
			SelectedSerialPort.Parity = SelectedSerialConfig.Parity;

			TimerGetData.Interval = 50;
			TimerGetData.Tick += new EventHandler(TimerGetData_Tick);

			RefreshSerialPortList();
		}

		private void SelectedSerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			string source = SelectedSerialPort.ReadExisting();
			value = source;
			string[] strData = (source.TrimEnd()).Split(',');
			if (strData.Length != 5) return;
			float[] data = new float[5];
			for (int i = 0; i < 5; i++)
				if (!float.TryParse(strData[i], out data[i])) return;

			if (DataUnits.Count >= 240)
				DataUnits.RemoveAt(0);
			DateTime timeNow = DateTime.Now;
			DataUnit NewData = new DataUnit(timeNow, data);
			DataUnits.Add(NewData);
			d1 = NewData;
			eventRun();
		}

		private void RefreshSerialPortList()
		{
			string[] NewList = SerialPort.GetPortNames();

			if (!SerialPortList.SequenceEqual(NewList))
			{
				SerialPortList = NewList;
				ComboBox_SerialPortList.Items.Clear();

				foreach (var port in SerialPortList)
					ComboBox_SerialPortList.Items.Add(port);
				ComboBox_SerialPortList.Items.Add("刷新");
			}
			ComboBox_SerialPortList.SelectedIndex = -1;

			for (int i = 0; i < SerialPortList.Length; i++)
			{
				if (SelectedSerialPort.PortName == ComboBox_SerialPortList.Items[i].ToString())
				{
					ComboBox_SerialPortList.SelectedIndex = i;
					break;
				}
			}
		}

		private void ComboBox_SerialPortList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboBox_SerialPortList.SelectedIndex == SerialPortList.Length)
				RefreshSerialPortList();
			else
			{
				if (ComboBox_SerialPortList.SelectedIndex == -1) return;

				string[] NewList = SerialPort.GetPortNames();
				string SelectedName = ComboBox_SerialPortList.SelectedItem.ToString();

				bool IsExist = false;
				foreach (var port in NewList)
					if (port == SelectedName) IsExist = true;

				if (IsExist) SelectedSerialPort.PortName = SelectedName;
				else
				{
					MessageBox.Show("串口不存在");
					RefreshSerialPortList();
				}
			}
		}

		private void TimerGetData_Tick(object sender, EventArgs e)
		{
			SelectedSerialPort.Write("s" + Environment.NewLine);
		}

		private void Label_Open_MouseEnter(object sender, EventArgs e)
		{
			Label_Open.BackColor = Color.White;
		}
		private void Label_Open_MouseLeave(object sender, EventArgs e)
		{
			Label_Open.BackColor = Color.LightGray;
		}
		private void Label_Open_MouseDown(object sender, MouseEventArgs e)
		{
			Label_Open.BackColor = Color.DarkGray;
		}
		private void Label_Open_Click(object sender, EventArgs e)
		{
			if (Label_Open.Text == "打开")
			{
				try
				{
					SelectedSerialPort.Open();
				}
				catch (UnauthorizedAccessException)
				{
					MessageBox.Show("当前串口无法打开");
					return;
				}
				catch (System.IO.IOException)
				{
					MessageBox.Show("当前串口无法打开");
					return;
				}
				TimerGetData.Start();
				Label_Open.Text = "关闭";
			}
			else
			{
				if (SelectedSerialPort.IsOpen) SelectedSerialPort.Close();
				TimerGetData.Stop();
				Label_Open.Text = "打开";
			}
			Label_Open.BackColor = Color.LightGray;
		}

		private void Label_More_MouseEnter(object sender, EventArgs e)
		{
			Label_More.BackColor = Color.White;
		}
		private void Label_More_MouseLeave(object sender, EventArgs e)
		{
			Label_More.BackColor = Color.LightGray;
		}
		private void Label_More_MouseDown(object sender, MouseEventArgs e)
		{
			Label_More.BackColor = Color.DarkGray;
		}
		private void Label_More_Click(object sender, EventArgs e)
		{
			Label_More.BackColor = Color.LightGray;

			Form_SerialPortSetting FormSetting = new Form_SerialPortSetting(SelectedSerialConfig);
			FormSetting.ShowDialog();

			SelectedSerialConfig = FormSetting.SelectedConfig;
		}
	}
}
