using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace virsion2LibrarySys
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into admin values('" + textBoxpass.Text + "','"+ textboxemail.Text +"','"+ textBoxtype.Text + "','"+ textBoxname.Text +"','"+ textBoxid.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();

            Admin abs = new Admin();
            abs.Show();
            this.Hide();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            
        }

        private void author_Click(object sender, EventArgs e)
        {

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into author values ('" + textBoxpass.Text + "','" + textboxemail.Text + "','" + textBoxid.Text + "','" + textBoxname.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();

            Author abs = new Author();
            abs.Show();
            this.Hide();
        }

        private void sIGItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxname_TextChanged(object sender, EventArgs e)
        {

        }

        private void reader_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into \"user\" values ('" + textBoxname.Text + "','" + textBoxpass.Text + "','" + textboxemail.Text+  "','" + textBoxid.Text + "',NULL)";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();

            Reader abs = new Reader();
            abs.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_In abs = new Log_In();
            abs.Show();
            this.Hide();
        }
    }
}
