using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMenuStrip.GUI
{
    public partial class FormTimer : Form
    {
        int h;
        int m;
        int s;

        public FormTimer()
        {
            InitializeComponent();
        }

        private void FormTimer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox2.Text == "")
            {
                textBox2.Text = "0";
            }

            if (textBox3.Text == "")
            {
                textBox3.Text = "0";
            }

            h = Convert.ToInt32(textBox1.Text);
            m = Convert.ToInt32(textBox2.Text);
            s = Convert.ToInt32(textBox3.Text);

            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;

            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }

            if (m == -1)
            {
                h = m - 1;
                m = 59;
            }

            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                MessageBox.Show("Times Up!", "Time");
            }

            string hh = Convert.ToString(h);
            string mm = Convert.ToString(m);
            string ss = Convert.ToString(s);

            label1.Text = hh;
            label3.Text = mm;
            label5.Text = ss;


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
