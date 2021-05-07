using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameText_MouseClick(object sender, MouseEventArgs e)
        {
            if (usernameText.Text == "Имя пользователя")
            {
                usernameText.Clear();
            }
        }

        private void emailText_MouseClick(object sender, MouseEventArgs e)
        {
            if (emailText.Text == "Почта")
            {
                emailText.Clear();
            }
        }

        private void passwordText_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordText.Text == "Пароль")
            {
                passwordText.Clear();
                passwordText.PasswordChar = '*';
            }

        }

        private void phoneText_MouseClick(object sender, MouseEventArgs e)
        {
            if (phoneText.Text == "Номер телефона")
            {
                phoneText.Clear();
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text != "" && emailText.Text != "" && phoneText.Text != "" && passwordText.Text != "")
            {
                
               
                DataBase dataBase = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`username`, `email`, `phone`, `password`) VALUES (@username, @email, @phone, @password)", dataBase.GetConnection());

                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = usernameText.Text;
                command.Parameters.Add("@email", MySqlDbType.VarChar).Value = emailText.Text;
                command.Parameters.Add("@phone", MySqlDbType.Int64).Value = Int64.Parse(phoneText.Text);
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = passwordText.Text;



                dataBase.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Регистрация успешная!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Library library = new Library();
                    library.Show();
                }
                

                dataBase.closeConnection();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните пустые поля", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
    }

