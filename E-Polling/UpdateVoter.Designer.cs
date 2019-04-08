namespace E_Polling
{
    partial class UpdateVoter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateVoter));
            this.TVPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TVNid = new System.Windows.Forms.TextBox();
            this.BVUpdate = new System.Windows.Forms.Button();
            this.BVBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TVPassword
            // 
            this.TVPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVPassword.Location = new System.Drawing.Point(394, 350);
            this.TVPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TVPassword.Multiline = true;
            this.TVPassword.Name = "TVPassword";
            this.TVPassword.Size = new System.Drawing.Size(494, 35);
            this.TVPassword.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "NID";
            // 
            // TVNid
            // 
            this.TVNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVNid.Location = new System.Drawing.Point(394, 266);
            this.TVNid.Margin = new System.Windows.Forms.Padding(4);
            this.TVNid.Multiline = true;
            this.TVNid.Name = "TVNid";
            this.TVNid.Size = new System.Drawing.Size(494, 35);
            this.TVNid.TabIndex = 11;
            // 
            // BVUpdate
            // 
            this.BVUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVUpdate.Location = new System.Drawing.Point(766, 434);
            this.BVUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.BVUpdate.Name = "BVUpdate";
            this.BVUpdate.Size = new System.Drawing.Size(122, 41);
            this.BVUpdate.TabIndex = 10;
            this.BVUpdate.Text = "Update";
            this.BVUpdate.UseVisualStyleBackColor = false;
            this.BVUpdate.Click += new System.EventHandler(this.BVUpdate_Click);
            // 
            // BVBack
            // 
            this.BVBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVBack.Location = new System.Drawing.Point(32, 26);
            this.BVBack.Margin = new System.Windows.Forms.Padding(4);
            this.BVBack.Name = "BVBack";
            this.BVBack.Size = new System.Drawing.Size(106, 37);
            this.BVBack.TabIndex = 16;
            this.BVBack.Text = "Back";
            this.BVBack.UseVisualStyleBackColor = false;
            this.BVBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.BVBack);
            this.Controls.Add(this.TVPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TVNid);
            this.Controls.Add(this.BVUpdate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateVoter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateVoter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdateVoter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TVPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TVNid;
        private System.Windows.Forms.Button BVUpdate;
        private System.Windows.Forms.Button BVBack;
    }
}