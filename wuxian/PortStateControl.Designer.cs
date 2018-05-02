namespace wuxian
{
	partial class PortStateControl
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

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.ComboBox_SerialPortList = new System.Windows.Forms.ComboBox();
			this.Label_Open = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ComboBox_SerialPortList
			// 
			this.ComboBox_SerialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox_SerialPortList.FormattingEnabled = true;
			this.ComboBox_SerialPortList.Location = new System.Drawing.Point(40, 10);
			this.ComboBox_SerialPortList.Name = "ComboBox_SerialPortList";
			this.ComboBox_SerialPortList.Size = new System.Drawing.Size(120, 33);
			this.ComboBox_SerialPortList.TabIndex = 1;
			// 
			// Label_Open
			// 
			this.Label_Open.BackColor = System.Drawing.Color.White;
			this.Label_Open.Location = new System.Drawing.Point(50, 65);
			this.Label_Open.Name = "Label_Open";
			this.Label_Open.Size = new System.Drawing.Size(100, 60);
			this.Label_Open.TabIndex = 2;
			this.Label_Open.Text = "打开";
			this.Label_Open.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(50, 140);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 60);
			this.label1.TabIndex = 2;
			this.label1.Text = "详细";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PortStateControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Label_Open);
			this.Controls.Add(this.ComboBox_SerialPortList);
			this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "PortStateControl";
			this.Size = new System.Drawing.Size(200, 220);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox ComboBox_SerialPortList;
		private System.Windows.Forms.Label Label_Open;
		private System.Windows.Forms.Label label1;
	}
}
