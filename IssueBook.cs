using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class IssueBook : Form
    {
        

        public IssueBook()
        {
            InitializeComponent();
        }

        private void IssueBook_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            MySqlCommand command = new MySqlCommand("SELECT `bName` FROM `newbook`" , dataBase.GetConnection());
            dataBase.openConnection();
            MySqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    bookNameBox.Items.Add(sqlDataReader.GetString(i));
                }
            }
            sqlDataReader.Close();
        }

        private void searchStudButton_Click(object sender, EventArgs e)
        {
            if (enterEnrollField.Text != "")
            {
                String eid = enterEnrollField.Text;

                DataBase dataBase = new DataBase();
                
               MySqlCommand command = new MySqlCommand("SELECT * FROM `newstudent` WHERE `enrollment`='"+eid+"'", dataBase.GetConnection());
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                DataSet table = new DataSet();

                adapter.SelectCommand = command;
                adapter.Fill(table);


                if (table.Tables[0].Rows.Count != 0)
                {
                    studNameField.Text = table.Tables[0].Rows[0][1].ToString();
                    enrollmentField.Text = table.Tables[0].Rows[0][2].ToString();
                    departmentField.Text = table.Tables[0].Rows[0][3].ToString();
                    studSemesterField.Text = table.Tables[0].Rows[0][4].ToString();
                    studContactField.Text = table.Tables[0].Rows[0][5].ToString();
                    studEmailField.Text = table.Tables[0].Rows[0][6].ToString();

                }
                else
                {
                    studNameField.Clear();
                    departmentField.Clear();
                    studSemesterField.Clear();
                    studContactField.Clear();
                    studEmailField.Clear();
                    MessageBox.Show(" Неверный номер регистрации", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
       
        private void issueButton_Click(object sender, EventArgs e)
        {
            if(studNameField.Text != "")
            {
                if(bookNameBox.SelectedIndex != -1 /*&& count <= 2*/)
                {
                    String enroll = enrollmentField.Text;
                    String sname = studNameField.Text;
                    String sdepartment = departmentField.Text;
                    String stsemester = studSemesterField.Text;
                    Int64 scontact = Int64.Parse(studContactField.Text);
                    String semail = studEmailField.Text;
                    String bookname = bookNameBox.Text;
                    String bookissuedate = dateTimePicker.Text;

                    String eid = enterEnrollField.Text;

                    DataBase dataBase = new DataBase();

                    MySqlCommand command = new MySqlCommand("INSERT INTO `ibook` (`stud_enrollment`, `stud_name`, `stud_department`, `stud_semester`, `stud_contact`, `stud_email`, `book_name`, `book_issue` ) VALUES (@stud_enrollment, @stud_name, @stud_department, @stud_semester, @stud_contact, @stud_email, @book_name, @book_issue )", dataBase.GetConnection());
                    
                    command.Parameters.Add("@stud_enrollment", MySqlDbType.VarChar).Value = enrollmentField.Text;
                    command.Parameters.Add("@stud_name", MySqlDbType.VarChar).Value = studNameField.Text;
                    command.Parameters.Add("@stud_department", MySqlDbType.VarChar).Value = departmentField.Text;
                    command.Parameters.Add("@stud_semester", MySqlDbType.VarChar).Value = studSemesterField.Text;
                    command.Parameters.Add("@stud_contact", MySqlDbType.Int64).Value = Int64.Parse(studContactField.Text);
                    command.Parameters.Add("@stud_email", MySqlDbType.VarChar).Value = studEmailField.Text;
                    command.Parameters.Add("@book_name", MySqlDbType.VarChar).Value = bookNameBox.Text;
                    command.Parameters.Add("@book_issue", MySqlDbType.VarChar).Value = dateTimePicker.Text;

                    dataBase.openConnection();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Книга выдана.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dataBase.closeConnection();
                   
                }
                else
                {
                    MessageBox.Show("Выберите книгу. ", " No book selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Неправильный номер регистрации", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void enterEnrollField_TextChanged(object sender, EventArgs e)
        {
            if(enterEnrollField.Text == "")
            {
                studNameField.Clear();
                departmentField.Clear();
                studSemesterField.Clear();
                studContactField.Clear();
                studEmailField.Clear();

            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            enterEnrollField.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы уверены? ", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
           
            
        }

        

        
    }
}
