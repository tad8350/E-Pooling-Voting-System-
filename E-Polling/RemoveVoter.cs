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
    public partial class RemoveVoter : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");


        public RemoveVoter()
        {
            InitializeComponent();
        }

        private void BVBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void BVRemove_Click(object sender, EventArgs e)
        {
             var query = from temp in db.Voters
                        where temp.NID == TVNid.Text
                        select temp;
            if (query.Any())
            {
                Voter v = query.First();
                db.Voters.DeleteOnSubmit(v);
                db.SubmitChanges();
                MessageBox.Show("Voter Removed");
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void RemoveVoter_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        }
    }

