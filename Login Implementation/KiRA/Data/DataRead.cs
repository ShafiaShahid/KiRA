using KiRA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

using MySql;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows;

namespace KiRA.Data
{
    public class DataRead
    {
        public static User GetUser(int userID)
        {
            string query = "SELECT * FROM kira_user WHERE id = " + userID + ";";

            using (var conn = new MySqlConnection("Server=kira-web.mysql.database.azure.com; Port=3306; Database=kira-db; Uid=incentrio@kira-web; Pwd=Incentri0; SslMode=Preferred;"))
                return conn.Query<User>(query, commandType: CommandType.Text).FirstOrDefault();
        }

        public static User GetUser(string username, string password)
        {
          
            
               MySqlConnection conn = null;
               MySqlDataReader rdr = null;

       
            conn = new MySqlConnection("Server=kira-web.mysql.database.azure.com; Port=3306; Database=kira-db; Uid=incentrio@kira-web; Pwd=Incentri0; SslMode=Preferred;");
            conn.Open();
        
            string stm =  "SELECT * FROM kira_user WHERE username = '" + username + "' and pass ='" + password + "'";

            MySqlCommand cmd = new MySqlCommand(stm, conn);
            rdr = cmd.ExecuteReader();

            

            int count = 0;
            while (rdr.Read()) 
            {

               count ++;
                
            }
            if (count == 1)
            {
                MessageBox.Show("Username and password is correct");

            }
            if (count > 1)
            {
                MessageBox.Show(" Duplicate Username and password, please try again!");

            }
            if (count < 1)
            {
                MessageBox.Show(" Username and password is incorrect");

            }

            using (var con = new MySqlConnection("Server=kira-web.mysql.database.azure.com; Port=3306; Database=kira-db; Uid=incentrio@kira-web; Pwd=Incentri0; SslMode=Preferred;"))
                return con.Query<User>(stm, commandType: CommandType.Text).FirstOrDefault();

        }
    }
}
