using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ProjetFreeGoWindows
{
    class connectionDB
    {
        //connection to the database
        private SQLiteConnection m_dbConnection;
        public List<Ingredients> IngredientsInFridge = new List<Ingredients>();


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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private int GetUserId(string username)
        {
            int iduser = 0;

            string sql = "select IdUser from User where UserName = "+"'"+username+"'";
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    iduser = Convert.ToInt32(reader["IdUser"]);
                }

                return iduser;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Il y a une erreur");
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdUser"></param>
        /// <returns></returns>
        private int GetIdFridge(int IdUser)
        {
            int idfridge = 0;

            try
            {
                string sql = "select IdFridge from Fridge where IdUser =" + IdUser;
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idfridge = Convert.ToInt32(reader["IdFridge"]);
                }

                return idfridge;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Il y a une erreur");
                return 0;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="IdUser"></param>
        /// <returns></returns>
        private int GetLastIngredientsAdded(int IdUser)
        {
            int IdLastIngredient = 0;

            try
            {
                string sql = "SELECT IdIngredients FROM Ingredients where IdUser=" + IdUser + " ORDER BY IdIngredients DESC LIMIT 1;";
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    IdLastIngredient = Convert.ToInt32(reader["IdIngredients"]);
                }

                return IdLastIngredient;
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        /// <summary>
        /// AddIngredient: Add a new Ingredient to the database
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Name"></param>
        /// <param name="ExpirationDate"></param>
        /// <param name="Quantity"></param>
        /// <param name="Unit"></param>
        /// <param name="Path"></param>
        /// <returns></returns>
        public bool AddIngredient(string UserName, string Name, string ExpirationDate, int Quantity, int Unit, string Path)
        {
            int iduser = GetUserId(UserName);
            int idfridge = GetIdFridge(iduser);

            string sql = "insert into Ingredients (IdUser,Nom,ExpirationDate,Quantity,Unit,ImagePath) values (" + iduser +","+"'" + Name + "'" + "," + "'" + ExpirationDate + "'" + "," + Quantity + "," + Unit + "," + "'" + Path + "'" + ")";

            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            try
            {
                command.ExecuteNonQuery();
                int idLastIngredientByUser = GetLastIngredientsAdded(iduser);
                string sql2 = "insert into IngredientsListInFridge values (" + idfridge +","+idLastIngredientByUser + ")";
                SQLiteCommand command2 = new SQLiteCommand(sql2, m_dbConnection);
                command2.ExecuteNonQuery();

                MessageBox.Show("L'aliment à correctement été ajouté");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Il y a une erreur, vérifier vos champs");
                return false;
            }
        }

        /// <summary>
        /// GetIngredientsByUser: Get All Ingredients for a specific user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public List<Ingredients> GetIngredientsByUser(string username)
        {
            int IdUser = GetUserId(username);

            try
            {
                string sql = "select Ingredients.Nom, Ingredients.ExpirationDate, Ingredients.Quantity, Ingredients.Unit, Ingredients.ImagePath from Ingredients inner join IngredientsListInFridge where Ingredients.IdIngredients = IngredientsListInFridge.Fk_IdIngredients and Ingredients.IdUser = " + IdUser;
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Ingredients ingredients = new Ingredients(Convert.ToString(reader["Nom"]),Convert.ToDateTime(reader["ExpirationDate"]),Convert.ToInt32(reader["Quantity"]),Convert.ToInt32(reader["Unit"]),Convert.ToString(reader["ImagePath"]));
                    IngredientsInFridge.Add(ingredients);
                }

            }
            catch(Exception ex)
            {

            }
           
            return IngredientsInFridge;
        }

        /// <summary>
        /// ModifIngredient: Modify Ingredient Values
        /// </summary>
        /// <param name="IngName"></param>
        /// <param name="Quantity"></param>
        /// <param name="Unit"></param>
        /// <param name="oldIngName"></param>
        public void ModifIngredient(string IngName, int Quantity, int Unit, DateTime expirationdate, string oldIngName)
        {
            string sql = "UPDATE Ingredients SET Nom=" + "'" + IngName + "'," + " Quantity=" + Quantity+ "," + "Unit=" + Unit + " WHERE Nom=" +"'"+ oldIngName+ "'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }

        public void RemoveIngredient(string IngName)
        {
            string sql = "DELETE FROM Ingredients WHERE Ingredients.Nom = "+"'"+IngName+"'";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }


    }
}
