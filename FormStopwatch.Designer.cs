namespace ProjectMenuStrip.GUI
{
    partial class FormStopwatch
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
            lblMin = new Label();
            lblSec = new Label();
            lblpem = new Label();
            btnStrt = new Button();
            btnStp = new Button();
            btnRst = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMin.Location = new Point(232, 173);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(99, 81);
            lblMin.TabIndex = 0;
            lblMin.Text = "00";
            lblMin.Click += label1_Click;
            // 
            // lblSec
            // 
            lblSec.AutoSize = true;
            lblSec.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSec.Location = new Point(353, 173);
            lblSec.Name = "lblSec";
            lblSec.Size = new Size(99, 81);
            lblSec.TabIndex = 1;
            lblSec.Text = "00";
            // 
            // lblpem
            // 
            lblpem.AutoSize = true;
            lblpem.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpem.Location = new Point(321, 173);
            lblpem.Name = "lblpem";
            lblpem.Size = new Size(48, 81);
            lblpem.TabIndex = 2;
            lblpem.Text = ":";
            // 
            // btnStrt
            // 
            btnStrt.Location = new Point(113, 284);
            btnStrt.Name = "btnStrt";
            btnStrt.Size = new Size(123, 49);
            btnStrt.TabIndex = 3;
            btnStrt.Text = "Mulai";
            btnStrt.UseVisualStyleBackColor = true;
            btnStrt.Click += btnStrt_Click;
            // 
            // btnStp
            // 
            btnStp.Location = new Point(279, 284);
            btnStp.Name = "btnStp";
            btnStp.Size = new Size(123, 49);
            btnStp.TabIndex = 4;
            btnStp.Text = "Berhenti";
            btnStp.UseVisualStyleBackColor = true;
            btnStp.Click += button2_Click;
            // 
            // btnRst
            // 
            btnRst.Location = new Point(445, 284);
            btnRst.Name = "btnRst";
            btnRst.Size = new Size(123, 49);
            btnRst.TabIndex = 5;
            btnRst.Text = "Reset";
            btnRst.UseVisualStyleBackColor = true;
            btnRst.Click += btnRst_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormStopwatch
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 450);
            Controls.Add(btnRst);
            Controls.Add(btnStp);
            Controls.Add(btnStrt);
            Controls.Add(lblpem);
            Controls.Add(lblSec);
            Controls.Add(lblMin);
            Name = "FormStopwatch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stopwatch";
            Load += FormStopwatch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMin;
        private Label lblSec;
        private Label lblpem;
        private Button btnStrt;
        private Button btnStp;
        private Button btnRst;
        private System.Windows.Forms.Timer timer1;
    }
}