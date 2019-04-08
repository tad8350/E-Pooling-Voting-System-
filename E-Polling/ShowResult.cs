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
    public partial class ShowResult : Form
    {
        DBDataContext db = new DBDataContext(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\E-Polling_2\E-Polling\E-Polling\E-Polling\E-Polling\National Database System.mdf;Integrated Security=True;Connect Timeout=30");

        

        public ShowResult()
        {
            InitializeComponent();
        }

        private void BSBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel ap = new AdminPanel();
            ap.Show();
        }

        private void ShowResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void ShowResult_Load(object sender, EventArgs e)
        {
            var query = from temp in db.Candidates
                        select temp;
            foreach (var results in query)
            {

                dataGridView1.DataSource = query;
            }
        }
    }
}
