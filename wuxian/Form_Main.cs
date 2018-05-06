using System;
using System.Drawing;
using System.IO.Ports;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using DataUnit = wuxian.PortStateControl.DataUnit;

namespace wuxian
{
	public partial class Form_Main : Form
	{
		private bool isTitleMouseDown = false;
		private Point lastMousePosition = new Point(0, 0);
		private Timer timerRefreshChart = new Timer();
		private Series[] ChartSeries = new Series[4];
		private DataSimulator dataSimulator = new DataSimulator();
		private PortStateControl StateControl = new PortStateControl();

		public OleDbConnection c1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=shujuku.accdb");
		public OleDbConnection c2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=guzhangku.accdb");
		private float[] shangxian = { 100, 100, 100, 100 };
		private float[] xiaxian = { 0, 0, 0, 0 };
		private float[] bianhong = new float[4];
		public int s, h;

		public Form_Main()
		{
			InitializeComponent();

			CheckForIllegalCrossThreadCalls = false;

			Panel_Title.BackColor = Color.FromArgb(40, 0, 0, 0);
			Panel_Minimize.BackColor = Color.FromArgb(0, 0, 0, 0);
			Panel_Close.BackColor = Color.FromArgb(0, 0, 0, 0);
			Panel_Minimize.BackgroundImage = ImageList_Main.Images["picMin.png"];
			Panel_Close.BackgroundImage = ImageList_Main.Images["picCls.png"];

			Button_SerialPortSetting.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 255, 255, 255);
			Button_SerialPortSetting.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 0, 0, 0);
			Button_DataSimulate.FlatAppearance.MouseOverBackColor = Color.FromArgb(32, 255, 255, 255);
			Button_DataSimulate.FlatAppearance.MouseDownBackColor = Color.FromArgb(32, 0, 0, 0);

			timerRefreshChart.Interval = 50;
			timerRefreshChart.Tick += new EventHandler(timerRefreshChart_Tick);

			Chart_Voltage.Series.Clear();
			Chart_Current.Series.Clear();
			for (int i = 0; i < 4; i++)
			{
				ChartSeries[i] = new Series();
				ChartSeries[i].ChartType = SeriesChartType.Spline;
				ChartSeries[i].XValueType = ChartValueType.Time;
				ChartSeries[i].BorderWidth = 2;
				ChartSeries[i].Color = (i < 2) ? Color.FromArgb(255, 0, 0) : Color.FromArgb(0, 0, 255);
				if (i % 2 == 0)
					Chart_Voltage.Series.Add(ChartSeries[i]);
				else
					Chart_Current.Series.Add(ChartSeries[i]);
			}

			dataSimulator.Panel_Main.Location = new Point(0, 460);
			dataSimulator.Panel_Main.Visible = false;
			Panel_Sidebar.Controls.Add(dataSimulator.Panel_Main);

			StateControl.Visible = false;
			StateControl.Location = new Point(0, 460);
			Panel_Sidebar.Controls.Add(StateControl);
			StateControl.BringToFront();

