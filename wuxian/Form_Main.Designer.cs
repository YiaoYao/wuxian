namespace wuxian
{
	partial class Form_Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.Panel_Title = new System.Windows.Forms.Panel();
			this.Panel_Minimize = new System.Windows.Forms.Panel();
			this.Panel_Close = new System.Windows.Forms.Panel();
			this.Panel_Sidebar = new System.Windows.Forms.Panel();
			this.Button_DataSimulate = new System.Windows.Forms.Button();
			this.Button_SerialPortSetting = new System.Windows.Forms.Button();
			this.Button_ErrorData = new System.Windows.Forms.Button();
			this.Button_HistoryData = new System.Windows.Forms.Button();
			this.Button_ManualControl = new System.Windows.Forms.Button();
			this.Chart_Voltage = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.ImageList_Main = new System.Windows.Forms.ImageList(this.components);
			this.Chart_Current = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Label_Voltage = new System.Windows.Forms.Label();
			this.Label_Current = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.Panel_Title.SuspendLayout();
			this.Panel_Sidebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Voltage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Current)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// Panel_Title
			// 
			this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Panel_Title.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_Title.BackgroundImage")));
			this.Panel_Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel_Title.Controls.Add(this.Panel_Minimize);
			this.Panel_Title.Controls.Add(this.Panel_Close);
			this.Panel_Title.Location = new System.Drawing.Point(0, 0);
			this.Panel_Title.Name = "Panel_Title";
			this.Panel_Title.Size = new System.Drawing.Size(1280, 80);
			this.Panel_Title.TabIndex = 0;
			this.Panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_MouseDown);
			this.Panel_Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_MouseMove);
			this.Panel_Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel_Title_MouseUp);
			// 
			// Panel_Minimize
			// 
			this.Panel_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Panel_Minimize.Location = new System.Drawing.Point(1184, 0);
			this.Panel_Minimize.Name = "Panel_Minimize";
			this.Panel_Minimize.Size = new System.Drawing.Size(48, 36);
			this.Panel_Minimize.TabIndex = 0;
			this.Panel_Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Minimize_MouseClick);
			this.Panel_Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Minimize_MouseDown);
			this.Panel_Minimize.MouseEnter += new System.EventHandler(this.Panel_Minimize_MouseEnter);
			this.Panel_Minimize.MouseLeave += new System.EventHandler(this.Panel_Minimize_MouseLeave);
			// 
			// Panel_Close
			// 
			this.Panel_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Panel_Close.Location = new System.Drawing.Point(1232, 0);
			this.Panel_Close.Name = "Panel_Close";
			this.Panel_Close.Size = new System.Drawing.Size(48, 36);
			this.Panel_Close.TabIndex = 0;
			this.Panel_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Panel_Close_MouseClick);
			this.Panel_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Close_MouseDown);
			this.Panel_Close.MouseEnter += new System.EventHandler(this.Panel_Close_MouseEnter);
			this.Panel_Close.MouseLeave += new System.EventHandler(this.Panel_Close_MouseLeave);
			// 
			// Panel_Sidebar
			// 
			this.Panel_Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Panel_Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Panel_Sidebar.Controls.Add(this.Button_DataSimulate);
			this.Panel_Sidebar.Controls.Add(this.Button_SerialPortSetting);
			this.Panel_Sidebar.Controls.Add(this.Button_ErrorData);
			this.Panel_Sidebar.Controls.Add(this.Button_HistoryData);
			this.Panel_Sidebar.Controls.Add(this.Button_ManualControl);
			this.Panel_Sidebar.Location = new System.Drawing.Point(0, 80);
			this.Panel_Sidebar.Name = "Panel_Sidebar";
			this.Panel_Sidebar.Size = new System.Drawing.Size(200, 720);
			this.Panel_Sidebar.TabIndex = 1;
			// 
			// Button_DataSimulate
			// 
			this.Button_DataSimulate.FlatAppearance.BorderSize = 0;
			this.Button_DataSimulate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_DataSimulate.Font = new System.Drawing.Font("微软雅黑", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Button_DataSimulate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
			this.Button_DataSimulate.Location = new System.Drawing.Point(0, 376);
			this.Button_DataSimulate.Name = "Button_DataSimulate";
			this.Button_DataSimulate.Size = new System.Drawing.Size(200, 84);
			this.Button_DataSimulate.TabIndex = 0;
			this.Button_DataSimulate.Text = "数据模拟";
			this.Button_DataSimulate.UseVisualStyleBackColor = true;
			this.Button_DataSimulate.Click += new System.EventHandler(this.Button_DataSimulate_Click);
			// 
			// Button_SerialPortSetting
			// 
			this.Button_SerialPortSetting.FlatAppearance.BorderSize = 0;
			this.Button_SerialPortSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_SerialPortSetting.Font = new System.Drawing.Font("微软雅黑", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Button_SerialPortSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
			this.Button_SerialPortSetting.Location = new System.Drawing.Point(0, 292);
			this.Button_SerialPortSetting.Name = "Button_SerialPortSetting";
			this.Button_SerialPortSetting.Size = new System.Drawing.Size(200, 84);
			this.Button_SerialPortSetting.TabIndex = 0;
			this.Button_SerialPortSetting.Text = "串口设置";
			this.Button_SerialPortSetting.UseVisualStyleBackColor = true;
			this.Button_SerialPortSetting.Click += new System.EventHandler(this.Button_SerialPortSetting_Click);
			// 
			// Button_ErrorData
			// 
			this.Button_ErrorData.FlatAppearance.BorderSize = 0;
			this.Button_ErrorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_ErrorData.Font = new System.Drawing.Font("微软雅黑", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Button_ErrorData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
			this.Button_ErrorData.Location = new System.Drawing.Point(0, 208);
			this.Button_ErrorData.Name = "Button_ErrorData";
			this.Button_ErrorData.Size = new System.Drawing.Size(200, 84);
			this.Button_ErrorData.TabIndex = 0;
			this.Button_ErrorData.Text = "故障数据";
			this.Button_ErrorData.UseVisualStyleBackColor = true;
			this.Button_ErrorData.Click += new System.EventHandler(this.Button_ErrorData_Click);
			// 
			// Button_HistoryData
			// 
			this.Button_HistoryData.FlatAppearance.BorderSize = 0;
			this.Button_HistoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_HistoryData.Font = new System.Drawing.Font("微软雅黑", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Button_HistoryData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
			this.Button_HistoryData.Location = new System.Drawing.Point(0, 124);
			this.Button_HistoryData.Name = "Button_HistoryData";
			this.Button_HistoryData.Size = new System.Drawing.Size(200, 84);
			this.Button_HistoryData.TabIndex = 0;
			this.Button_HistoryData.Text = "历史数据";
			this.Button_HistoryData.UseVisualStyleBackColor = true;
			this.Button_HistoryData.Click += new System.EventHandler(this.Button_HistoryData_Click);
			// 
			// Button_ManualControl
			// 
			this.Button_ManualControl.FlatAppearance.BorderSize = 0;
			this.Button_ManualControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_ManualControl.Font = new System.Drawing.Font("微软雅黑", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Button_ManualControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
			this.Button_ManualControl.Location = new System.Drawing.Point(0, 40);
			this.Button_ManualControl.Name = "Button_ManualControl";
			this.Button_ManualControl.Size = new System.Drawing.Size(200, 84);
			this.Button_ManualControl.TabIndex = 0;
			this.Button_ManualControl.Text = "手动控制";
			this.Button_ManualControl.UseVisualStyleBackColor = true;
			// 
			// Chart_Voltage
			// 
			this.Chart_Voltage.BackColor = System.Drawing.Color.Transparent;
			this.Chart_Voltage.BorderlineWidth = 0;
			chartArea3.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
			chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
			chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea3.AxisX.IsLabelAutoFit = false;
			chartArea3.AxisX.IsStartedFromZero = false;
			chartArea3.AxisX.LabelAutoFitMaxFontSize = 12;
			chartArea3.AxisX.LabelAutoFitMinFontSize = 10;
			chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
			chartArea3.AxisX.LabelStyle.Format = "hh:mm:ss";
			chartArea3.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea3.AxisX.LabelStyle.TruncatedLabels = true;
			chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			chartArea3.AxisX.LineWidth = 2;
			chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
			chartArea3.AxisX.MajorGrid.LineWidth = 2;
			chartArea3.AxisX.MajorTickMark.Enabled = false;
			chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisY.IsLabelAutoFit = false;
			chartArea3.AxisY.LabelAutoFitMaxFontSize = 12;
			chartArea3.AxisY.LabelAutoFitMinFontSize = 10;
			chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
			chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			chartArea3.AxisY.LineWidth = 2;
			chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
			chartArea3.AxisY.MajorGrid.LineWidth = 2;
			chartArea3.AxisY.MajorTickMark.Enabled = false;
			chartArea3.BackColor = System.Drawing.Color.Transparent;
			chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea3.BorderWidth = 3;
			chartArea3.Name = "ChartArea1";
			chartArea3.Position.Auto = false;
			chartArea3.Position.Height = 100F;
			chartArea3.Position.Width = 100F;
			this.Chart_Voltage.ChartAreas.Add(chartArea3);
			legend3.Enabled = false;
			legend3.Name = "Legend1";
			legend3.Title = "电压";
			this.Chart_Voltage.Legends.Add(legend3);
			this.Chart_Voltage.Location = new System.Drawing.Point(206, 86);
			this.Chart_Voltage.Name = "Chart_Voltage";
			series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
			series3.BackSecondaryColor = System.Drawing.Color.Gray;
			series3.BorderColor = System.Drawing.Color.Transparent;
			series3.BorderWidth = 3;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
			series3.Color = System.Drawing.Color.Black;
			series3.Legend = "Legend1";
			series3.LegendText = "电压";
			series3.MarkerBorderColor = System.Drawing.Color.Black;
			series3.Name = "Series1";
			series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
			this.Chart_Voltage.Series.Add(series3);
			this.Chart_Voltage.Size = new System.Drawing.Size(520, 320);
			this.Chart_Voltage.TabIndex = 0;
			this.Chart_Voltage.Text = "Voltage";
			// 
			// ImageList_Main
			// 
			this.ImageList_Main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_Main.ImageStream")));
			this.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList_Main.Images.SetKeyName(0, "picCls.png");
			this.ImageList_Main.Images.SetKeyName(1, "picMin.png");
			// 
			// Chart_Current
			// 
			this.Chart_Current.BackColor = System.Drawing.Color.Transparent;
			this.Chart_Current.BorderlineWidth = 0;
			chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
			chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea4.AxisX.IsLabelAutoFit = false;
			chartArea4.AxisX.IsStartedFromZero = false;
			chartArea4.AxisX.LabelAutoFitMaxFontSize = 14;
			chartArea4.AxisX.LabelAutoFitMinFontSize = 12;
			chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			chartArea4.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
			chartArea4.AxisX.LabelStyle.Format = "hh:mm:ss";
			chartArea4.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea4.AxisX.LabelStyle.TruncatedLabels = true;
			chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			chartArea4.AxisX.LineWidth = 2;
			chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
			chartArea4.AxisX.MajorGrid.LineWidth = 2;
			chartArea4.AxisX.MajorTickMark.Enabled = false;
			chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea4.AxisY.IsLabelAutoFit = false;
			chartArea4.AxisY.LabelAutoFitMaxFontSize = 16;
			chartArea4.AxisY.LabelAutoFitMinFontSize = 14;
			chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
			chartArea4.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
			chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			chartArea4.AxisY.LineWidth = 2;
			chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
			chartArea4.AxisY.MajorGrid.LineWidth = 2;
			chartArea4.AxisY.MajorTickMark.Enabled = false;
			chartArea4.BackColor = System.Drawing.Color.Transparent;
			chartArea4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(96)))), ((int)(((byte)(192)))));
			chartArea4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
			chartArea4.BorderWidth = 3;
			chartArea4.Name = "ChartArea1";
			chartArea4.Position.Auto = false;
			chartArea4.Position.Height = 100F;
			chartArea4.Position.Width = 100F;
			this.Chart_Current.ChartAreas.Add(chartArea4);
			legend4.Enabled = false;
			legend4.Name = "Legend1";
			legend4.Title = "电流";
			this.Chart_Current.Legends.Add(legend4);
			this.Chart_Current.Location = new System.Drawing.Point(732, 86);
			this.Chart_Current.Name = "Chart_Current";
			series4.BorderWidth = 2;
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
			this.Chart_Current.Series.Add(series4);
			this.Chart_Current.Size = new System.Drawing.Size(520, 320);
			this.Chart_Current.TabIndex = 0;
			this.Chart_Current.Text = "Current";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(742, 421);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 300);
			this.panel1.TabIndex = 6;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.pictureBox3.Location = new System.Drawing.Point(50, 275);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(300, 1);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 250);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 50);
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.pictureBox4.Location = new System.Drawing.Point(350, 25);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(1, 250);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(300, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(231, 425);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 25);
			this.label1.TabIndex = 7;
			this.label1.Text = "电压";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(231, 525);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "电流";
			// 
			// Label_Voltage
			// 
			this.Label_Voltage.AutoSize = true;
			this.Label_Voltage.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label_Voltage.Location = new System.Drawing.Point(225, 450);
			this.Label_Voltage.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label_Voltage.Name = "Label_Voltage";
			this.Label_Voltage.Size = new System.Drawing.Size(95, 62);
			this.Label_Voltage.TabIndex = 8;
			this.Label_Voltage.Text = "0.0";
			// 
			// Label_Current
			// 
			this.Label_Current.AutoSize = true;
			this.Label_Current.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label_Current.Location = new System.Drawing.Point(225, 550);
			this.Label_Current.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.Label_Current.Name = "Label_Current";
			this.Label_Current.Size = new System.Drawing.Size(95, 62);
			this.Label_Current.TabIndex = 8;
			this.Label_Current.Text = "0.0";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label5.Location = new System.Drawing.Point(350, 450);
			this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 62);
			this.label5.TabIndex = 8;
			this.label5.Text = "V";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label6.Location = new System.Drawing.Point(350, 550);
			this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 62);
			this.label6.TabIndex = 8;
			this.label6.Text = "A";
			// 
			// Form_Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.Label_Current);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Label_Voltage);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Chart_Current);
			this.Controls.Add(this.Panel_Sidebar);
			this.Controls.Add(this.Panel_Title);
			this.Controls.Add(this.Chart_Voltage);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Main";
			this.Load += new System.EventHandler(this.Form_Main_Load);
			this.Panel_Title.ResumeLayout(false);
			this.Panel_Sidebar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart_Voltage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Current)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Panel_Title;
		private System.Windows.Forms.Panel Panel_Sidebar;
		private System.Windows.Forms.Panel Panel_Minimize;
		private System.Windows.Forms.Panel Panel_Close;
		private System.Windows.Forms.ImageList ImageList_Main;
		private System.Windows.Forms.Button Button_DataSimulate;
		private System.Windows.Forms.Button Button_SerialPortSetting;
		private System.Windows.Forms.Button Button_HistoryData;
		private System.Windows.Forms.Button Button_ManualControl;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Voltage;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Current;
		private System.Windows.Forms.Button Button_ErrorData;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Label_Voltage;
		private System.Windows.Forms.Label Label_Current;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}