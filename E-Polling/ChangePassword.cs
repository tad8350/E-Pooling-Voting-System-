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
    public partial class ChangePassword : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void BCPassword_Click(object sender, EventArgs e)
        {
            Admin admin=new Admin();

            var query = from temp in db.Admins
                        where TNid.Text == temp.NID && TCPassword.Text == temp.Password 
                        select temp;
            admin = query.First();
            if(admin!=null)
            {
                admin.Password = TNPassword.Text;
                db.SubmitChanges();
                MessageBox.Show("Changes done.");
            }

        }

        private void BBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adminpanel = new AdminPanel();
            adminpanel.Show();
        }

        private void ChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
    }
}
