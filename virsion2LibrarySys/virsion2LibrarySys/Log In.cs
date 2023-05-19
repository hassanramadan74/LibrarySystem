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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void adminlog_Click(object sender, EventArgs e)
        {

            Admin abs = new Admin();
            abs.Show();
            this.Hide();
        }

        private void authorlog_Click(object sender, EventArgs e)
        {

            Author abs = new Author();
            abs.Show();
            this.Hide();
        }

        private void readerlog_Click(object sender, EventArgs e)
        {
            Reader abs = new Reader();
            abs.Show();
            this.Hide();
        }

        private void Log_In_Load(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
           
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM admin WHERE admin_name='" + textBoxname .Text + "' AND password='" + textBoxpass.Text + "'", sQLconnection);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable dt = new DataTable(); //this is creating a virtual table  
            sda.Fill(dt);
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT COUNT(*) FROM author WHERE author_name='" + textBoxname.Text + "' AND author_pass='" + textBoxpass.Text + "'", sQLconnection);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable ds = new DataTable(); //this is creating a virtual table  
            sda1.Fill(ds);
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT COUNT(*) FROM \"user\" WHERE username='" + textBoxname.Text + "' AND user_pass='" + textBoxpass.Text + "'", sQLconnection);
            /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
            DataTable df = new DataTable(); //this is creating a virtual table  
            sda3.Fill(df);



            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Admin f2 = new Admin();
                f2.ShowDialog();
                this.Close();
            }
            if (ds.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Author f2 = new Author();
                f2.ShowDialog();
                this.Close();
            }
            if (df.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Reader f2 = new Reader();
                f2.ShowDialog();
                this.Close();
            }

            else
                MessageBox.Show("Invalid username or password");

        }

    }
    }

