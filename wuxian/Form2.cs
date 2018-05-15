using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;

namespace wuxian 
{

	
    public partial class Form2 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0xB;

		private Series[] charts = new Series[4];

		
		public Form2()
        {
            InitializeComponent();
			for (int i = 0; i < 4; i++)
			{
				charts[i] = new Series();
				charts[i].ChartType = SeriesChartType.Spline;
				charts[i].XValueType = ChartValueType.DateTime;
            }
			chart1.Series.Add(charts[0]);
			chart2.Series.Add(charts[1]);
			chart3.Series.Add(charts[2]);
		}
		public OleDbConnection c1 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=shujuku.accdb");
		public OleDbConnection c2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=guzhangku.accdb");

		OleDbCommand os = new OleDbCommand();
        OleDbDataReader od;
        DataTable dt = new DataTable();
        int i = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            i = 0;
            os.CommandText = "select * from sjb order by t";
           // dt.Columns.Add("原边电压", typeof(float));
            //dt.Columns.Add("原边电流", typeof(float));
            //dt.Columns.Add("ybt", typeof(float));
            dt.Columns.Add("副边电压", typeof(float));
            dt.Columns.Add("副边电流", typeof(float));
            dt.Columns.Add("电池电量", typeof(float));
            /* dt.Columns.Add("fbt", typeof(float));
             dt.Columns.Add("dcu", typeof(float));
             dt.Columns.Add("dci", typeof(float));
             dt.Columns.Add("dcl", typeof(float));
             dt.Columns.Add("dct", typeof(float));*/
            dt.Columns.Add("距离", typeof(float));
            dt.Columns.Add("高度", typeof(float));
            //dt.Columns.Add("s", typeof(bool));
            dt.Columns.Add("时间", typeof(DateTime));
			dt.Clear();
			for (int k = 0; k < 4; k++)
			{
				charts[k].Points.Clear();
			}
			xianshi();
            tubiao();
        }
        public void xianshi() {
            
            os.Connection = c1;
            os.Connection.Open();
            od = os.ExecuteReader();
            while (od.Read()) {
                dt.Rows.Add(i);
                //dt.Rows[i]["原边电压"] = od["ybu"];
                //dt.Rows[i]["原边电流"] = od["ybi"];
                //dt.Rows[i]["ybt"] = od["ybt"];
                dt.Rows[i]["副边电压"] = od["fbu"];
                dt.Rows[i]["副边电流"] = od["fbi"];
                dt.Rows[i]["电池电量"] = od["dcl"];
                /*dt.Rows[i]["fbt"] = od["fbt"];
                dt.Rows[i]["dcu"] = od["dcu"];
                dt.Rows[i]["dci"] = od["dci"];
                dt.Rows[i]["dcl"] = od["dcl"];
                dt.Rows[i]["dct"] = od["dct"];*/
                dt.Rows[i]["距离"] = od["l"];
                dt.Rows[i]["高度"] = od["h"];
                //dt.Rows[i]["s"] = od["s"];
				DateTime t = ((DateTime)od["t"]);
				//dt.Rows[i]["time"] =((DateTime)od["t"]).ToShortDateString() + " " + ((int)od["ms"] / 3600000).ToString() + ":" + (((int)od["ms"] % 3600000) / 60000).ToString() + ":" + ((((int)od["ms"] % 3600000) % 60000) / 1000).ToString() + ":" + ((((int)od["ms"] % 3600000) % 60000) % 1000).ToString();

				t = t.AddMilliseconds(double.Parse(od["ms"].ToString()));
				dt.Rows[i]["时间"] = t ;
				i++;
            }
            os.Connection.Close();
            dt.DefaultView.Sort = "时间 DESC";
            dt = dt.DefaultView.ToTable();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["时间"].Width=170;
            dataGridView1.Columns["副边电压"].Width = 130;
            dataGridView1.Columns["副边电流"].Width = 130;
            dataGridView1.Columns["电池电量"].Width = 130;
            dataGridView1.Columns["距离"].Width = 130;
            dataGridView1.Columns["高度"].Width = 130;

        }//表格显示
        public void tubiao()
        {
            for (int k = 1; k < i-1; k++)
			{			//charts[0].Points.AddXY(dt.Rows[k]["时间"], dt.Rows[k]["原边电压"]);
				//charts[1].Points.AddXY(dt.Rows[k]["时间"], dt.Rows[k]["原边电流"]);
				charts[0].Points.AddXY(dt.Rows[k]["时间"], dt.Rows[k]["副边电压"]);
				charts[1].Points.AddXY(dt.Rows[k]["时间"], dt.Rows[k]["副边电流"]);
                charts[2].Points.AddXY(dt.Rows[k]["时间"], dt.Rows[k]["电池电量"]);
            }
            //double aa = double.Parse(dt.Compute("Max(副边电流)", "true").ToString());

           // aa = aa + 1; ;
            chart1.ChartAreas[0].AxisY.Maximum = double.Parse(dt.Compute("Max(副边电压)", "true").ToString()) + 1;
            chart1.ChartAreas[0].AxisY.Minimum = double.Parse(dt.Compute("Min(副边电压)", "true").ToString()) - 1;
            chart2.ChartAreas[0].AxisY.Maximum = double.Parse(dt.Compute("Max(副边电流)", "true").ToString()) + 1;
            chart2.ChartAreas[0].AxisY.Minimum = double.Parse(dt.Compute("Min(副边电流)", "true").ToString()) - 1;
            chart3.ChartAreas[0].AxisY.Maximum = double.Parse(dt.Compute("Max(电池电量)", "true").ToString()) + 1;
            chart3.ChartAreas[0].AxisY.Minimum = double.Parse(dt.Compute("Min(电池电量)", "true").ToString()) - 1;
            
            //chart4.ChartAreas[0].AxisY.Maximum = 16;
            //chart4.ChartAreas[0].AxisY.Minimum = 14;
            if ((i - 1) >= 0)
            {
                chart1.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum = ((DateTime)dt.Rows[i - 1]["时间"]).ToOADate();
                chart1.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum = ((DateTime)dt.Rows[0]["时间"]).ToOADate();
                chart2.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum = ((DateTime)dt.Rows[i - 1]["时间"]).ToOADate();
                chart2.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum = ((DateTime)dt.Rows[0]["时间"]).ToOADate();
                chart3.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum = ((DateTime)dt.Rows[i - 1]["时间"]).ToOADate();
                chart3.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum = ((DateTime)dt.Rows[0]["时间"]).ToOADate();
            }
            //chart4.ChartAreas[0].AxisX.Minimum = chart1.ChartAreas[0].AxisX.Minimum = ((DateTime)dt.Rows[i - 1]["时间"]).ToOADate();
            //chart4.ChartAreas[0].AxisX.Maximum = chart1.ChartAreas[0].AxisX.Maximum = ((DateTime)dt.Rows[1]["时间"]).ToOADate();

        }//图表显示

        private void button1_Click(object sender, EventArgs e)
        {
            od = null;
            dt.Clear();
            i = 0;
			charts[0].Points.Clear();
			charts[1].Points.Clear();
			charts[2].Points.Clear();
			//charts[3].Points.Clear();
			DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            os.CommandText = "select * from sjb where (t between #"+d1.ToString("yyyy/MM/dd")+"# and #"+ d2.ToString("yyyy/MM/dd")+"#) AND (ms between "+(int)d1.TimeOfDay.TotalMilliseconds +" and "+(int)d2.TimeOfDay.TotalMilliseconds+")";
           // os.CommandText = "select * from sjb where ybu between 1 and 10";
            xianshi();
            tubiao();
        }

        private void cl(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mm(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
        }
    }
}
