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
    public partial class RemoveCandidate : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");


        public RemoveCandidate()
        {
            InitializeComponent();
        }

        private void RemoveCandidate_MaximumSizeChanged(object sender, EventArgs e)
        {

        }

        private void BCBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void BCRemove_Click(object sender, EventArgs e)
        {
            var query = from temp in db.Candidates
                        where temp.NID == TCNid.Text
                        select temp;
            if (query.Any())
            {
                Candidate c = query.First();
                db.Candidates.DeleteOnSubmit(c);
                db.SubmitChanges();
                MessageBox.Show("Candidate Removed");
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void RemoveCandidate_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RemoveCandidate_Load(object sender, EventArgs e)
        {

        }
    }
}
