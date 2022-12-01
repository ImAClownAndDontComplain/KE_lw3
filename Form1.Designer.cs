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
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.LinkLabel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.text = new System.Windows.Forms.TextBox();
            this.restart = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt1.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(484, 314);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(227, 54);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Visible = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt2.Font = new System.Drawing.Font("STSong", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(484, 374);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(227, 57);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "button2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Visible = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb.Location = new System.Drawing.Point(41, 783);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(118, 38);
            this.lb.TabIndex = 5;
            this.lb.TabStop = true;
            this.lb.Text = "linkLabel1";
            this.lb.UseCompatibleTextRendering = true;
            this.lb.Visible = false;
            this.lb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_LinkClicked);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Location = new System.Drawing.Point(578, 196);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(651, 584);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 6;
            this.pic.TabStop = false;
            this.pic.Visible = false;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.text.Font = new System.Drawing.Font("STSong", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text.Location = new System.Drawing.Point(41, 314);
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.ReadOnly = true;
            this.text.Size = new System.Drawing.Size(421, 466);
            this.text.TabIndex = 7;
            this.text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.text.Visible = false;
            // 
            // restart
            // 
            this.restart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restart.AutoSize = true;
            this.restart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restart.Font = new System.Drawing.Font("STSong", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restart.Location = new System.Drawing.Point(519, 832);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(164, 61);
            this.restart.TabIndex = 8;
            this.restart.Text = "START";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // tb
            // 
            this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb.Font = new System.Drawing.Font("STSong", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb.Location = new System.Drawing.Point(397, 196);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(421, 105);
            this.tb.TabIndex = 9;
            this.tb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("STSong", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Find a K-Pop group for you";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::lw3.Resource1.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1289, 960);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bt1;
        private Button bt2;
        private LinkLabel lb;
        private PictureBox pic;
        private TextBox text;
        private Button restart;
        private Label tb;
        private Label label1;
    }
}