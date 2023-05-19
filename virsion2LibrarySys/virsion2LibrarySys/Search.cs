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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseprDataSet.content' table. You can move, or remove it, as needed.
            this.contentTableAdapter.Fill(this.databaseprDataSet.content);
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "select * from content";
            SqlDataAdapter DA = new SqlDataAdapter(sqlCommand);
            DataSet ds = new DataSet();
            DA.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void SearchCate_TextChanged(object sender, EventArgs e)
        {
            if (SearchCate.Text!="")
            {

                SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sQLconnection;
                sQLconnection.Open();
                sqlCommand.CommandText = "select * from content where category = '"+ SearchCate.Text + "'";
                SqlDataAdapter DA = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                sqlCommand.ExecuteNonQuery();
                sQLconnection.Close();
            }
            else
            {
                SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sQLconnection;
                sQLconnection.Open();
                sqlCommand.CommandText = "select * from content";
                SqlDataAdapter DA = new SqlDataAdapter(sqlCommand);
                DataSet ds = new DataSet();
                DA.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                sqlCommand.ExecuteNonQuery();
                sQLconnection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            sqlCommand.CommandText = "insert into buying values('" + textBoxuserID.Text + "','" + textBoxPrice.Text + "','" + textBoxCName.Text + "','" + textBoxOffer.Text + "','" + textBoxBuyDate.Text + "','" + textBoxNum.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sQLconnection;
            sQLconnection.Open();
            //"insert into buying values('"+ textBoxAdminID.Text +"','" + textBoxuserID.Text + "','" + textBoxPrice.Text + "','" + textBoxCName.Text + "','" + textBoxOffer.Text + "','" + textBoxBuyDate.Text + "','" + textBoxNum.Text + "')";
            sqlCommand.CommandText = "insert into check_sales values ('" + textBoxAdminID.Text + "','" + textBoxuserID.Text + "', '" + textBoxPrice.Text + "' ,'" + textBoxCName.Text + "','" + textBoxOffer.Text + "','" + textBoxBuyDate.Text + "','" + textBoxNum.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sQLconnection.Close();
        }
    }
}
