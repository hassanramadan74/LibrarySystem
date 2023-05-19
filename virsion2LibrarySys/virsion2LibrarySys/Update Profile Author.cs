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
    public partial class Update_Profile_Author : Form
    {
        public Update_Profile_Author()
        {
            InitializeComponent();
        }

        private void Update_Profile_Author_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");

        }
        private void updateAdmin_Click(object sender, EventArgs e)
        {

            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "update author set author_pass='"+ PassR.Text+ "',author_email='"+ emailR.Text + "' where author_name='"+ NameR.Text +"' and author_id='"+ IDR.Text + "' ";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            this.Hide();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
