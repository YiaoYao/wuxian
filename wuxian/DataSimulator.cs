using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;

namespace wuxian
{
	class DataSimulator
	{
		const double EPSILON = Double.MinValue;
		const double PI_2 = 2.0 * 3.1415926535897932384626;

		double z1;
		bool generate = false;
		Random r = new Random();

		private SerialPort destinationPort = new SerialPort();
		private string[] serialPortList = new string[0];
		public Panel Panel_Main = new Panel();
		private ComboBox ComboBox_SerialPortList = new ComboBox();
		private Button Button_Open = new Button();
		private Button Button_forward = new Button();
		private Button Button_backward = new Button();
		private double l;

		public DataSimulator()
		{
			destinationPort.DataReceived += new SerialDataReceivedEventHandler(destinationPort_DataReceived);
			ComboBox_SerialPortList.SelectedIndexChanged += new EventHandler(ComboBox_SerialPortList_SelectedIndexChanged);
			Button_Open.Click += new EventHandler(Button_Open_Click);

			destinationPort.BaudRate = 115200;
			destinationPort.DataBits = 8;
			destinationPort.StopBits = StopBits.One;
			destinationPort.Parity = Parity.None;

			Panel_Main.Size = new Size(200, 69);
			Panel_Main.BackColor = Color.FromArgb(64, 0, 0, 0);

			ComboBox_SerialPortList.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_SerialPortList.Font = new Font("微软雅黑", 14.25f);
			ComboBox_SerialPortList.Location = new Point(12, 18);
			ComboBox_SerialPortList.Width = 108;

			Button_Open.BackColor = Color.FromArgb(216, 240, 255, 255);
			Button_Open.FlatAppearance.MouseOverBackColor = Color.FromArgb(216, 192, 255, 255);
			Button_Open.FlatAppearance.MouseDownBackColor = Color.FromArgb(108, 240, 255, 255);
			Button_Open.FlatAppearance.BorderSize = 0;
			Button_Open.FlatStyle = FlatStyle.Flat;
			Button_Open.Font = new Font("微软雅黑", 12.0f);
			Button_Open.Location = new Point(126, 18);
			Button_Open.Size = new Size(71, 33);
			Button_Open.Text = "打开";

			//Button_forward.Location=new Point()

			Panel_Main.Controls.Add(ComboBox_SerialPortList);
			Panel_Main.Controls.Add(Button_Open);

			RefreshSerialPortList();

			l = 12.0;
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
				if (destinationPort.PortName == ComboBox_SerialPortList.Items[i].ToString())
				{
					ComboBox_SerialPortList.SelectedIndex = i;
					break;
				}
			}
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

				if (IsExist) destinationPort.PortName = SelectedName;
				else
				{
					MessageBox.Show("串口不存在");
					RefreshSerialPortList();
				}
			}
		}

		private void destinationPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			double[] data = new double[5];

			if (((SerialPort)sender).ReadExisting() == "s" + Environment.NewLine)
			{
				for (int i = 0; i < 5; i++)
				{
					data[i] = GenerateGaussianNoise(11.0 + i, 0.04);
				}
				destinationPort.Write(String.Format("{0:N2},{1:N2},{2:N2},{3:N2},{4:N2}", data[0], data[1], data[2], data[3], data[4]) + Environment.NewLine);
			}
		}

		private void Button_Open_Click(object sender, EventArgs e)
		{
			if (Button_Open.Text == "打开")
			{
				try
				{
					destinationPort.Open();
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
				Button_Open.Text = "关闭";
			}
			else
			{
				if (destinationPort.IsOpen) destinationPort.Close();
				Button_Open.Text = "打开";
			}
		}

		/// <summary>
		/// 生成呈正态分布的伪随机浮点数
		/// </summary>
		/// <param name="mu">μ</param>
		/// <param name="sigma">σ</param>
		/// <returns></returns>
		public double GenerateGaussianNoise(double mu, double sigma)
		{
			generate = !generate;

			if (!generate)
			{
				return z1 * sigma + mu;
			}

			double u1, u2;
			do
			{
				u1 = r.NextDouble();
				u2 = r.NextDouble();
			}
			while (u1 <= EPSILON);

			double z0;
			z0 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(PI_2 * u2);
			z1 = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(PI_2 * u2);

			return z0 * sigma + mu;
		}
	}
}
