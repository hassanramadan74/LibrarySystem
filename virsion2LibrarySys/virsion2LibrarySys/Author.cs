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
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
        }

        private void Author_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            // TODO: This line of code loads data into the 'databaseprDataSet.author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.databaseprDataSet.author);
            dataGridViewauthor.Visible = false;

        }

        private void buttonshauthor_Click(object sender, EventArgs e)
        {
            dataGridViewauthor.Visible = true;

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select * from author";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Profile_Author abs = new Update_Profile_Author();
            abs.Show();
        }
    }
}
