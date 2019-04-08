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
    public partial class AddCandidate : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");

        string fileName;
        OpenFileDialog open;

        public AddCandidate()
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
            open.InitialDirectory = "C:\\";
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

        private void BCAdd_Click(object sender, EventArgs e)
        {
            var query = from temp in db.Voters
                        where temp.NID == TCNid.Text
                        select temp;
            if (query.Any())
            {
                Candidate c = new Candidate();
                c.NID = TCNid.Text;
                c.Name = TCName.Text;
                c.Party_Name = TPName.Text;
                c.Logo = fileName;

                db.Candidates.InsertOnSubmit(c);
                db.SubmitChanges();
                MessageBox.Show("New Candidate Added!");
            }
            else
            {
                MessageBox.Show("Selected Candidate is not exist in voter list");
            }
        }

        private void AddCandidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
