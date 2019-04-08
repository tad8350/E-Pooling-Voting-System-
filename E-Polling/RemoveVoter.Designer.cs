namespace E_Polling
{
    partial class RemoveVoter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveVoter));
            this.label1 = new System.Windows.Forms.Label();
            this.TVNid = new System.Windows.Forms.TextBox();
            this.BVRemove = new System.Windows.Forms.Button();
            this.BVBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 288);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "NID";
            // 
            // TVNid
            // 
            this.TVNid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVNid.Location = new System.Drawing.Point(305, 280);
            this.TVNid.Margin = new System.Windows.Forms.Padding(4);
            this.TVNid.Multiline = true;
            this.TVNid.Name = "TVNid";
            this.TVNid.Size = new System.Drawing.Size(607, 37);
            this.TVNid.TabIndex = 5;
            // 
            // BVRemove
            // 
            this.BVRemove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVRemove.Location = new System.Drawing.Point(777, 361);
            this.BVRemove.Margin = new System.Windows.Forms.Padding(4);
            this.BVRemove.Name = "BVRemove";
            this.BVRemove.Size = new System.Drawing.Size(135, 48);
            this.BVRemove.TabIndex = 4;
            this.BVRemove.Text = "Remove";
            this.BVRemove.UseVisualStyleBackColor = false;
            this.BVRemove.Click += new System.EventHandler(this.BVRemove_Click);
            // 
            // BVBack
            // 
            this.BVBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVBack.Location = new System.Drawing.Point(24, 13);
            this.BVBack.Margin = new System.Windows.Forms.Padding(4);
            this.BVBack.Name = "BVBack";
            this.BVBack.Size = new System.Drawing.Size(125, 42);
            this.BVBack.TabIndex = 11;
            this.BVBack.Text = "Back";
            this.BVBack.UseVisualStyleBackColor = false;
            this.BVBack.Click += new System.EventHandler(this.BVBack_Click);
            // 
            // RemoveVoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.BVBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TVNid);
            this.Controls.Add(this.BVRemove);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveVoter";
            this.Text = "RemoveVoter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RemoveVoter_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TVNid;
        private System.Windows.Forms.Button BVRemove;
        private System.Windows.Forms.Button BVBack;
    }
}