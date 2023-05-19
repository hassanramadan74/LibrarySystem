using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virsion2LibrarySys
{
    public partial class Reader : Form
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void Reader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseprDataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.databaseprDataSet.admin);
            // TODO: This line of code loads data into the 'databaseprDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.databaseprDataSet.user);

        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SHOW abs = new SHOW();
            abs.Show();
        }

        private void Share_Click(object sender, EventArgs e)
        {
            Share_Ideas abs = new Share_Ideas();
            abs.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buying abs = new Buying();
            abs.Show();
        }

        private void updateadmin_Click(object sender, EventArgs e)
        {
            Update_Profile_Reader abs = new Update_Profile_Reader();
            abs.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search abs = new Search();
            abs.Show(); 
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
