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
			this.Panel_SerialPortState = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.Chart_Current = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.Panel_Title.SuspendLayout();
			this.Panel_Sidebar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Chart_Voltage)).BeginInit();
			this.Panel_SerialPortState.SuspendLayout();
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
			chartArea3.AxisX.Crossing = -1.7976931348623157E+308D;
			chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea3.AxisX.IsStartedFromZero = false;
			chartArea3.AxisX.LabelStyle.Format = "hh:mm:ss";
			chartArea3.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea3.AxisX.LabelStyle.TruncatedLabels = true;
			chartArea3.AxisX.LineWidth = 2;
			chartArea3.AxisX.MajorGrid.Enabled = false;
			chartArea3.AxisX.MajorTickMark.Enabled = false;
			chartArea3.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea3.AxisY.LineWidth = 2;
			chartArea3.AxisY.MajorGrid.Enabled = false;
			chartArea3.AxisY.MajorTickMark.Enabled = false;
			chartArea3.BackColor = System.Drawing.Color.Transparent;
			chartArea3.BorderWidth = 0;
			chartArea3.Name = "ChartArea1";
			chartArea3.Position.Auto = false;
			chartArea3.Position.Height = 100F;
			chartArea3.Position.Width = 100F;
			this.Chart_Voltage.ChartAreas.Add(chartArea3);
			legend3.Enabled = false;
			legend3.Name = "Legend1";
			this.Chart_Voltage.Legends.Add(legend3);
			this.Chart_Voltage.Location = new System.Drawing.Point(206, 86);
			this.Chart_Voltage.Name = "Chart_Voltage";
			series3.BorderWidth = 2;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Legend = "Legend1";
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
			// Panel_SerialPortState
			// 
			this.Panel_SerialPortState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Panel_SerialPortState.Controls.Add(this.button3);
			this.Panel_SerialPortState.Controls.Add(this.button4);
			this.Panel_SerialPortState.Controls.Add(this.button2);
			this.Panel_SerialPortState.Controls.Add(this.button1);
			this.Panel_SerialPortState.Location = new System.Drawing.Point(200, 372);
			this.Panel_SerialPortState.Name = "Panel_SerialPortState";
			this.Panel_SerialPortState.Size = new System.Drawing.Size(200, 275);
			this.Panel_SerialPortState.TabIndex = 3;
			this.Panel_SerialPortState.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(47, 167);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(110, 69);
			this.button3.TabIndex = 1;
			this.button3.Text = "More";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(47, 17);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(110, 69);
			this.button4.TabIndex = 1;
			this.button4.Text = "COM?";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(47, 92);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 69);
			this.button2.TabIndex = 1;
			this.button2.Text = "打开";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 40);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Chart_Current
			// 
			this.Chart_Current.BackColor = System.Drawing.Color.Transparent;
			this.Chart_Current.BorderlineWidth = 0;
			chartArea4.AxisX.Crossing = -1.7976931348623157E+308D;
			chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea4.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea4.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
			chartArea4.AxisX.IsStartedFromZero = false;
			chartArea4.AxisX.LabelStyle.Format = "hh:mm:ss";
			chartArea4.AxisX.LabelStyle.IsEndLabelVisible = false;
			chartArea4.AxisX.LabelStyle.TruncatedLabels = true;
			chartArea4.AxisX.LineWidth = 2;
			chartArea4.AxisX.MajorGrid.Enabled = false;
			chartArea4.AxisX.MajorTickMark.Enabled = false;
			chartArea4.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea4.AxisY.LineWidth = 2;
			chartArea4.AxisY.MajorGrid.Enabled = false;
			chartArea4.AxisY.MajorTickMark.Enabled = false;
			chartArea4.BackColor = System.Drawing.Color.Transparent;
			chartArea4.BorderWidth = 0;
			chartArea4.Name = "ChartArea1";
			chartArea4.Position.Auto = false;
			chartArea4.Position.Height = 100F;
			chartArea4.Position.Width = 100F;
			this.Chart_Current.ChartAreas.Add(chartArea4);
			legend4.Enabled = false;
			legend4.Name = "Legend1";
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
			this.pictureBox3.Size = new System.Drawing.Size(400, 1);
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
			this.pictureBox4.Location = new System.Drawing.Point(450, 25);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(1, 250);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Location = new System.Drawing.Point(400, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.richTextBox1.Location = new System.Drawing.Point(432, 412);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(249, 376);
			this.richTextBox1.TabIndex = 7;
			this.richTextBox1.Text = "";
			// 
			// Form_Main
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1280, 800);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Panel_SerialPortState);
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
			this.Panel_SerialPortState.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Chart_Current)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

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
		private System.Windows.Forms.Panel Panel_SerialPortState;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.DataVisualization.Charting.Chart Chart_Current;
		private System.Windows.Forms.Button Button_ErrorData;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}