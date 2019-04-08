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
    public partial class AdminPanel : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");
        
        

        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

       

        private void BAdd_Click(object sender, EventArgs e)
        {
                this.Hide();
                AddCandidate addc = new AddCandidate();
                addc.Show();
        }

        private void BRemove_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                RemoveCandidate removec = new RemoveCandidate();
                removec.Show();
        
        }

        private void BUpdate_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                UpdateCandidate updatec = new UpdateCandidate();
                updatec.Show();
            
        }

        private void BVAdd_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                AddVoter addv = new AddVoter();
                addv.Show();
           
        }

        private void BVRemove_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                RemoveVoter removec = new RemoveVoter();
                removec.Show();
            
        }

        private void BVUpdate_Click(object sender, EventArgs e)
        {
           
                this.Hide();
                UpdateVoter updatev = new UpdateVoter();
                updatev.Show();
            
        }

        private void BResult_Click(object sender, EventArgs e)
        {

            
                this.Hide();
                ShowResult s = new ShowResult();
                s.Show();
                

            }

        private void BLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_Polling.EPolling epoll = new E_Polling.EPolling();
            epoll.Show();
        }

        private void BCPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();

        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        

        private void BVClear_Click(object sender, EventArgs e)
        {
            Voter v = new Voter();
            var query = from temp in db.Voters
                        select temp;
            v = query.First();
            foreach (var results in query)
            {
                v.Voting_Status = 0;
                db.SubmitChanges();

            }
            MessageBox.Show("Clear Voting status Column");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            var query = from temp in db.Admins                       
                        select temp;
            a = query.First();
            foreach (var results in query)
            {
                a.Election_Date = dateTimePicker1.Value;
                db.SubmitChanges();
                MessageBox.Show("Changes done.");
            }
        }

        private void BClear_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();

            var query = from temp in db.Admins
                        select temp;
            a = query.First();
            foreach (var results in query)
            {
                
                a.Election_Date = Convert.ToDateTime("01/01/1900");
                db.SubmitChanges();
                MessageBox.Show("Changes done.");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        }
    }

