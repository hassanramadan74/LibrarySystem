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
    public partial class Buying : Form
    {
        public Buying()
        {
            InitializeComponent();
        }

        private void Buying_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            // TODO: This line of code loads data into the 'databaseprDataSet.content' table. You can move, or remove it, as needed.
            this.contentTableAdapter.Fill(this.databaseprDataSet.content);

        }

        private void buttonBuying_Click(object sender, EventArgs e)
        {

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into buying values('"+ textBoxuserID.Text + "','" + textBoxPrice.Text + "','"+ textBoxCName.Text + "','"+ textBoxOffer.Text + "','"+ textBoxBuyDate.Text + "','" + textBoxNum.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
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
            //"insert into buying values('"+ textBoxAdminID.Text +"','" + textBoxuserID.Text + "','" + textBoxPrice.Text + "','" + textBoxCName.Text + "','" + textBoxOffer.Text + "','" + textBoxBuyDate.Text + "','" + textBoxNum.Text + "')";
            sqlCommand.CommandText = "insert into check_sales values ('"+ textBoxAdminID.Text + "','"+ textBoxuserID.Text + "', '" + textBoxPrice.Text + "' ,'" + textBoxCName.Text + "','" + textBoxOffer.Text + "','" + textBoxBuyDate.Text + "','" + textBoxNum.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
            this.Hide();
        }
    }
}
 