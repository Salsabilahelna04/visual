namespace ProjectMenuStrip.GUI
{
    partial class Menu_Utama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            menu_pilih = new ToolStripMenuItem();
            submenu_stopwatch = new ToolStripMenuItem();
            submenu_timer = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(24, 24);
            menuStrip.Items.AddRange(new ToolStripItem[] { menu_pilih });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(10, 4, 0, 4);
            menuStrip.Size = new Size(1053, 37);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "MenuStrip";
            // 
            // menu_pilih
            // 
            menu_pilih.DropDownItems.AddRange(new ToolStripItem[] { submenu_stopwatch, submenu_timer });
            menu_pilih.Name = "menu_pilih";
            menu_pilih.Size = new Size(110, 29);
            menu_pilih.Text = "&Pilih Menu";
            // 
            // submenu_stopwatch
            // 
            submenu_stopwatch.Name = "submenu_stopwatch";
            submenu_stopwatch.Size = new Size(270, 34);
            submenu_stopwatch.Text = "&Stopwatch";
            submenu_stopwatch.Click += submenu_stopwatch_Click;
            // 
            // submenu_timer
            // 
            submenu_timer.Name = "submenu_timer";
            submenu_timer.Size = new Size(270, 34);
            submenu_timer.Text = "&Timer";
            submenu_timer.Click += submenu_timer_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 839);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(2, 0, 23, 0);
            statusStrip.Size = new Size(1053, 32);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(60, 25);
            toolStripStatusLabel.Text = "Status";
            // 
            // Menu_Utama
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 871);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Menu_Utama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        public ToolStripMenuItem menu_pilih;
        public ToolStripMenuItem submenu_stopwatch;
        public ToolStripMenuItem submenu_timer;
    }
}



