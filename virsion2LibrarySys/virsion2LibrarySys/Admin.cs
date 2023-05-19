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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseprDataSet.make_offer' table. You can move, or remove it, as needed.
            this.make_offerTableAdapter.Fill(this.databaseprDataSet.make_offer);
            // TODO: This line of code loads data into the 'databaseprDataSet.content' table. You can move, or remove it, as needed.
            this.contentTableAdapter.Fill(this.databaseprDataSet.content);
            // TODO: This line of code loads data into the 'databaseprDataSet.check_sales' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'databaseprDataSet.admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.databaseprDataSet.admin);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void updateadmin_Click(object sender, EventArgs e)
        {
            Update_Profile abs = new Update_Profile();
            abs.Show();
        }

        private void UploadCon_Click(object sender, EventArgs e)
        {
            Upload_Content abs = new Upload_Content();
            abs.Show();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolOffers_Click(object sender, EventArgs e)
        {
            Make_Offer abs = new Make_Offer();
            abs.Show();
        }

        private void toolChSales_Click(object sender, EventArgs e)
        {
            this.check_salesTableAdapter.Fill(this.databaseprDataSet.check_sales);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SQL_statement abs = new SQL_statement();
            abs.Show();
        }
    }
}
