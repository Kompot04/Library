using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Library
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;

            DataBase dataBase = new DataBase();
            DataSet table = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `newbook` ", dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dataGridView1.DataSource = table.Tables[0];
            
        }

        int id;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                
            }

            panel2.Visible = true;
            DataBase dataBase = new DataBase();
            DataSet dset = new DataSet();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `newbook` WHERE `id`= "+id, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(dset);

            rowid = Int64.Parse(dset.Tables[0].Rows[0][0].ToString());

            bookNameField.Text = dset.Tables[0].Rows[0][1].ToString();
            auhorField.Text = dset.Tables[0].Rows[0][2].ToString();
            publicationField.Text = dset.Tables[0].Rows[0][3].ToString();
            pDateField.Text = dset.Tables[0].Rows[0][4].ToString();
            priceField.Text = dset.Tables[0].Rows[0][5].ToString();
            quantityField.Text = dset.Tables[0].Rows[0][6].ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;

        }

        private void bNameField_TextChanged(object sender, EventArgs e)
        {
            if (bNameField.Text != "")
            {
                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `newbook` WHERE CONCAT( `bName`) LIKE '%" + bNameField.Text+"%'", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table.Tables[0];
            }
            else
            {
                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM `newbook` ", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dataGridView1.DataSource = table.Tables[0];
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            bNameField.Clear();
            panel2.Visible = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Данные будут обновлены. Подтверждать? ", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String bname = bookNameField.Text;
                String bauthor = auhorField.Text;
                String bpublication = publicationField.Text;
                String bpdate = pDateField.Text;
                Int64 bprice = Int64.Parse(priceField.Text);
                Int64 bquantity = Int64.Parse(quantityField.Text);

                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("UPDATE `newbook` SET `bName`='" + bname + "' , `bAuthor` = '" + bauthor + "' ,`bPublication` = '" + bpublication + "' , `bPDate` = '" + bpdate + "' , `bPrice` = " + bprice + " ,`bQuantity` = " + bquantity + "  WHERE id=" + rowid + "   ", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

            }


        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Данные будут удалены. Подтверждать? ", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                
                DataBase dataBase = new DataBase();
                DataSet table = new DataSet();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("DELETE FROM `newbook` WHERE id="+ rowid+"  ", dataBase.GetConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
