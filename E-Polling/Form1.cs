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
    public partial class EPolling : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");

        public static string loginID = "";

        public EPolling()
        {
            InitializeComponent();
        }

        private void EPolling_Load(object sender, EventArgs e)
        {

        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            

            var query = from temp in db.Admins
                        where temp.NID == TNid.Text && temp.Password == TPassword.Text
                        select temp;

            if (query.Any())
            {
                Admin a = new Admin();
                DateTime date = Convert.ToDateTime("01/01/1900");
                var query1 = from temp in db.Admins
                             select temp;
                foreach (var results in query1)
                {

                    date = a.Election_Date;
                    
                }
                if (DateTime.Now.Date == date)
                {
                    if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour <= 16)
                    {
                        MessageBox.Show("Admim not suppose to login during election time");
                    }
                    else
                    {

                        this.Hide();
                        AdminPanel ob = new AdminPanel();
                        ob.Show();
                    }
                }
                else {
                    this.Hide();
                    AdminPanel ob = new AdminPanel();
                    ob.Show();
                }
            }

            else
            {
                var query2 = from temp in db.Voters
                            where temp.NID == TNid.Text && temp.Password == TPassword.Text
                            select temp;

                if (query2.Any())
                {
                    loginID = TNid.Text;
                   
                    this.Hide();
                    Form2 ob = new Form2();
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Log In Failed!");
                }
            }
        }

        private void EPolling_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void TNid_TextChanged(object sender, EventArgs e)
        {

        }

        private void LNid_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
    }
}
