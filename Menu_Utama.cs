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
    public partial class Menu_Utama : Form
    {
        FormStopwatch stp;
        FormTimer tmr;
        void stp_FormClosed(Object sender, FormClosedEventArgs e)
        {
            stp = null;
        }
        void tmr_FormClosed(Object sender, FormClosedEventArgs e)
        {
            tmr = null;
        }
        public Menu_Utama()
        {
            InitializeComponent();
        }

        private void submenu_stopwatch_Click(object sender, EventArgs e)
        {
            if (stp == null)
            {
                stp = new FormStopwatch();
                stp.MdiParent = this;
                stp.FormClosed += new FormClosedEventHandler(stp_FormClosed);
                stp.Show();
            }
            else
            {
                stp.Activate();
            }
        }

        private void submenu_timer_Click(object sender, EventArgs e)
        {
            if (tmr == null)
            {
                tmr = new FormTimer();
                tmr.MdiParent = this;
                tmr.FormClosed += new FormClosedEventHandler(tmr_FormClosed);
                tmr.Show();
            }
            else
            {
                tmr.Activate();
            }
        }
    }
}
