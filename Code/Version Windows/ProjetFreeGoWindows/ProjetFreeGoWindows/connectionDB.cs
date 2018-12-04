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
            m_dbConnection = new SQLiteConnection("Data Source=Splendor.sqlite;Version=3;");


        }
    }
}
