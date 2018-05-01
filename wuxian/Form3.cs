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

    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
        }
        OleDbCommand os = new OleDbCommand();
        OleDbDataReader od;
        DataTable dt = new DataTable();
        int i = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ybu", typeof(float));
            dt.Columns.Add("ybi", typeof(float));
            // dt.Columns.Add("ybt", typeof(float));
            dt.Columns.Add("fbu", typeof(float));
            dt.Columns.Add("fbi", typeof(float));
            /* dt.Columns.Add("fbt", typeof(float));
             dt.Columns.Add("dcu", typeof(float));
             dt.Columns.Add("dci", typeof(float));
             dt.Columns.Add("dcl", typeof(float));
             dt.Columns.Add("dct", typeof(float));*/
            dt.Columns.Add("l", typeof(float));
            dt.Columns.Add("h", typeof(float));
            dt.Columns.Add("leixing", typeof(string));
            dt.Columns.Add("s", typeof(bool));
            dt.Columns.Add("time", typeof(DateTime));
            dt.Clear();
            os.Connection = oleDbConnection1;
            os.CommandText = "select * from gzb";
            xianshi();
        }
        public void xianshi()
        {
            
            os.Connection.Open();
            od = os.ExecuteReader();
            i = 0;
            while (od.Read())
            {
                string[] leixing = new string[4];
                dt.Rows.Add(i);
                dt.Rows[i]["ybu"] = od["ybu"];
                dt.Rows[i]["ybi"] = od["ybi"];
                //dt.Rows[i]["ybt"] = od["ybt"];
                dt.Rows[i]["fbu"] = od["fbu"];
                dt.Rows[i]["fbi"] = od["fbi"];
               /* dt.Rows[i]["fbt"] = od["fbt"];
                dt.Rows[i]["dcu"] = od["dcu"];
                dt.Rows[i]["dci"] = od["dci"];
                dt.Rows[i]["dcl"] = od["dcl"];
                dt.Rows[i]["dct"] = od["dct"];*/
                dt.Rows[i]["l"] = od["l"];
                dt.Rows[i]["h"] = od["h"];
                if ((int)od["ybuu"] == 1) leixing[0] = "原边电压过高-";
                else if ((int)od["ybuu"] == 2) leixing[0] = "原边电压过低-";
                else leixing[0] = null ;
                if ((int)od["ybii"] == 1) leixing[1] = "原边电流过高-";
                else if ((int)od["ybii"] == 2) leixing[1] = "原边电流过低-";
                else leixing[1] = null ;
               /*if ((int)od["ybtt"] == 1) leixing[2] = "原边温度过高-";
                else if ((int)od["ybtt"] == 1) leixing[2] = "原边温度过低-";
                else leixing[2] = null ;*/
                if ((int)od["fbuu"] == 1) leixing[3] = "副边电压过高-";
                else if ((int)od["fbuu"] == 2) leixing[3] = "副边电压过低-";
                else leixing[2] = null ;
                if ((int)od["fbii"] == 1) leixing[4] = "副边电流过高-";
                else if ((int)od["fbii"] == 1) leixing[4] = "副边电压流过低-";
                else leixing[3] = null;
                /*if ((int)od["fbtt"] == 1) leixing[5] = "副边温度过高-";
                else if ((int)od["fbtt"] == 2) leixing[5] = "副边温度过低-";
                else leixing[5] = null;
                if ((int)od["dcuu"] == 1) leixing[6] = "电池电压过高-";
                else if ((int)od["dcuu"] == 1) leixing[6] = "电池电压过低-";
                else leixing[6] = null;
                if ((int)od["dcii"] == 1) leixing[7] = "电池电流过高-";
                else if ((int)od["dcii"] == 2) leixing[7] = "电池电流过低-";
                else leixing[7] = null;
                if ((int)od["dcll"] == 1) leixing[8] = "电池电量过高-";
                else if ((int)od["dcll"] == 2) leixing[8] = "电池电量过低-";
                else leixing[8] = null;
                if ((int)od["dctt"] == 1) leixing[9] = "电池温度过高-";
                else if ((int)od["dctt"] == 2) leixing[9] = "电池温度过低-";
                else leixing[9] = null;*/
                for (int k = 0; k < 4; k++)
                {
                    dt.Rows[i]["leixing"] = dt.Rows[i]["leixing"] + leixing[k];
                }
                dt.Rows[i]["s"] = od["s"];
                dt.Rows[i]["time"] = od["t"];
                i++;

            }
            os.Connection.Close();
            dataGridView1.DataSource = dt;

        }

        private void md(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
        }

        private void cl(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            od = null;
            dt.Clear();
            i = 0;
            DateTime d1 = new DateTime();
            DateTime d2 = new DateTime();
            d1 = dateTimePicker1.Value;
            d2 = dateTimePicker2.Value;
            os.CommandText = "select * from gzb where t between #" + d1.ToString("yyyy/MM/dd hh:mm:ss") + "# and #" + d2.ToString("yyyy/MM/dd hh:mm:ss") + "#";
            // os.CommandText = "select * from sjb where ybu between 1 and 10";
            xianshi();
        }
    }
}
