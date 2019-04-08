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
    public partial class UpdateVoter : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");
        

        public UpdateVoter()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void BVUpdate_Click(object sender, EventArgs e)
        {
            Voter v = new Voter();

            var query = from temp in db.Voters
                        where temp.NID == TVNid.Text
                        select temp;

            v = query.First();
            if (v != null)
            {
                v.NID = TVNid.Text;
                v.Password = TVPassword.Text;
                db.SubmitChanges();

                MessageBox.Show("Voter Details Updated!");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void UpdateVoter_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
