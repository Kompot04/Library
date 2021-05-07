using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            DataBase dataBase = new DataBase();
            DataSet table = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `newstudent` ", dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table.Tables[0];
        }

        int id;
        Int64 rowid;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }

            panel2.Visible = true;
            DataBase dataBase = new DataBase();
            DataSet dset = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `newstudent` WHERE `id`= " + id+" ", dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dset);

            rowid = Int64.Parse(dset.Tables[0].Rows[0][0].ToString());

            studNameField.Text = dset.Tables[0].Rows[0][1].ToString();
            enrollmentField.Text = dset.Tables[0].Rows[0][2].ToString();
            departmentField.Text = dset.Tables[0].Rows[0][3].ToString();
            studSemesterField.Text = dset.Tables[0].Rows[0][4].ToString();
            studContactField.Text = dset.Tables[0].Rows[0][5].ToString();
            studEmailField.Text = dset.Tables[0].Rows[0][6].ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void enrollField_TextChanged(object sender, EventArgs e)
        {
            if (enrollField.Text != "")
            {
                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `newstudent` WHERE CONCAT(  `enrollment` ) LIKE '%" + enrollField.Text + "%'", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table.Tables[0];
            }
            else
            {
                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `newstudent` ", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table.Tables[0];
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            enrollField.Clear();
            panel2.Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)

        {
            String name = studNameField.Text;
            String enroll = enrollmentField.Text;
            String deparmtent = departmentField.Text;
            String semester = studSemesterField.Text;
            Int64 contact = Int64.Parse(studContactField.Text);
            String email = studEmailField.Text;

            if (MessageBox.Show("Данные будут обновлены. Подтверждать? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
               

                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("UPDATE `newstudent` SET `sname`='" + name + "' , `enrollment` = '" + enroll + "' ,`department` = '" + deparmtent + "' , `ssemester` = '" + semester + "' , `scontact` = " + contact + " ,`semail` = " + email + "  WHERE id=" + rowid + "   ", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                ViewStudent_Load(this, null);

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Данные будут удалены. Подтверждать? ", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {

                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("DELETE FROM `newstudent` WHERE `id`=" + rowid + "  ", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                ViewStudent_Load(this, null);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
