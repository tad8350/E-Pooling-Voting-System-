﻿using System;
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
    public partial class ChangeVoterPassword : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");


        public ChangeVoterPassword()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Voter voter = new Voter();

            var query = from temp in db.Voters
                        where TNid.Text == temp.NID && TCPassword.Text == temp.Password
                        select temp;
            voter = query.First();
            if (voter != null)
            {
                voter.Password = TNPassword.Text;
                db.SubmitChanges();
                MessageBox.Show("Changes done.");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 voterpanel = new Form2();
            voterpanel.Show();
        }

        private void ChangeVoterPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        
    }
}
