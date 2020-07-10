using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_input

{
   public class Variables
    {
        //variabelen voor de main window
        private static string sqlCommand = "";
        private static DataTable dataTable = new DataTable();


        //variabelen SQL connectie
        private static string ipaddress = "";
        private static string port = "";
        private static string username = "";
        private static string password = "";
        private static string database = "";

        //getters & setters

        public DataTable DataTable
        {
           get { return dataTable; }
           set { dataTable = value; }
        }
        public string Sqlcommand
        {
            get { return sqlCommand; }
            set { sqlCommand = value; }
        }

        //connectie getters & setters

        public string Ipadress
        {
            get { return ipaddress; }
            set { ipaddress = value; }
        }

        public string Port
        {
            get { return port; }
            set { port = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Database
        {
            get { return database; }
            set { database = value; }
        }
    }
}
