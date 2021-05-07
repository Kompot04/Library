using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class BookDetail : Form
    {
        public BookDetail()
        {
            InitializeComponent();
        }
        
      

        private void BookDetail_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ibook` WHERE`book_return` IS NULL ", dataBase.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet table = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(table);
            dataGridView1.DataSource = table.Tables[0];

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM `ibook` WHERE `book_return`IS NOT NULL ", dataBase.GetConnection());
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            DataSet table1 = new DataSet();

            adapter1.SelectCommand = command1;
            adapter1.Fill(table1);
            dataGridView2.DataSource = table1.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
