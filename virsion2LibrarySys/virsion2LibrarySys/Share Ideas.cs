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
    public partial class Share_Ideas : Form
    {
        public Share_Ideas()
        {
            InitializeComponent();
        }

        private void Share_Ideas_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
        }

        private void saveadd_Click(object sender, EventArgs e)
        {

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "update content SET comment = '" + textBoxcomment.Text + "' where content_Name ='" + textBoxCName.Text + "'and type='" + txtType.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
            this.Hide();
        }

        private void Cencel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonsharing_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "update \"user\" SET user_comment='" + textBoxcomment.Text + "' where username='" + textBoxUserName.Text + "'and user_id='" + textBoxuserID.Text + "'";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
        }
    }
}
