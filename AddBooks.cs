using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Library
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (bookNameField.Text != "" && authorField.Text != "" && publicationField.Text != "" && priceField.Text != "" && quantityField.Text != "")
            {

                String bname = bookNameField.Text;
                String bauthor = authorField.Text;
                String bpublication = publicationField.Text;
                String pdate = dateTimePicker1.Text;
                Int64 bprice = Int64.Parse(priceField.Text);
                Int64 bquantity = Int64.Parse(quantityField.Text);


                DataBase dataBase = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `newbook` (`bName`, `bAuthor`, `bPublication`, `bPDate`, `bPrice`, `bQuantity`) VALUES (@bName, @bAuthor, @bPublication, @bPDate, @bPrice, @bQuantity)", dataBase.GetConnection());

                command.Parameters.Add("@bName", MySqlDbType.VarChar).Value = bookNameField.Text;
                command.Parameters.Add("@bAuthor", MySqlDbType.VarChar).Value = authorField.Text;
                command.Parameters.Add("@bPublication", MySqlDbType.VarChar).Value = publicationField.Text;
                command.Parameters.Add("@bPDate", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
                command.Parameters.Add("@bPrice", MySqlDbType.Int64).Value = Int64.Parse(priceField.Text);
                command.Parameters.Add("@bQuantity", MySqlDbType.Int64).Value = Int64.Parse(quantityField.Text);

                dataBase.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные сохранены.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dataBase.closeConnection();

                bookNameField.Clear();
                authorField.Clear();
                publicationField.Clear();
                priceField.Clear();
                quantityField.Clear();
            }
            else
            {
                MessageBox.Show("Пустое поле не допускается", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Это удалит ваши несохраненные данные.", "Вы уверены? ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) { 
            this.Close();
        }
        }
        
        
    }
}
