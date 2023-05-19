using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace virsion2LibrarySys
{
    public partial class Make_Offer : Form
    {
        public Make_Offer()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Make_Offer_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            // TODO: This line of code loads data into the 'databaseprDataSet.make_offer' table. You can move, or remove it, as needed.
            this.make_offerTableAdapter.Fill(this.databaseprDataSet.make_offer);

        }

        private void Cencel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveadd_Click(object sender, EventArgs e)
        {

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into make_offer values('"+ textBoxPrice.Text +"','"+ textBoxCName.Text +"','"+ textBoxoffer.Text +"','"+ textBoxIDforAdmin.Text + "')";
            sqlCommand.ExecuteNonQuery();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "update content SET offer = '" + textBoxoffer.Text + "' where price ='" + textBoxPrice.Text + "'and content_Name='" + textBoxCName.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
            this.Hide();
        }

    }
}
