using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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

        private void passwordText_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordText.Text == "Пароль")
            {
                passwordText.Clear();
                passwordText.PasswordChar = '*';
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String userName = usernameText.Text;
            String passUser = passwordText.Text;

            DataBase dataBase = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `username`= @uname AND `password` = @upass", dataBase.GetConnection());
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = userName;
            command.Parameters.Add("@upass", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Library library = new Library();
                library.Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль или имя пользователя!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void link_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();

        }
    }
}
