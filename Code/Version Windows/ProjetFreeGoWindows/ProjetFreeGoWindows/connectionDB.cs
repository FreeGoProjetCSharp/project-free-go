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

        /// <summary>
        /// Method to hash password in MD5
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Method to create new account
        /// </summary>
        /// <param name="username"></param>
        /// <param name="mail"></param>
        /// <param name="password"></param>
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

            while (reader.Read())
            {
                IdFridge = Convert.ToInt32(reader["IdFridge"]);
            }

            // Create new user
            string sql3 = "insert into User (Username, UserEmail, UserPassword,Fridge_IdFridge) values ('" + username + "','" + mail + "','" + password + "'," + IdFridge + ")";
            SQLiteCommand command3 = new SQLiteCommand(sql3, m_dbConnection);
            command3.ExecuteNonQuery();

        }

        /// <summary>
        /// Method to login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            string usr = "";
            string pass = "";

            string sql = "select UserName, UserPassword from User where User.UserName =" + '"' + username + '"';
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                usr = Convert.ToString(reader["UserName"]);
                pass = Convert.ToString(reader["UserPassword"]);
            }

            return usr == username && pass == password;
        }

        /// <summary>
        /// Get username and email from selected user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string[] GetUserInfo(string username)
        {
            string[] info = new string[2];
            string sql = "select UserName, UserEmail from User where User.UserName = "+'"'+ username +'"'+"";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                info[0]= Convert.ToString(reader["UserName"]);
                info[1]= Convert.ToString(reader["UserEmail"]);
            }

            return info;
        }

        public void AddIngredient(string Name, string ExpirationDate, int Quantity, int Unit, string Path)
        {
            // insert into Ingredients (Nom,ExpirationDate,Quantity,Unit,ImagePath) values ("test","10.01.2019",1,1,"C:\\Users\\Leo.ZMOOS\\Desktop\\ProjetFreeGo\\project-free-go\\Code\\Version Windows\\ProjetFreeGoWindows\\ProjetFreeGoWindows\\bin\\Debug\\Images\\syly\\")
            string sql = "insert into Ingredients (Nom,ExpirationDate,Quantity,Unit,ImagePath) values ("+'"'+Name+'"'+ExpirationDate+Quantity+Unit+Path+")";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        }
    }
}
