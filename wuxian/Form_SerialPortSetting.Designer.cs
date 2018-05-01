namespace wuxian
{
	partial class Form_SerialPortSetting
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SerialPortSetting));
			this.WebBrowser_Main = new System.Windows.Forms.WebBrowser();
			this.ComboBox_Parity = new System.Windows.Forms.ComboBox();
			this.ComboBox_StopBits = new System.Windows.Forms.ComboBox();
			this.ComboBox_DataBits = new System.Windows.Forms.ComboBox();
			this.ComboBox_BaudRate = new System.Windows.Forms.ComboBox();
			this.ComboBox_SerialPortList = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Button_Cancel = new System.Windows.Forms.Button();
			this.Button_Accept = new System.Windows.Forms.Button();
			this.ImageList_Main = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// WebBrowser_Main
			// 
			this.WebBrowser_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WebBrowser_Main.Location = new System.Drawing.Point(0, 0);
			this.WebBrowser_Main.MinimumSize = new System.Drawing.Size(20, 20);
			this.WebBrowser_Main.Name = "WebBrowser_Main";
			this.WebBrowser_Main.Size = new System.Drawing.Size(360, 540);
			this.WebBrowser_Main.TabIndex = 0;
			this.WebBrowser_Main.TabStop = false;
			// 
			// ComboBox_Parity
			// 
			this.ComboBox_Parity.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ComboBox_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_Parity.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ComboBox_Parity.FormattingEnabled = true;
			this.ComboBox_Parity.ItemHeight = 28;
			this.ComboBox_Parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
			this.ComboBox_Parity.Location = new System.Drawing.Point(150, 370);
			this.ComboBox_Parity.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.ComboBox_Parity.Name = "ComboBox_Parity";
			this.ComboBox_Parity.Size = new System.Drawing.Size(150, 36);
			this.ComboBox_Parity.TabIndex = 2;
			this.ComboBox_Parity.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Parity_SelectedIndexChanged);
			// 
			// ComboBox_StopBits
			// 
			this.ComboBox_StopBits.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ComboBox_StopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_StopBits.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ComboBox_StopBits.FormattingEnabled = true;
			this.ComboBox_StopBits.ItemHeight = 28;
			this.ComboBox_StopBits.Items.AddRange(new object[] {
            "None",
            "One",
            "Two",
            "OnePointFive"});
			this.ComboBox_StopBits.Location = new System.Drawing.Point(150, 304);
			this.ComboBox_StopBits.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.ComboBox_StopBits.Name = "ComboBox_StopBits";
			this.ComboBox_StopBits.Size = new System.Drawing.Size(150, 36);
			this.ComboBox_StopBits.TabIndex = 3;
			this.ComboBox_StopBits.SelectedIndexChanged += new System.EventHandler(this.ComboBox_StopBits_SelectedIndexChanged);
			// 
			// ComboBox_DataBits
			// 
			this.ComboBox_DataBits.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ComboBox_DataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_DataBits.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ComboBox_DataBits.FormattingEnabled = true;
			this.ComboBox_DataBits.ItemHeight = 28;
			this.ComboBox_DataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
			this.ComboBox_DataBits.Location = new System.Drawing.Point(150, 238);
			this.ComboBox_DataBits.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.ComboBox_DataBits.Name = "ComboBox_DataBits";
			this.ComboBox_DataBits.Size = new System.Drawing.Size(150, 36);
			this.ComboBox_DataBits.TabIndex = 4;
			this.ComboBox_DataBits.SelectedIndexChanged += new System.EventHandler(this.ComboBox_DataBits_SelectedIndexChanged);
			// 
			// ComboBox_BaudRate
			// 
			this.ComboBox_BaudRate.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ComboBox_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_BaudRate.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ComboBox_BaudRate.FormattingEnabled = true;
			this.ComboBox_BaudRate.ItemHeight = 28;
			this.ComboBox_BaudRate.Items.AddRange(new object[] {
            "115200",
            "57600",
            "38400",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200"});
			this.ComboBox_BaudRate.Location = new System.Drawing.Point(150, 172);
			this.ComboBox_BaudRate.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.ComboBox_BaudRate.Name = "ComboBox_BaudRate";
			this.ComboBox_BaudRate.Size = new System.Drawing.Size(150, 36);
			this.ComboBox_BaudRate.TabIndex = 5;
			this.ComboBox_BaudRate.SelectedIndexChanged += new System.EventHandler(this.ComboBox_BaudRate_SelectedIndexChanged);
			// 
			// ComboBox_SerialPortList
			// 
			this.ComboBox_SerialPortList.BackColor = System.Drawing.Color.LightSkyBlue;
			this.ComboBox_SerialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_SerialPortList.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.ComboBox_SerialPortList.FormattingEnabled = true;
			this.ComboBox_SerialPortList.ItemHeight = 28;
			this.ComboBox_SerialPortList.Location = new System.Drawing.Point(150, 106);
			this.ComboBox_SerialPortList.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
			this.ComboBox_SerialPortList.Name = "ComboBox_SerialPortList";
			this.ComboBox_SerialPortList.Size = new System.Drawing.Size(150, 36);
			this.ComboBox_SerialPortList.TabIndex = 6;
			this.ComboBox_SerialPortList.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SerialPortList_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Button_Cancel);
			this.panel1.Controls.Add(this.Button_Accept);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 460);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 80);
			this.panel1.TabIndex = 7;
			// 
			// Button_Cancel
			// 
			this.Button_Cancel.BackColor = System.Drawing.Color.White;
			this.Button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Button_Cancel.FlatAppearance.BorderSize = 0;
			this.Button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.Button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_Cancel.Location = new System.Drawing.Point(230, 0);
			this.Button_Cancel.Name = "Button_Cancel";
			this.Button_Cancel.Size = new System.Drawing.Size(80, 80);
			this.Button_Cancel.TabIndex = 0;
			this.Button_Cancel.UseVisualStyleBackColor = false;
			this.Button_Cancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_Cancel_MouseClick);
			this.Button_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Cancel_MouseDown);
			this.Button_Cancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Cancel_MouseMove);
			this.Button_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Cancel_MouseUp);
			// 
			// Button_Accept
			// 
			this.Button_Accept.BackColor = System.Drawing.Color.White;
			this.Button_Accept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Button_Accept.FlatAppearance.BorderSize = 0;
			this.Button_Accept.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
			this.Button_Accept.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.Button_Accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_Accept.Location = new System.Drawing.Point(50, 0);
			this.Button_Accept.Name = "Button_Accept";
			this.Button_Accept.Size = new System.Drawing.Size(80, 80);
			this.Button_Accept.TabIndex = 0;
			this.Button_Accept.UseVisualStyleBackColor = false;
			this.Button_Accept.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button_Accept_MouseClick);
			this.Button_Accept.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Accept_MouseDown);
			this.Button_Accept.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Button_Accept_MouseMove);
			this.Button_Accept.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Accept_MouseUp);
			// 
			// ImageList_Main
			// 
			this.ImageList_Main.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList_Main.ImageStream")));
			this.ImageList_Main.TransparentColor = System.Drawing.Color.Transparent;
			this.ImageList_Main.Images.SetKeyName(0, "Button_Circle.png");
			this.ImageList_Main.Images.SetKeyName(1, "Button_Circle_Down.png");
			this.ImageList_Main.Images.SetKeyName(2, "Button_Circle_Over.png");
			this.ImageList_Main.Images.SetKeyName(3, "Button_Cross.png");
			this.ImageList_Main.Images.SetKeyName(4, "Button_Cross_Down.png");
			this.ImageList_Main.Images.SetKeyName(5, "Button_Cross_Over.png");
			// 
			// Form_SerialPortSetting
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(360, 540);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ComboBox_Parity);
			this.Controls.Add(this.ComboBox_StopBits);
			this.Controls.Add(this.ComboBox_DataBits);
			this.Controls.Add(this.ComboBox_BaudRate);
			this.Controls.Add(this.ComboBox_SerialPortList);
			this.Controls.Add(this.WebBrowser_Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_SerialPortSetting";
			this.Opacity = 0.84D;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "串口设置";
			this.Load += new System.EventHandler(this.Form_SerialPortSetting_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.WebBrowser WebBrowser_Main;
		private System.Windows.Forms.ComboBox ComboBox_Parity;
		private System.Windows.Forms.ComboBox ComboBox_StopBits;
		private System.Windows.Forms.ComboBox ComboBox_DataBits;
		private System.Windows.Forms.ComboBox ComboBox_BaudRate;
		private System.Windows.Forms.ComboBox ComboBox_SerialPortList;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Button_Accept;
		private System.Windows.Forms.Button Button_Cancel;
		private System.Windows.Forms.ImageList ImageList_Main;
	}
}

