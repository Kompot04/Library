using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Подтверждать?", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            studentNameField.Clear();
            enrollmentNoField.Clear();
            departmentField.Clear();
            studSemesterField.Clear();
            studContactField.Clear();
            studEmailField.Text = "";

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (studentNameField.Text != "" && enrollmentNoField.Text != "" && departmentField.Text != "" && studSemesterField.Text != "" && studContactField.Text != "" && studEmailField.Text != "")
            {

                String name = studentNameField.Text;
                String enroll = enrollmentNoField.Text;
                String department = departmentField.Text;
                String semester = studSemesterField.Text;
                Int64 contact = Int64.Parse(studContactField.Text);
                String email = studEmailField.Text;

                DataBase dataBase = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `newstudent` (`sname`, `enrollment`, `department`, `ssemester`, `scontact`, `semail`) VALUES (@sname, @enrollment, @department, @ssemester, @scontact, @semail)", dataBase.GetConnection());

                command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = studentNameField.Text;
                command.Parameters.Add("@enrollment", MySqlDbType.VarChar).Value = enrollmentNoField.Text;
                command.Parameters.Add("@department", MySqlDbType.VarChar).Value = departmentField.Text;
                command.Parameters.Add("@ssemester", MySqlDbType.VarChar).Value = studSemesterField.Text;
                command.Parameters.Add("@scontact", MySqlDbType.Int64).Value = Int64.Parse(studContactField.Text);
                command.Parameters.Add("@semail", MySqlDbType.VarChar).Value = studEmailField.Text;

                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные сохранены!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните пустые поля", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        
    }
}
