namespace E_Polling
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.BVCPassword = new System.Windows.Forms.Button();
            this.CBName = new System.Windows.Forms.ComboBox();
            this.LCName = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
            this.LPName = new System.Windows.Forms.Label();
            this.BVote = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BVCPassword
            // 
            this.BVCPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVCPassword.Location = new System.Drawing.Point(924, 89);
            this.BVCPassword.Name = "BVCPassword";
            this.BVCPassword.Size = new System.Drawing.Size(164, 61);
            this.BVCPassword.TabIndex = 1;
            this.BVCPassword.Text = "Change Password";
            this.BVCPassword.UseVisualStyleBackColor = false;
            this.BVCPassword.Click += new System.EventHandler(this.BVCPassword_Click);
            // 
            // CBName
            // 
            this.CBName.FormattingEnabled = true;
            this.CBName.Location = new System.Drawing.Point(341, 121);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(443, 24);
            this.CBName.TabIndex = 2;
            this.CBName.SelectedIndexChanged += new System.EventHandler(this.CBName_SelectedIndexChanged);
            // 
            // LCName
            // 
            this.LCName.AutoSize = true;
            this.LCName.BackColor = System.Drawing.Color.Transparent;
            this.LCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCName.Location = new System.Drawing.Point(81, 121);
            this.LCName.Name = "LCName";
            this.LCName.Size = new System.Drawing.Size(221, 29);
            this.LCName.TabIndex = 3;
            this.LCName.Text = "Candidate\'s Name";
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PBLogo.Location = new System.Drawing.Point(341, 331);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(422, 309);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 4;
            this.PBLogo.TabStop = false;
            // 
            // LPName
            // 
            this.LPName.AutoSize = true;
            this.LPName.BackColor = System.Drawing.Color.Transparent;
            this.LPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPName.Location = new System.Drawing.Point(81, 226);
            this.LPName.Name = "LPName";
            this.LPName.Size = new System.Drawing.Size(243, 29);
            this.LPName.TabIndex = 5;
            this.LPName.Text = "Political Party Name";
            // 
            // BVote
            // 
            this.BVote.BackColor = System.Drawing.Color.Crimson;
            this.BVote.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVote.ForeColor = System.Drawing.Color.White;
            this.BVote.Location = new System.Drawing.Point(799, 534);
            this.BVote.Name = "BVote";
            this.BVote.Size = new System.Drawing.Size(191, 106);
            this.BVote.TabIndex = 7;
            this.BVote.Text = "Vote";
            this.BVote.UseVisualStyleBackColor = false;
            this.BVote.Click += new System.EventHandler(this.BVote_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Political Party Sign";
            // 
            // BLogout
            // 
            this.BLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLogout.Location = new System.Drawing.Point(924, 22);
            this.BLogout.Name = "BLogout";
            this.BLogout.Size = new System.Drawing.Size(164, 56);
            this.BLogout.TabIndex = 9;
            this.BLogout.Text = "Logout";
            this.BLogout.UseVisualStyleBackColor = false;
            this.BLogout.Click += new System.EventHandler(this.BLogout_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.BLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BVote);
            this.Controls.Add(this.LPName);
            this.Controls.Add(this.PBLogo);
            this.Controls.Add(this.LCName);
            this.Controls.Add(this.CBName);
            this.Controls.Add(this.BVCPassword);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voter Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BVCPassword;
        private System.Windows.Forms.ComboBox CBName;
        private System.Windows.Forms.Label LCName;
        private System.Windows.Forms.PictureBox PBLogo;
        private System.Windows.Forms.Label LPName;
        private System.Windows.Forms.Button BVote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BLogout;
    }
}