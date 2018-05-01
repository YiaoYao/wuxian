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
        public Form2()
        {
            InitializeComponent();
        }
        OleDbCommand os = new OleDbCommand();
        OleDbDataReader od;
        DataTable dt = new DataTable();
        int i = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            i = 0;
            os.CommandText = "select * from sjb";
            dt.Columns.Add("ybu", typeof(float));
            dt.Columns.Add("ybi", typeof(float));
            //dt.Columns.Add("ybt", typeof(float));
            dt.Columns.Add("fbu", typeof(float));
            dt.Columns.Add("fbi", typeof(float));
           /* dt.Columns.Add("fbt", typeof(float));
            dt.Columns.Add("dcu", typeof(float));
            dt.Columns.Add("dci", typeof(float));
            dt.Columns.Add("dcl", typeof(float));
            dt.Columns.Add("dct", typeof(float));*/
            dt.Columns.Add("l", typeof(float));
            dt.Columns.Add("h", typeof(float));
            dt.Columns.Add("s", typeof(bool));
            dt.Columns.Add("time", typeof(DateTime));
            dt.Clear();
            chart1.Series["ybu"].Points.Clear();
            chart2.Series["ybi"].Points.Clear();
            chart3.Series["fbu"].Points.Clear();
            chart4.Series["fbi"].Points.Clear();
            xianshi();
            tubiao();
        }
        public void xianshi() {
            
            os.Connection = oleDbConnection1;
            os.Connection.Open();
            od = os.ExecuteReader();
            while (od.Read()) {
                dt.Rows.Add(i);
                dt.Rows[i]["ybu"] = od["ybu"];
                dt.Rows[i]["ybi"] = od["ybi"];
                //dt.Rows[i]["ybt"] = od["ybt"];
                dt.Rows[i]["fbu"] = od["fbu"];
                dt.Rows[i]["fbi"] = od["fbi"];
                /*dt.Rows[i]["fbt"] = od["fbt"];
                dt.Rows[i]["dcu"] = od["dcu"];
                dt.Rows[i]["dci"] = od["dci"];
                dt.Rows[i]["dcl"] = od["dcl"];
                dt.Rows[i]["dct"] = od["dct"];*/
                dt.Rows[i]["l"] = od["l"];
                dt.Rows[i]["h"] = od["h"];
                dt.Rows[i]["s"] = od["s"];
                dt.Rows[i]["time"] = od["t"];
                i++;
            }
            os.Connection.Close();
            dataGridView1.DataSource = dt;

        }//表格显示
        public void tubiao()
        {
            for (int k = 0; k < i; k++)
            {
                chart1.Series["ybu"].Points.AddXY(dt.Rows[k]["time"], dt.Rows[k]["ybu"]);
                chart2.Series["ybi"].Points.AddXY(dt.Rows[k]["time"], dt.Rows[k]["ybi"]);
                chart3.Series["fbu"].Points.AddXY(dt.Rows[k]["time"], dt.Rows[k]["fbu"]);
                chart4.Series["fbi"].Points.AddXY(dt.Rows[k]["time"], dt.Rows[k]["fbi"]);
            }

        }//图表显示

        private void button1_Click(object sender, EventArgs e)
        {
            od = null;
            dt.Clear();
            i = 0;
            chart1.Series["ybu"].Points.Clear();
            chart2.Series["ybi"].Points.Clear();
            chart3.Series["fbu"].Points.Clear();
            chart4.Series["fbi"].Points.Clear();
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            os.CommandText = "select * from sjb where t between #"+d1.ToString("yyyy/MM/dd hh:mm:ss")+"# and #"+ d2.ToString("yyyy/MM/dd hh:mm:ss")+"#";
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
