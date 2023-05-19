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
    public partial class SHOW : Form
    {
        public SHOW()
        {
            InitializeComponent();
        }

        private void SHOW_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            // TODO: This line of code loads data into the 'databaseprDataSet.content' table. You can move, or remove it, as needed.
            this.contentTableAdapter.Fill(this.databaseprDataSet.content);
            dataGridView2.Visible = false;
            dataGridView1.Visible = false;

        }

        private void avaContent_Click(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select content_Name,price from content where no_of_avialable_copies!='0'";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        private void buttonshowall_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "select * from content";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
