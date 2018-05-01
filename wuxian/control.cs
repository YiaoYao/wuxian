using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wuxian
{
    public partial class control : Form
    {
        
        public control()
        {
            InitializeComponent();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void control_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int s, h;
            s = 0;h = 0;
            pictureBox2.Location = new Point(550 - s, h);
            pictureBox3.Location = new Point(500 - s, 25+h);
            pictureBox3.Width = s;
            pictureBox4.Height =  h;
        }
    }
}
