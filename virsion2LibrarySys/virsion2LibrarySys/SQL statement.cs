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
    public partial class SQL_statement : Form

    {
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        public SQL_statement()
        {
            InitializeComponent();
        }

        private void SQL_statement_Load(object sender, EventArgs e)
        {
            
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            // TODO: This line of code loads data into the 'databaseprDataSet.user' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.databaseprDataSet.user);
            // TODO: This line of code loads data into the 'databaseprDataSet.author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.databaseprDataSet.author);
            // TODO: This line of code loads data into the 'databaseprDataSet.buying' table. You can move, or remove it, as needed.
            this.buyingTableAdapter.Fill(this.databaseprDataSet.buying);
            // TODO: This line of code loads data into the 'databaseprDataSet.content' table. You can move, or remove it, as needed.
            this.contentTableAdapter.Fill(this.databaseprDataSet.content);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            sda = new SqlDataAdapter(@"select top 1  buying.content_Name as most_intersting_book from buying group by buying.content_Name,buying.no_copies order by no_copies desc");
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {/*

            SqlConnection sQLconnection = new SqlConnection("Data Source=DESKTOP-F6LKGA9\\MSSQLSERVER01;Initial Catalog=databasepr;Integrated Security=True");
            sda = new SqlDataAdapter(@"select content.content_name 
from content , buying
where content.content_name Not in (select content_name from buying where  month(GETDATE())-1 = month(buying_date))
group by content.content_name");
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;*/
        }
    }
}