			StateControl.eventRun += new PortStateControl.delegateRun(cm);
		}

		private void Form_Main_Load(object sender, EventArgs e)
		{
			timerRefreshChart.Start();
		}
		
		private void timerRefreshChart_Tick(object sender, EventArgs e)
		{
			if (StateControl.DataUnits.Count == 0) return;

			DataUnit[] DataUnits;
			try
			{
				DataUnits = StateControl.DataUnits.ToArray();
			}
			catch (ArgumentException)	//dataUnits在其他线程中被修改，引发异常
			{
				return;
			}

			DateTime timeNow = DateTime.Now;
			int startIndex = 240;
			TimeSpan timeInterval = new TimeSpan(0, 0, 10);
			for (int i = 0; i < DataUnits.Length; i++)
			{
				if (timeNow - DataUnits[i].Time <= timeInterval)
				{
					startIndex = i;
					break;
				}
			}

			Chart_Voltage.ChartAreas[0].AxisX.Minimum = Chart_Current.ChartAreas[0].AxisX.Minimum = timeNow.Subtract(timeInterval).ToOADate();
			Chart_Voltage.ChartAreas[0].AxisX.Maximum = Chart_Current.ChartAreas[0].AxisX.Maximum = timeNow.ToOADate();
			foreach (Series s in ChartSeries)
				s.Points.Clear();
			for (int i = startIndex; i < DataUnits.Length; i++)
			{
				double time = DataUnits[i].Time.ToOADate();
				ChartSeries[0].Points.AddXY(time, DataUnits[i].PrimaryVoltage);
				ChartSeries[1].Points.AddXY(time, DataUnits[i].PrimaryCurrent);
				ChartSeries[2].Points.AddXY(time, DataUnits[i].SecondaryVoltage);
				ChartSeries[3].Points.AddXY(time, DataUnits[i].SecondaryCurrent);
			}
		}

		private void Panel_Title_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isTitleMouseDown = true;
				lastMousePosition = e.Location;
			}
		}
		private void Panel_Title_MouseMove(object sender, MouseEventArgs e)
		{
			Point NewPosition = Location;
			if (isTitleMouseDown)
			{
				NewPosition.X += e.X - lastMousePosition.X;
				NewPosition.Y += e.Y - lastMousePosition.Y;
				Location = NewPosition;
			}
		}
		private void Panel_Title_MouseUp(object sender, MouseEventArgs e)
		{
			isTitleMouseDown = false;
		}

		private void Panel_Minimize_MouseEnter(object sender, EventArgs e)
		{
			Panel_Minimize.BackColor = Color.FromArgb(36, 255, 255, 255);
		}
		private void Panel_Minimize_MouseLeave(object sender, EventArgs e)
		{
			Panel_Minimize.BackColor = Color.FromArgb(0, 255, 255, 255);
		}
		private void Panel_Minimize_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				Panel_Minimize.BackColor = Color.FromArgb(64, 255, 255, 255);
		}
		private void Panel_Minimize_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				WindowState = FormWindowState.Minimized;
		}

		private void Panel_Close_MouseEnter(object sender, EventArgs e)
		{
			Panel_Close.BackColor = Color.FromArgb(128, 255, 0, 0);
		}
		private void Panel_Close_MouseLeave(object sender, EventArgs e)
		{
			Panel_Close.BackColor = Color.FromArgb(0, 255, 255, 255);
		}
		private void Panel_Close_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				Panel_Close.BackColor = Color.FromArgb(64, 255, 0, 0);
		}
		private void Panel_Close_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
				Close();
		}

		private void Button_SerialPortSetting_Click(object sender, EventArgs e)
		{
			bool StateControlVisable = !StateControl.Visible;
			if (dataSimulator.Panel_Main.Visible == true)
			{
				dataSimulator.Panel_Main.Visible = false;
				Button_DataSimulate.ForeColor = Color.FromArgb(160, 255, 160);
			}
			StateControl.Visible = StateControlVisable;
			Button_SerialPortSetting.ForeColor = StateControlVisable ? Color.FromArgb(255, 255, 32) : Color.FromArgb(160, 255, 160);
		}

		private void Button_DataSimulate_Click(object sender, EventArgs e)
		{
			bool PanelVisible = !dataSimulator.Panel_Main.Visible;
			if (StateControl.Visible == true)
			{
				StateControl.Visible = false;
				Button_SerialPortSetting.ForeColor = Color.FromArgb(160, 255, 160);
			}
			dataSimulator.Panel_Main.Visible = PanelVisible;
			Button_DataSimulate.ForeColor = PanelVisible ? Color.FromArgb(255, 255, 32) : Color.FromArgb(160, 255, 160);
		}

		private void Button_ErrorData_Click(object sender, EventArgs e)
		{
            Form3 f3 = new Form3();
            f3.ShowDialog();
		}
		
		private void Button_HistoryData_Click(object sender, EventArgs e)
		{
            Form2 f2 = new Form2();
            f2.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		public void chucun(DataUnit d1)
		{
			OleDbCommand oc = new OleDbCommand();
			oc.CommandText = "insert into sjb(ybu,ybi,fbu,fbi,l,h,t,ms) values (" + d1.ToString() + ",'" + d1.Time.ToShortDateString() + "',"+d1.Time.TimeOfDay.TotalMilliseconds+")";
			oc.Connection = c1;
			oc.Connection.Open();
			oc.ExecuteNonQuery();
			oc.Connection.Close();
			for (int i = 0; i < 4; i++)
			{
				bianhong[i] = 0;
			}
			if (d1.PrimaryVoltage > shangxian[0])
			{
				bianhong[0] = 1;
			}
			else if (d1.PrimaryVoltage < xiaxian[0])
			{ bianhong[0] = 2; }
			if (d1.PrimaryCurrent > shangxian[1])
			{
				bianhong[1] = 1;
			}
			else if (d1.PrimaryCurrent < xiaxian[1])
			{ bianhong[1] = 2; }
			if (d1.SecondaryVoltage > shangxian[2])
			{
				bianhong[2] = 1;
			}
			else if (d1.SecondaryVoltage < xiaxian[2])
			{ bianhong[2] = 2; }
			if (d1.SecondaryCurrent > shangxian[3])
			{
				bianhong[3] = 1;
			}
			else if (d1.SecondaryCurrent < xiaxian[3])
			{ bianhong[3] = 2; }
			float p = 0;
			for (int i = 0; i < 4; i++)
			{
				p = p + bianhong[i];
			}
			if (p > 0)
				guzhang(d1, bianhong);
		}

		public void guzhang(DataUnit d1, float[] b1)
		{
			OleDbCommand oc1 = new OleDbCommand();
			oc1.CommandText = "insert into gzb(ybu,ybi,fbu,fbi,l,h,ybuu,ybii,fbuu,fbii,t,ms) values (" + d1.ToString() + ",";

			for (int i = 0; i < 4; i++)
			{
				oc1.CommandText = oc1.CommandText + b1[i] + ",";
			}
			oc1.CommandText = oc1.CommandText + "'" + d1.Time.ToShortDateString() + "'";
			oc1.CommandText = oc1.CommandText + (int)d1.Time.TimeOfDay.TotalMilliseconds;
			oc1.CommandText = oc1.CommandText + ")";
			oc1.Connection = c2;
			oc1.Connection.Open();
			oc1.ExecuteNonQuery();
			oc1.Connection.Close();
		}

		private void Button_ManualControl_Click(object sender, EventArgs e)
		{

		}

		public void xqmove(DataUnit d1)
		{
			s = (int)(d1.distance * 7.5);
			h = (int)(d1.height * 7.5);
			pictureBox2.Location = new Point(500 - s, h);
			pictureBox3.Location = new Point(550 - s, 25 + h);
			pictureBox3.Width = s;
			pictureBox4.Height = h;
		}
		public void cm()
		{
			chucun(StateControl.d1);
			xqmove(StateControl.d1);
			char[] c = StateControl.value.ToCharArray();
			foreach (char i in c)
			{
				richTextBox1.Text += string.Format("0x{0:x} ", i);
			}
			richTextBox1.Text += Environment.NewLine;
		}
	}
}
