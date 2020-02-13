using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_input

{
   public class Variables
    {
        //variabelen voor de textboxen
        private static string roepnaam = "";
        private static string voorletters = "";
        private static string tussenvoegsels = "";
        private static string achternaam = "";
        private static string adres = "";
        private static string postcode = "";
        private static string woonplaats = "";
        private static string telefoon = "";
        private static string geboortedatum = "";
        private static string uitgeschreven = "";
        private static string schoolgeld = "";
        private static string betaald = "";

        //variabelen SQL connectie
        private static string ipaddress = "";
        private static string port = "";
        private static string username = "";
        private static string password = "";
        public static string database = "";
        public static string sqlconn = "";

        //getters & setters
        public string Roepnaaam
        {
            get { return roepnaam; }
            set { roepnaam = value; }
        }

        public string Voorletters
        {
            get { return voorletters; }
            set { voorletters = value; }
        }

        public string Tussenvoegsels
        {
            get { return tussenvoegsels; }
            set { tussenvoegsels = value; }
        }

        public string Achternaam
        {
            get { return achternaam; }
            set { achternaam = value; }
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }

        public string Woonplaats
        {
            get { return woonplaats; }
            set { woonplaats = value; }
        }

        public string Telefoon
        {
            get { return telefoon; }
            set { telefoon = value; }
        }

        public string Geboortedatum
        {
            get { return geboortedatum; }
            set { geboortedatum = value; }
        }

        public string Uitgeschreven
        {
            get { return uitgeschreven; }
            set { uitgeschreven = value; }
        }

        public string Schoolgeld
        {
            get { return schoolgeld; }
            set { schoolgeld = value; }
        }

        public string Betaald
        {
            get { return betaald; }
            set { betaald = value; }
        }

        //sql getters & setters

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

        public string Sqlconn
        {
            set { sqlconn = value; }
        }
    }
}
