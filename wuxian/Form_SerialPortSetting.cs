using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace wuxian
{
	[System.Runtime.InteropServices.ComVisible(true)]
	public partial class Form_SerialPortSetting : Form
	{
		public struct SerialPortConfig
		{
			public SerialPortConfig(string portName = "", int baudRateIndex = 0, int dataBitsIndex = 0, StopBits stopBits = StopBits.One, Parity parity = Parity.None)
			{
				PortName = portName;
				this.baudRateIndex = baudRateIndex;
				this.dataBitsIndex = dataBitsIndex;
				StopBits = stopBits;
				Parity = parity;
			}
			public string PortName { get; set; }
			public int BaudRate
			{
				get { return BaudRateList[baudRateIndex]; }
				set
				{
					for (int i = 0; i < 8; i++)
						if (value == BaudRateList[i])
						{
							baudRateIndex = i;
							break;
						}
				}
			}
			public int DataBits
			{
				get { return DataBitsList[dataBitsIndex]; }
				set
				{
					for (int i = 0; i < 3; i++)
						if (value == DataBitsList[i])
						{
							dataBitsIndex = i;
							break;
						}
				}
			}
			public StopBits StopBits { get; set; }
			public Parity Parity { get; set; }
			public int BaudRateIndex
			{
				get { return baudRateIndex; }
				set { if (value >= 0 && value < 8) baudRateIndex = value; }
			}
			public int DataBitsIndex
			{
				get { return dataBitsIndex; }
				set { if (value >= 0 && value < 3) dataBitsIndex = value; }
			}

			private int baudRateIndex;
			private int dataBitsIndex;
		}

		public static int[] BaudRateList = { 115200, 57600, 38400, 19200, 9600, 4800, 2400, 1200 };
		public static int[] DataBitsList = { 8, 7, 6 };
		public SerialPortConfig SelectedConfig
		{
			get { return selectedConfig; }
			set { }
		}

		private SerialPortConfig selectedConfig;
		private SerialPortConfig originalConfig;
		private string[] serialPortList = new string[0];

		public Form_SerialPortSetting(SerialPortConfig initialConfig = new SerialPortConfig())
		{
			InitializeComponent();

			Button_Accept.BackgroundImage = ImageList_Main.Images["Button_Circle.png"];
			Button_Cancel.BackgroundImage = ImageList_Main.Images["Button_Cross.png"];
			Button_Accept.Tag = 0;
			Button_Cancel.Tag = 0;
			
			selectedConfig = initialConfig;
			originalConfig = initialConfig;

			RefreshSerialPortList();

			if (serialPortList.Length == 0)
				ComboBox_SerialPortList.Items.Add("刷新");
			ComboBox_BaudRate.SelectedIndex = initialConfig.BaudRateIndex;
			ComboBox_DataBits.SelectedIndex = initialConfig.DataBitsIndex;
			ComboBox_StopBits.SelectedIndex = (int)initialConfig.StopBits;
			ComboBox_Parity.SelectedIndex = (int)initialConfig.Parity;

		}

		private void RefreshSerialPortList()
		{
			string[] NewList = SerialPort.GetPortNames();

			if (!serialPortList.SequenceEqual(NewList))
			{
				serialPortList = NewList;
				ComboBox_SerialPortList.Items.Clear();

				foreach (var port in serialPortList)
					ComboBox_SerialPortList.Items.Add(port);
				ComboBox_SerialPortList.Items.Add("刷新");
			}
			ComboBox_SerialPortList.SelectedIndex = -1;

			for (int i = 0; i < serialPortList.Length; i++)
			{
				if (selectedConfig.PortName == ComboBox_SerialPortList.Items[i].ToString())
				{
					ComboBox_SerialPortList.SelectedIndex = i;
					break;
				}
			}
		}

		private void Form_SerialPortSetting_Load(object sender, EventArgs e)
		{
			try
			{
				string htmlPath = Environment.CurrentDirectory + "\\page.html";
				WebBrowser_Main.Navigate(htmlPath);
				WebBrowser_Main.ObjectForScripting = this;
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString());
				return;
			}
		}

		private void Button_Accept_MouseMove(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);
			
			if (r_2 < 580)
			{
				if ((int)Button_Accept.Tag == 1)
					Button_Accept.BackgroundImage = ImageList_Main.Images["Button_Circle_Down.png"];
				else
					Button_Accept.BackgroundImage = ImageList_Main.Images["Button_Circle_Over.png"];
			}
			else
				Button_Accept.BackgroundImage = ImageList_Main.Images["Button_Circle.png"];
		}
		private void Button_Accept_MouseDown(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580)
			{
				Button_Accept.BackgroundImage = ImageList_Main.Images["Button_Circle_Down.png"];
				Button_Accept.Tag = 1;
			}
			else
				Button_Accept.BackgroundImage = ImageList_Main.Images["Button_Circle.png"];
		}
		private void Button_Accept_MouseUp(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580)
				Button_Accept.Tag = 0;
		}

		private void Button_Cancel_MouseMove(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580)
			{
				if ((int)Button_Cancel.Tag == 1)
					Button_Cancel.BackgroundImage = ImageList_Main.Images["Button_Cross_Down.png"];
				else
					Button_Cancel.BackgroundImage = ImageList_Main.Images["Button_Cross_Over.png"];
			}
			else
				Button_Cancel.BackgroundImage = ImageList_Main.Images["Button_Cross.png"];
		}
		private void Button_Cancel_MouseDown(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580)
			{
				Button_Cancel.BackgroundImage = ImageList_Main.Images["Button_Cross_Down.png"];
				Button_Cancel.Tag = 1;
			}
			else
				Button_Cancel.BackgroundImage = ImageList_Main.Images["Button_Cross.png"];

		}
		private void Button_Cancel_MouseUp(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580)
				Button_Cancel.Tag = 0;
		}

		private void ComboBox_SerialPortList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboBox_SerialPortList.SelectedIndex == serialPortList.Length)
				RefreshSerialPortList();
			else
			{
				if (ComboBox_SerialPortList.SelectedIndex == -1) return;

				string[] NewList = SerialPort.GetPortNames();
				string SelectedName = ComboBox_SerialPortList.SelectedItem.ToString();

				bool IsExist = false;
				foreach (var port in NewList)
					if (port == SelectedName) IsExist = true;

				if (IsExist) selectedConfig.PortName = SelectedName;
				else
				{
					MessageBox.Show("串口不存在");
					RefreshSerialPortList();
				}
			}
		}
		private void ComboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedConfig.BaudRateIndex = ComboBox_BaudRate.SelectedIndex;
		}
		private void ComboBox_DataBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedConfig.DataBitsIndex = ComboBox_DataBits.SelectedIndex;
		}
		private void ComboBox_StopBits_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedConfig.StopBits = (StopBits)ComboBox_StopBits.SelectedIndex;
		}
		private void ComboBox_Parity_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedConfig.Parity = (Parity)ComboBox_Parity.SelectedIndex;
		}

		private void Button_Accept_MouseClick(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580) Close();
		}
		private void Button_Cancel_MouseClick(object sender, MouseEventArgs e)
		{
			double r_2 = Math.Pow(e.Location.X - 40, 2.0) + Math.Pow(e.Location.Y - 40, 2.0);

			if (r_2 < 580)
			{
				selectedConfig = originalConfig;
				Close();
			}
		}
	}
}
