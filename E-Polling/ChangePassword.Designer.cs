namespace E_Polling
{
    partial class ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword));
            this.TNid = new System.Windows.Forms.TextBox();
            this.TCPassword = new System.Windows.Forms.TextBox();
            this.TNPassword = new System.Windows.Forms.TextBox();
            this.BCPassword = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelCurrentPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.BBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNid
            // 
            this.TNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNid.Location = new System.Drawing.Point(523, 224);
            this.TNid.Multiline = true;
            this.TNid.Name = "TNid";
            this.TNid.Size = new System.Drawing.Size(428, 37);
            this.TNid.TabIndex = 0;
            // 
            // TCPassword
            // 
            this.TCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCPassword.Location = new System.Drawing.Point(523, 294);
            this.TCPassword.Multiline = true;
            this.TCPassword.Name = "TCPassword";
            this.TCPassword.PasswordChar = '*';
            this.TCPassword.Size = new System.Drawing.Size(428, 32);
            this.TCPassword.TabIndex = 1;
            // 
            // TNPassword
            // 
            this.TNPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNPassword.Location = new System.Drawing.Point(523, 365);
            this.TNPassword.Multiline = true;
            this.TNPassword.Name = "TNPassword";
            this.TNPassword.PasswordChar = '*';
            this.TNPassword.Size = new System.Drawing.Size(428, 33);
            this.TNPassword.TabIndex = 2;
            // 
            // BCPassword
            // 
            this.BCPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BCPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BCPassword.Location = new System.Drawing.Point(833, 445);
            this.BCPassword.Name = "BCPassword";
            this.BCPassword.Size = new System.Drawing.Size(118, 47);
            this.BCPassword.TabIndex = 3;
            this.BCPassword.Text = "Change";
            this.BCPassword.UseVisualStyleBackColor = false;
            this.BCPassword.Click += new System.EventHandler(this.BCPassword_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Transparent;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(294, 231);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(55, 29);
            this.labelID.TabIndex = 4;
            this.labelID.Text = "NID";
            // 
            // labelCurrentPassword
            // 
            this.labelCurrentPassword.AutoSize = true;
            this.labelCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentPassword.Location = new System.Drawing.Point(294, 294);
            this.labelCurrentPassword.Name = "labelCurrentPassword";
            this.labelCurrentPassword.Size = new System.Drawing.Size(214, 29);
            this.labelCurrentPassword.TabIndex = 5;
            this.labelCurrentPassword.Text = "Current Password";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.Location = new System.Drawing.Point(294, 365);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(181, 29);
            this.labelNewPassword.TabIndex = 6;
            this.labelNewPassword.Text = "New Password";
            // 
            // BBack
            // 
            this.BBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BBack.Location = new System.Drawing.Point(45, 31);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(100, 38);
            this.BBack.TabIndex = 7;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = false;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelCurrentPassword);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.BCPassword);
            this.Controls.Add(this.TNPassword);
            this.Controls.Add(this.TCPassword);
            this.Controls.Add(this.TNid);
            this.Name = "ChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangePassword_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNid;
        private System.Windows.Forms.TextBox TCPassword;
        private System.Windows.Forms.TextBox TNPassword;
        private System.Windows.Forms.Button BCPassword;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelCurrentPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Button BBack;
    }
}