using System;
using System.Collections;
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
        Variables vars = new Variables();
       public static MySqlConnection DBconnection;
        public static string MysqlConnentionString;
        //Dynamisch verbinding maken met DB
        public object DBconnect(string ipadd, string port, string username, string password, string dbname)
        {
            MysqlConnentionString = "datasource=" + ipadd + ";port=" + port + ";username=" + username + ";password=" + password + ";database=" + dbname;

            try
            {
                DBconnection = new MySqlConnection(MysqlConnentionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e + "\n" + "Null error bij MySQLConnectionString.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            Console.WriteLine(MysqlConnentionString);
            return MysqlConnentionString;
        }
        public bool checkConn = false;
        //kijken of de connectie van de DB open of dicht is
        public bool isConected()
        {
            if (DBconnection.State == ConnectionState.Closed)
            {
                DBconnection.Open();
                MessageBox.Show("Connection open");
                checkConn = true;
                return true;
            }
            else if (DBconnection.State == ConnectionState.Open)
            {
                checkConn = true;
                return true;
            }
            else return false;
        }
    }
}