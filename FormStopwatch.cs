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
    public partial class FormStopwatch : Form
    {
        int timeSec, timeMin;
        bool isActive;
        public FormStopwatch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void FormStopwatch_Load(object sender, EventArgs e)
        {
            ResetTime();

            isActive = false;
        }

        private void btnStrt_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnRst_Click(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }

        private void ResetTime()
        {
            timeSec = 0;
            timeMin = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                timeSec++;
                if (timeSec>=60)
                {
                    timeMin++;
                    timeSec = 0;
                }
            }
            DrawTime();

        }

        private void DrawTime()
        {
            lblSec.Text = String.Format("{0:00}", timeSec);
            lblMin.Text = String.Format("{0:00}", timeMin);
        }
    }
}
