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
    public partial class Upload_Content : Form
    {
        public Upload_Content()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Upload_Content_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            // TODO: This line of code loads data into the 'databaseprDataSet.content' table. You can move, or remove it, as needed.
            this.contentTableAdapter.Fill(this.databaseprDataSet.content);

        }

        private void button1_Click(object sender, EventArgs e)
        {
   
        }

        private void Cencel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveadd_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into content values('"+ textBoxcate.Text + "','"+ textBoxPrice.Text +"','"+ textBoxoffer.Text +"','"+ textBoxAdminID.Text + "','"+ textBoxCName.Text + "','" + txtType.Text + "','"+ textBoxauthID.Text + "','"+ textBoxauthName.Text  +  "','" + textBoxadd_date.Text + "','"+ textBoxbook_year.Text +"',NULL,'" + textBoxno_ofBooks.Text + "') ";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
            this.Hide();
        }
    }
}
