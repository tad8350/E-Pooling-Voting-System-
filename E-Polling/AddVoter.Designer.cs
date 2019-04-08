namespace E_Polling
{
    partial class AddVoter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVoter));
            this.label1 = new System.Windows.Forms.Label();
            this.TVNid = new System.Windows.Forms.TextBox();
            this.BVAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TVPassword = new System.Windows.Forms.TextBox();
            this.BVBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "NID";
            // 
            // TVNid
            // 
            this.TVNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVNid.Location = new System.Drawing.Point(408, 232);
            this.TVNid.Margin = new System.Windows.Forms.Padding(4);
            this.TVNid.Multiline = true;
            this.TVNid.Name = "TVNid";
            this.TVNid.Size = new System.Drawing.Size(460, 39);
            this.TVNid.TabIndex = 5;
            // 
            // BVAdd
            // 
            this.BVAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVAdd.Location = new System.Drawing.Point(719, 421);
            this.BVAdd.Margin = new System.Windows.Forms.Padding(4);
            this.BVAdd.Name = "BVAdd";
            this.BVAdd.Size = new System.Drawing.Size(149, 44);
            this.BVAdd.TabIndex = 4;
            this.BVAdd.Text = "Add";
            this.BVAdd.UseVisualStyleBackColor = false;
            this.BVAdd.Click += new System.EventHandler(this.BVAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 325);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // TVPassword
            // 
            this.TVPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVPassword.Location = new System.Drawing.Point(408, 325);
            this.TVPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TVPassword.Multiline = true;
            this.TVPassword.Name = "TVPassword";
            this.TVPassword.Size = new System.Drawing.Size(460, 37);
            this.TVPassword.TabIndex = 9;
            // 
            // BVBack
            // 
            this.BVBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVBack.Location = new System.Drawing.Point(27, 13);
            this.BVBack.Margin = new System.Windows.Forms.Padding(4);
            this.BVBack.Name = "BVBack";
            this.BVBack.Size = new System.Drawing.Size(124, 43);
            this.BVBack.TabIndex = 10;
            this.BVBack.Text = "Back";
            this.BVBack.UseVisualStyleBackColor = false;
            this.BVBack.Click += new System.EventHandler(this.BVBack_Click);
            // 
            // AddVoter
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
            this.Controls.Add(this.BVAdd);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddVoter";
            this.Text = "AddVoter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddVoter_FormClosing);
            this.Load += new System.EventHandler(this.AddVoter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TVNid;
        private System.Windows.Forms.Button BVAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TVPassword;
        private System.Windows.Forms.Button BVBack;
    }
}