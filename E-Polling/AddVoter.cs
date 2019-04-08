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
    public partial class AddVoter : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");


        public AddVoter()
        {
            InitializeComponent();
        }

        private void BVBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void BVAdd_Click(object sender, EventArgs e)
        {
            var query = from temp in db.NID_Infos
                        where temp.NID == TVNid.Text
                        select temp;
            if (query.Any())
            {
                Voter v = new Voter();
                v.NID = TVNid.Text;
                v.Password = TVPassword.Text;
                
                db.Voters.InsertOnSubmit(v);
                db.SubmitChanges();
                MessageBox.Show("New Voter Added!");
            }
            else
            {
                MessageBox.Show("Selected Voter is not exist in NID Database ");
            }
        }

        private void AddVoter_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void AddVoter_Load(object sender, EventArgs e)
        {

        }
    }
}
