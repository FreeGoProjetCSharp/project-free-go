using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ProjetFreeGoWindows
{
    class connectionDB
    {
        //connection to the database
        private SQLiteConnection m_dbConnection;

        public connectionDB()
        {
            m_dbConnection = new SQLiteConnection("Data Source=bdd.db;Version=3;");
            m_dbConnection.Open(); 
        }


        public void CreateAccount(string username, string mail, string password)
        {
            int IdFridge = 0;

            // Create a new Fridge
            string sql = "INSERT INTO [Fridge] DEFAULT VALUES;";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            // Select last IDFridge
            string sql2 = "SELECT * FROM Fridge ORDER BY IdFridge DESC LIMIT 1";
            SQLiteCommand command2 = new SQLiteCommand(sql2, m_dbConnection);
            SQLiteDataReader reader = command2.ExecuteReader();

            while(reader.Read())
            {
                IdFridge = Convert.ToInt32(reader["IdFridge"]);
            }

            // Create new user
            string sql3 = "insert into User (Username, UserEmail, UserPassword,Fridge_IdFridge) values ('"+username+"','"+mail+"','"+password+"',"+IdFridge+")";
            SQLiteCommand command3 = new SQLiteCommand(sql3, m_dbConnection);
            command3.ExecuteNonQuery();

        }

    }
}
