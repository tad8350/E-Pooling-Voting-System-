namespace E_Polling
{
    partial class ChangeVoterPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeVoterPassword));
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.TNPassword = new System.Windows.Forms.TextBox();
            this.TCPassword = new System.Windows.Forms.TextBox();
            this.TNid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 41);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(207, 309);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(181, 29);
            this.labelNewPassword.TabIndex = 14;
            this.labelNewPassword.Text = "New Password";
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPassword.Location = new System.Drawing.Point(207, 248);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(214, 29);
            this.labelCurrentPassword.TabIndex = 13;
            this.labelCurrentPassword.Text = "Current Password";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(207, 185);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(55, 29);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "NID";
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePassword.Location = new System.Drawing.Point(763, 388);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(165, 45);
            this.buttonChangePassword.TabIndex = 11;
            this.buttonChangePassword.Text = "Change";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // TNPassword
            // 
            this.TNPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNPassword.Location = new System.Drawing.Point(427, 309);
            this.TNPassword.Multiline = true;
            this.TNPassword.Name = "TNPassword";
            this.TNPassword.PasswordChar = '*';
            this.TNPassword.Size = new System.Drawing.Size(501, 45);
            this.TNPassword.TabIndex = 10;
            // 
            // TCPassword
            // 
            this.TCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCPassword.Location = new System.Drawing.Point(427, 248);
            this.TCPassword.Multiline = true;
            this.TCPassword.Name = "TCPassword";
            this.TCPassword.PasswordChar = '*';
            this.TCPassword.Size = new System.Drawing.Size(501, 43);
            this.TCPassword.TabIndex = 9;
            // 
            // TNid
            // 
            this.TNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNid.Location = new System.Drawing.Point(427, 185);
            this.TNid.Multiline = true;
            this.TNid.Name = "TNid";
            this.TNid.Size = new System.Drawing.Size(501, 42);
            this.TNid.TabIndex = 8;
            // 
            // ChangeVoterPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.TNPassword);
            this.Controls.Add(this.TCPassword);
            this.Controls.Add(this.TNid);
            this.Name = "ChangeVoterPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeVoterPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeVoterPassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.TextBox TNPassword;
        private System.Windows.Forms.TextBox TCPassword;
        private System.Windows.Forms.TextBox TNid;

    }
}