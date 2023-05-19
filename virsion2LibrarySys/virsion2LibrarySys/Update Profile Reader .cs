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
    public partial class Update_Profile_Reader : Form
    {
        public Update_Profile_Reader()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
        private void Update_Profile_Reader_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
        }
        private void updateAdmin_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "update \"user\" SET user_pass='"+ PassR.Text + "' , user_email='"+ emailR.Text + "' where username='"+ NameR.Text + "' and user_id='"+ IDR.Text +"'"; 
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
            this.Hide();
        }

    }
}
