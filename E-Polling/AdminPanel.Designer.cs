namespace E_Polling
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.BAdd = new System.Windows.Forms.Button();
            this.BRemove = new System.Windows.Forms.Button();
            this.BUpdate = new System.Windows.Forms.Button();
            this.BResult = new System.Windows.Forms.Button();
            this.BVAdd = new System.Windows.Forms.Button();
            this.BVRemove = new System.Windows.Forms.Button();
            this.BVUpdate = new System.Windows.Forms.Button();
            this.BLogout = new System.Windows.Forms.Button();
            this.BCPassword = new System.Windows.Forms.Button();
            this.BVClear = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAdd
            // 
            this.BAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAdd.Location = new System.Drawing.Point(91, 185);
            this.BAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(190, 75);
            this.BAdd.TabIndex = 4;
            this.BAdd.Text = "Add Candidate";
            this.BAdd.UseVisualStyleBackColor = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BRemove
            // 
            this.BRemove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRemove.Location = new System.Drawing.Point(91, 340);
            this.BRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BRemove.Name = "BRemove";
            this.BRemove.Size = new System.Drawing.Size(190, 75);
            this.BRemove.TabIndex = 5;
            this.BRemove.Text = "Remove Candidate";
            this.BRemove.UseVisualStyleBackColor = false;
            this.BRemove.Click += new System.EventHandler(this.BRemove_Click);
            // 
            // BUpdate
            // 
            this.BUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUpdate.Location = new System.Drawing.Point(91, 501);
            this.BUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BUpdate.Name = "BUpdate";
            this.BUpdate.Size = new System.Drawing.Size(190, 75);
            this.BUpdate.TabIndex = 6;
            this.BUpdate.Text = "Update Candidate";
            this.BUpdate.UseVisualStyleBackColor = false;
            this.BUpdate.Click += new System.EventHandler(this.BUpdate_Click);
            // 
            // BResult
            // 
            this.BResult.BackColor = System.Drawing.Color.DarkSalmon;
            this.BResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BResult.ForeColor = System.Drawing.Color.Navy;
            this.BResult.Location = new System.Drawing.Point(494, 363);
            this.BResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BResult.Name = "BResult";
            this.BResult.Size = new System.Drawing.Size(128, 52);
            this.BResult.TabIndex = 10;
            this.BResult.Text = "Show";
            this.BResult.UseVisualStyleBackColor = false;
            this.BResult.Click += new System.EventHandler(this.BResult_Click);
            // 
            // BVAdd
            // 
            this.BVAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVAdd.Location = new System.Drawing.Point(838, 185);
            this.BVAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVAdd.Name = "BVAdd";
            this.BVAdd.Size = new System.Drawing.Size(190, 75);
            this.BVAdd.TabIndex = 11;
            this.BVAdd.Text = "Add Voter";
            this.BVAdd.UseVisualStyleBackColor = false;
            this.BVAdd.Click += new System.EventHandler(this.BVAdd_Click);
            // 
            // BVRemove
            // 
            this.BVRemove.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVRemove.Location = new System.Drawing.Point(838, 292);
            this.BVRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVRemove.Name = "BVRemove";
            this.BVRemove.Size = new System.Drawing.Size(190, 75);
            this.BVRemove.TabIndex = 12;
            this.BVRemove.Text = "Remove Voter";
            this.BVRemove.UseVisualStyleBackColor = false;
            this.BVRemove.Click += new System.EventHandler(this.BVRemove_Click);
            // 
            // BVUpdate
            // 
            this.BVUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVUpdate.Location = new System.Drawing.Point(838, 394);
            this.BVUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BVUpdate.Name = "BVUpdate";
            this.BVUpdate.Size = new System.Drawing.Size(190, 75);
            this.BVUpdate.TabIndex = 13;
            this.BVUpdate.Text = "Update Voter";
            this.BVUpdate.UseVisualStyleBackColor = false;
            this.BVUpdate.Click += new System.EventHandler(this.BVUpdate_Click);
            // 
            // BLogout
            // 
            this.BLogout.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BLogout.Location = new System.Drawing.Point(917, 26);
            this.BLogout.Name = "BLogout";
            this.BLogout.Size = new System.Drawing.Size(149, 40);
            this.BLogout.TabIndex = 14;
            this.BLogout.Text = "Logout";
            this.BLogout.UseVisualStyleBackColor = false;
            this.BLogout.Click += new System.EventHandler(this.BLogout_Click);
            // 
            // BCPassword
            // 
            this.BCPassword.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BCPassword.Location = new System.Drawing.Point(917, 86);
            this.BCPassword.Name = "BCPassword";
            this.BCPassword.Size = new System.Drawing.Size(149, 43);
            this.BCPassword.TabIndex = 15;
            this.BCPassword.Text = "Change Password";
            this.BCPassword.UseVisualStyleBackColor = false;
            this.BCPassword.Click += new System.EventHandler(this.BCPassword_Click);
            // 
            // BVClear
            // 
            this.BVClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BVClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVClear.Location = new System.Drawing.Point(838, 501);
            this.BVClear.Name = "BVClear";
            this.BVClear.Size = new System.Drawing.Size(190, 75);
            this.BVClear.TabIndex = 16;
            this.BVClear.Text = "Clear All Voter\'s Voting Status";
            this.BVClear.UseVisualStyleBackColor = false;
            this.BVClear.Click += new System.EventHandler(this.BVClear_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(552, 599);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 22);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(327, 599);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select Election Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.SystemColors.Info;
            this.BSave.Location = new System.Drawing.Point(641, 640);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(75, 27);
            this.BSave.TabIndex = 19;
            this.BSave.Text = "Save Date";
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // BClear
            // 
            this.BClear.BackColor = System.Drawing.SystemColors.Info;
            this.BClear.Location = new System.Drawing.Point(552, 640);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(83, 27);
            this.BClear.TabIndex = 20;
            this.BClear.Text = "Clear";
            this.BClear.UseVisualStyleBackColor = false;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(352, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 51);
            this.label2.TabIndex = 21;
            this.label2.Text = "Show Voting Result";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 723);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.BVClear);
            this.Controls.Add(this.BCPassword);
            this.Controls.Add(this.BLogout);
            this.Controls.Add(this.BVUpdate);
            this.Controls.Add(this.BVRemove);
            this.Controls.Add(this.BVAdd);
            this.Controls.Add(this.BResult);
            this.Controls.Add(this.BUpdate);
            this.Controls.Add(this.BRemove);
            this.Controls.Add(this.BAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminPanel_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BRemove;
        private System.Windows.Forms.Button BUpdate;
        private System.Windows.Forms.Button BResult;
        private System.Windows.Forms.Button BVAdd;
        private System.Windows.Forms.Button BVRemove;
        private System.Windows.Forms.Button BVUpdate;
        private System.Windows.Forms.Button BLogout;
        private System.Windows.Forms.Button BCPassword;
        private System.Windows.Forms.Button BVClear;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Label label2;
    }
}