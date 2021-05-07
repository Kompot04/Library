using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            enterEnrollField.Clear();
        }

        private void searchStudButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ibook` WHERE `stud_enrollment`= '"+enterEnrollField.Text+"' AND  book_return IS NULL ", dataBase.GetConnection());

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataSet table = new DataSet();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = table.Tables[0];
            }
            else
            {
                
                MessageBox.Show("Неправильный номер регистрации или кнгиги не выданы", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();


            }
            bookNameField.Text = bname;
            bookIssueField.Text = bdate;

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("UPDATE  `ibook` SET  `book_return`='" + dateTimePicker.Text+ "' WHERE `stud_enrollment`='"+enterEnrollField.Text+"' AND `id`="+rowid+" ", dataBase.GetConnection());
            dataBase.openConnection();
            command.ExecuteNonQuery();
           
            dataBase.closeConnection();

            MessageBox.Show(" Книга возвращена.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ReturnBooks_Load(this, null);

        }
       
        private void enterEnrollField_TextChanged(object sender, EventArgs e)
        {
            if(enterEnrollField.Text == "")
            {
                panel1.Visible = false;
                dataGridView1.DataSource = null;

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            enterEnrollField.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        
    }
}
