using MySql.Data.MySqlClient;


namespace Library
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306; username=root; password=root; database=library");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }

    }
}
