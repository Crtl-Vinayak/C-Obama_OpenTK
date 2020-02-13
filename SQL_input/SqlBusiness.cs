using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_input
{

    public class SqlBusiness
    {
        static string MySQLConnectionString;
        MySqlConnection DBconnection;
        public object DBconnect(string ipadd, string port, string username, string password, string dbname)
        {
            MySQLConnectionString = "datasource=" + ipadd + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + dbname;

            try
            {
                DBconnection = new MySqlConnection(MySQLConnectionString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "\n" + "Null error bij MySQLConnectionString.");
            }

            Console.WriteLine(MySQLConnectionString);
            Console.ReadLine();
            return MySQLConnectionString;
        }

        //public bool isConected()
        //{

        //    if (DbConnection.State == ConnectionState.Closed) {
        //        DBconnection.Open();
        //        MessageBox.Show("Connection sucsessfull");
        //        return true;
        //    }
        //    else if (DbConnection.State == ConnectionState.Open) {
        //        MessageBox.Show("Connection already open");
        //        return true;
        //    }
        //    else return false;
        //}
    }
}