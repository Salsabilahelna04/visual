namespace ProjectMenuStrip.GUI
{
    partial class FormTimer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 174);
            label1.Name = "label1";
            label1.Size = new Size(25, 30);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 174);
            label2.Name = "label2";
            label2.Size = new Size(18, 30);
            label2.TabIndex = 4;
            label2.Text = ":";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(331, 174);
            label3.Name = "label3";
            label3.Size = new Size(25, 30);
            label3.TabIndex = 5;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(410, 172);
            label4.Name = "label4";
            label4.Size = new Size(19, 32);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // button1
            // 
            button1.Location = new Point(150, 315);
            button1.Name = "button1";
            button1.Size = new Size(148, 48);
            button1.TabIndex = 7;
            button1.Text = "Mulai";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(439, 315);
            button2.Name = "button2";
            button2.Size = new Size(148, 48);
            button2.TabIndex = 8;
            button2.Text = "Tunda";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(518, 174);
            label5.Name = "label5";
            label5.Size = new Size(27, 32);
            label5.TabIndex = 9;
            label5.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 246);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 31);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 246);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(68, 31);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(498, 246);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(68, 31);
            textBox3.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // FormTimer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormTimer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Timer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
    }
}