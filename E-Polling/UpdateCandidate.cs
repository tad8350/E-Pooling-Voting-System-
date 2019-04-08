using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Polling
{
    public partial class UpdateCandidate : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");
       
        string fileName;
        OpenFileDialog open;

        public UpdateCandidate()
        {
            InitializeComponent();
        }

        private void BCBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void BUpload_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.InitialDirectory = "Desktop";
            open.Filter = "Image Files(*.jpg)|*.jpg|All Files(*.*)|*.*";
            open.FilterIndex = 1;
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (open.CheckFileExists)
                {

                    fileName = open.FileName;

                    PBLogo.ImageLocation = open.FileName.ToString();

                }
            }
        }

        private void BCUpdate_Click(object sender, EventArgs e)
        {
            Candidate c = new Candidate();

            var query = from temp in db.Candidates
                        where temp.NID == TCNid.Text
                        select temp;

            c = query.First();
            if (c!=null)
            {
                c.NID = TCNid.Text;
                c.Name = TCName.Text;
                c.Party_Name = TPName.Text;
                c.Logo = fileName;
               // db.Candidates.InsertOnSubmit(c);
                db.SubmitChanges();

                MessageBox.Show("Candidate Details Updated!");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void UpdateCandidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void TCName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TPName_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
