using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Drawing.Drawing2D;

namespace wuxian
{

    public partial class Form1 : Form
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
        
        public Form1()
        {
            InitializeComponent();
        }

        float[] shuju = { gb.s1, gb.s2, gb.s3, gb.s4 };
        float[] shangxian = { 1, 1, 1, 1 };
        float[] xiaxian = { 0, 0, 0, 0 };
        float[] bianhong = new float[4];
        float x, y;
        float x2, y2;
        bool s;
        DateTime dt;
    

        private void Form1_Load(object sender, EventArgs e)
        {
            // timer1.Enabled = true;
            // timer2.Enabled = true;
            Pen pen2 = new Pen(Color.Blue, 1);
            pen2.DashStyle = DashStyle.Dot;
            pictureBox6.CreateGraphics().DrawLine(pen2, 0, 1, 220, 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 chuankou = new Form2();
           // chuankou.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 shuju = new Form2();
            shuju.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 guzhang = new Form3();
            guzhang.ShowDialog();
        }

        private void t1(object sender, EventArgs e)
        {
            Chucun(shuju,dt,s,x,y);
        }

        private void t2(object sender, EventArgs e)
        {
            RC(shuju,dt);
        }

        public void RC(float[] shuju1, DateTime t)
        {
            /*for (int i = 0; i < 10; i++)
            {
                bianhong[i] = 0;
            }*/
            label3.Text = "电压：" + shuju[0].ToString();
            label4.Text = "电流：" + shuju[1].ToString();
            label5.Text = "电压：" + shuju[2].ToString();
            label6.Text = "电流：" + shuju[3].ToString();
            
            /*for (int i = 0; i < 4; i++)
            {
                if (shuju[i] > shangxian[i])
                {
                    bianhong[i] = 1;
                }
                else if (shuju[i] < xiaxian[i])
                { bianhong[i] = 2; }
            }*/
            if (shuju[0] > shangxian[0]|| shuju[0] < xiaxian[0])
            {
                label3.ForeColor = Color.Red;
            }
            else label3.ForeColor = Color.Black;
            if (shuju[1] > shangxian[1]|| shuju[1] < xiaxian[1])
            {
                label4.ForeColor = Color.Red;
            }
            else label4.ForeColor = Color.Black;
            if (shuju[2] > shangxian[2]|| shuju[2] < xiaxian[2])
            {
                label5.ForeColor = Color.Red;
            }
            else label5.ForeColor = Color.Black;
            if (shuju[3] > shangxian[3]|| shuju[3] < xiaxian[3])
            {
                label6.ForeColor = Color.Red;
            }
            else label6.ForeColor = Color.Black;
           
            /*float p = 0;
            for (int i = 0; i < 10; i++)
            {
                p = p + bianhong[i];
            }
            if (p > 0)
             guzhang(shuju, bianhong,t,s,x,y);*/

        }//显示数据

        public void Chucun(float[] shuju1, DateTime t, bool s1, float x1, float y1)
        {
            string s2; if (s1) s2 = "true"; else s2 = "false";

            OleDbCommand oc = new OleDbCommand();
            oc.CommandText = "insert into sjb(ybu,ybi,fbu,fbi,l,h,s,t) values (";
            for (int i = 0; i < 4; i++)
            {
                oc.CommandText = oc.CommandText + shuju[i] + ",";
            }
            oc.CommandText = oc.CommandText + x1 + "," + y1 + "," + s2 + ", '" + t.ToString() + "' )";
            oc.Connection = oleDbConnection1;
            oc.Connection.Open();
            oc.ExecuteNonQuery();
            oc.Connection.Close();
            for (int i = 0; i < 4; i++)
            {
                bianhong[i] = 0;
            }
            for (int i = 0; i < 4; i++)
            {
                if (shuju[i] > shangxian[i])
                {
                    bianhong[i] = 1;
                }
                else if (shuju[i] < xiaxian[i])
                { bianhong[i] = 2; }
            }
            float p = 0;
            for (int i = 0; i < 4; i++)
            {
                p = p + bianhong[i];
            }
            //if (p > 0)
            // guzhang(shuju1, bianhong,t,s1,x1,y1);
        }

        public void guzhang(float[] shuju2, float[] bianhong2, DateTime t2, bool s1, float x1, float y1)
        {
            string s2; if (s1) s2 = "true"; else s2 = "false";

            OleDbCommand oc1 = new OleDbCommand();
            oc1.CommandText = "insert into sjb(ybu,ybi,fbu,fbi,ybuu,ybii,fbuu,fbii,l,h,s,t) values (";
            for (int i = 0; i < 4; i++)
            {
                oc1.CommandText = oc1.CommandText + shuju[i] + ",";
            }
            for (int i = 0; i < 4; i++)
            {
                oc1.CommandText = oc1.CommandText + bianhong2[i] + ",";
            }
            oc1.CommandText = oc1.CommandText + x1 + "," + y1 + "," + s2 + ",'" + t2 + "')";
            oc1.Connection = oleDbConnection2;
            oc1.Connection.Open();
            oc1.ExecuteNonQuery();
            oc1.Connection.Close();


        }//故障

        private void t3(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point((int)x + 500, 440 - (int)y);
            pictureBox6.Location = new Point((int)x + 550, 465 - (int)y);
            pictureBox7.Height = 220 - (int)y;
            pictureBox6.Width = 270 - (int)x;
        }

        private void md(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
            }
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
