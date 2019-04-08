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
    public partial class Form2 : Form
    {


        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");
        OpenFileDialog open;
        int totalvote = 0;

        public Form2()
        {
            InitializeComponent();
            CBName.DataSource = db.Candidates;
            CBName.DisplayMember = "Name";
            CBName.ValueMember = "NID";
        }

        private void CBName_SelectedIndexChanged(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            String id=CBName.SelectedValue.ToString();
            
            Candidate candidate = new Candidate();
            var query = from temp in db.Candidates
                        where temp.NID == id
                        select temp;
            candidate = query.First();
            

            string temp1 = string.Format("{0}", candidate.Logo);
            PBLogo.ImageLocation = temp1;
            this.LPName.Text = candidate.Party_Name;
        }

        private void BVote_Click(object sender, EventArgs e)
        {
            DateTime date = Convert.ToDateTime("01/01/1900");
            Admin a = new Admin();
            var query3 = from temp in db.Admins                        
                         select temp;
             a= query3.First();
            foreach (var results in query3)
            {
                date = a.Election_Date;
                    
                }

            if (DateTime.Now.Date == date)
            {
                if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour <= 16)
                {
                    string voterID = E_Polling.EPolling.loginID;

                    Voter v = new Voter();

                    var query = from temp in db.Voters
                                where temp.NID == voterID
                                select temp;
                    v = query.First();

                    int votingStatus = v.Voting_Status;

                    if (votingStatus == 0)
                    {

                        String id = CBName.SelectedValue.ToString();

                        Candidate candidate = new Candidate();
                        var query1 = from temp in db.Candidates
                                     where temp.NID == id
                                     select temp;
                        candidate = query1.First();

                        totalvote += 1;

                        candidate.Total_Vote = Convert.ToString(totalvote);

                        v.Voting_Status = 1;
                        db.SubmitChanges();
                    }
                    else
                    {
                        MessageBox.Show("You Have Already Vote once");

                    }
                }
                else
                {

                    MessageBox.Show("You are not allowed to vote now");
                }
            }
            else
            {
                MessageBox.Show("You are not allowed to vote now");
            }
                    
                    
                
            
           }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void BVCPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangeVoterPassword changepassword = new ChangeVoterPassword();
            changepassword.Show();
        }

        private void BLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            E_Polling.EPolling epoll = new E_Polling.EPolling();
            epoll.Show();
        }
    }
}
