namespace E_Polling
{
    partial class RemoveCandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveCandidate));
            this.BCRemove = new System.Windows.Forms.Button();
            this.TCNid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BCBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BCRemove
            // 
            this.BCRemove.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BCRemove.Location = new System.Drawing.Point(744, 340);
            this.BCRemove.Name = "BCRemove";
            this.BCRemove.Size = new System.Drawing.Size(156, 38);
            this.BCRemove.TabIndex = 1;
            this.BCRemove.Text = "Remove";
            this.BCRemove.UseVisualStyleBackColor = false;
            this.BCRemove.Click += new System.EventHandler(this.BCRemove_Click);
            // 
            // TCNid
            // 
            this.TCNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCNid.Location = new System.Drawing.Point(347, 261);
            this.TCNid.Multiline = true;
            this.TCNid.Name = "TCNid";
            this.TCNid.Size = new System.Drawing.Size(553, 38);
            this.TCNid.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "NID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BCBack
            // 
            this.BCBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BCBack.Location = new System.Drawing.Point(26, 27);
            this.BCBack.Name = "BCBack";
            this.BCBack.Size = new System.Drawing.Size(120, 39);
            this.BCBack.TabIndex = 11;
            this.BCBack.Text = "Back";
            this.BCBack.UseVisualStyleBackColor = false;
            this.BCBack.Click += new System.EventHandler(this.BCBack_Click);
            // 
            // RemoveCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.BCBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCNid);
            this.Controls.Add(this.BCRemove);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RemoveCandidate";
            this.Text = "RemoveCandidate";
            this.MaximumSizeChanged += new System.EventHandler(this.RemoveCandidate_MaximumSizeChanged);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveCandidate_FormClosing);
            this.Load += new System.EventHandler(this.RemoveCandidate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCRemove;
        private System.Windows.Forms.TextBox TCNid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BCBack;
    }
}