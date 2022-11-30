namespace lw3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TextBox();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.LinkLabel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.TextBox();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb.Location = new System.Drawing.Point(29, 28);
            this.tb.Margin = new System.Windows.Forms.Padding(2);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.ReadOnly = true;
            this.tb.Size = new System.Drawing.Size(291, 62);
            this.tb.TabIndex = 0;
            this.tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt1
            // 
            this.bt1.AutoSize = true;
            this.bt1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(60, 125);
            this.bt1.Margin = new System.Windows.Forms.Padding(2);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(105, 31);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.AutoSize = true;
            this.bt2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(60, 156);
            this.bt2.Margin = new System.Windows.Forms.Padding(2);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(105, 31);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "button2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(29, 426);
            this.lb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(79, 27);
            this.lb.TabIndex = 5;
            this.lb.TabStop = true;
            this.lb.Text = "linkLabel1";
            this.lb.UseCompatibleTextRendering = true;
            this.lb.Visible = false;
            this.lb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_LinkClicked);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(400, 28);
            this.pic.Margin = new System.Windows.Forms.Padding(2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(456, 383);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(29, 103);
            this.text.Margin = new System.Windows.Forms.Padding(2);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(291, 303);
            this.text.TabIndex = 7;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text.Visible = false;
            // 
            // restart
            // 
            this.restart.AutoSize = true;
            this.restart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restart.Location = new System.Drawing.Point(120, 459);
            this.restart.Margin = new System.Windows.Forms.Padding(2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(94, 35);
            this.restart.TabIndex = 8;
            this.restart.Text = "RESTART";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 518);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.tb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb;
        private Button bt1;
        private Button bt2;
        private LinkLabel lb;
        private PictureBox pic;
        private TextBox text;
        private Button restart;
    }
}