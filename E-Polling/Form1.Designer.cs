namespace E_Polling
{
    partial class EPolling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EPolling));
            this.LNid = new System.Windows.Forms.Label();
            this.LPassword = new System.Windows.Forms.Label();
            this.TNid = new System.Windows.Forms.TextBox();
            this.TPassword = new System.Windows.Forms.TextBox();
            this.BLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LNid
            // 
            this.LNid.AutoSize = true;
            this.LNid.BackColor = System.Drawing.Color.Transparent;
            this.LNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LNid.Location = new System.Drawing.Point(466, 343);
            this.LNid.Name = "LNid";
            this.LNid.Size = new System.Drawing.Size(148, 29);
            this.LNid.TabIndex = 0;
            this.LNid.Text = "National ID";
            this.LNid.Click += new System.EventHandler(this.LNid_Click);
            // 
            // LPassword
            // 
            this.LPassword.AutoSize = true;
            this.LPassword.BackColor = System.Drawing.Color.Transparent;
            this.LPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LPassword.Location = new System.Drawing.Point(466, 416);
            this.LPassword.Name = "LPassword";
            this.LPassword.Size = new System.Drawing.Size(132, 29);
            this.LPassword.TabIndex = 1;
            this.LPassword.Text = "Password";
            // 
            // TNid
            // 
            this.TNid.BackColor = System.Drawing.Color.White;
            this.TNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNid.Location = new System.Drawing.Point(649, 341);
            this.TNid.Multiline = true;
            this.TNid.Name = "TNid";
            this.TNid.Size = new System.Drawing.Size(447, 39);
            this.TNid.TabIndex = 2;
            this.TNid.TextChanged += new System.EventHandler(this.TNid_TextChanged);
            // 
            // TPassword
            // 
            this.TPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TPassword.Location = new System.Drawing.Point(649, 414);
            this.TPassword.Multiline = true;
            this.TPassword.Name = "TPassword";
            this.TPassword.PasswordChar = '*';
            this.TPassword.Size = new System.Drawing.Size(447, 45);
            this.TPassword.TabIndex = 3;
            // 
            // BLogin
            // 
            this.BLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogin.Location = new System.Drawing.Point(952, 496);
            this.BLogin.Name = "BLogin";
            this.BLogin.Size = new System.Drawing.Size(144, 44);
            this.BLogin.TabIndex = 4;
            this.BLogin.Text = "Log In";
            this.BLogin.UseVisualStyleBackColor = false;
            this.BLogin.Click += new System.EventHandler(this.BLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 219);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 373);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(877, 57);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to E-Polling Voting System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EPolling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BLogin);
            this.Controls.Add(this.TPassword);
            this.Controls.Add(this.TNid);
            this.Controls.Add(this.LPassword);
            this.Controls.Add(this.LNid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "EPolling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronics Polling System";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EPolling_FormClosing);
            this.Load += new System.EventHandler(this.EPolling_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNid;
        private System.Windows.Forms.Label LPassword;
        private System.Windows.Forms.TextBox TNid;
        private System.Windows.Forms.TextBox TPassword;
        private System.Windows.Forms.Button BLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

