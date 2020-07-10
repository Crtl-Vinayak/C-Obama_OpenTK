using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SQL_input
{
    public partial class Form2 : Form
    {
        Variables vars = new Variables();
        SqlBusiness login = new SqlBusiness();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        //afsluiten applicatie
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Wilt u Afsluiten?", "Opties", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //inlogknop
        public void btn_login_Click(object sender, EventArgs e)
        {
            //inloggegevens gebruiker invoeren
            vars.Database = tbx_dbname.Text;
            vars.Ipadress = tbx_ipaddress.Text;
            vars.Username = tbx_username.Text;
            vars.Password = tbx_password.Text;
            vars.Port = tbx_port.Text;
            //connectie maken met DB
            login.DBconnect(vars.Ipadress, vars.Port, vars.Username, vars.Password, vars.Database);
            //kijken of de connectie er is
            login.isConected();
            //login opslaan
            Savelogin(vars.Ipadress, vars.Port, vars.Username, vars.Password, vars.Database);
            //volgend venster
            openNW();
        }

        //ClearAllfield in General menu
        private void clearAllFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("This wil clear all fields \n Continue?", "Options", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                tbx_username.Text = "";
                tbx_password.Text = "";
                tbx_dbname.Text = "";
                tbx_ipaddress.Text = "";
                tbx_port.Text = "";
            }
        }

        //savelogin knop in Login Options
        private void saveLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vars.Database = tbx_dbname.Text;
            vars.Ipadress = tbx_ipaddress.Text;
            vars.Username = tbx_username.Text;
            vars.Password = tbx_password.Text;
            vars.Port = tbx_port.Text;
            Savelogin(vars.Ipadress, vars.Port, vars.Username, vars.Password, vars.Database);
        }

        //loadlogin knop in Login Options
        private void loadLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gebruiker een bestand laten selecteren
            OpenFileDialog loadFile = new OpenFileDialog();
            if (loadFile.ShowDialog() == DialogResult.OK)
            {
                //het door de gebruiker geselecteerde bestand pakken
                string path = loadFile.FileName;
                try
                {
                    //Streamreader gebruiken om path van OpenFileDialog te kunnen lezen
                    using (StreamReader sr = new StreamReader(Path.Combine(path)))
                    {
                        //file lezen en in array stoppen
                        string[] login = File.ReadAllLines(path);
                        //info in de applicatie plaatsen
                        tbx_username.Text = login[0];
                        tbx_password.Text = login[1];
                        tbx_dbname.Text = login[2];
                        tbx_ipaddress.Text = login[3];
                        tbx_port.Text = login[4];
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Het bestand kon niet gelezen worden: " + err.Message, "Opties", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //FUNCTIES
        //volgende window laten zien na login
        public void openNW()
        {
            if (login.checkConn == true)
            {
                Main_Form go = new Main_Form();
                go.Show();
                this.Hide();
            }
        }

        //Functie SaveLogin
        public void Savelogin(string tb1, string tb2, string tb3, string tb4, string tb5)
        {
            DialogResult DialogResult = MessageBox.Show("Login opslaan?", "Options", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                //array met info
                string[] login = { vars.Username, vars.Password, vars.Database, vars.Ipadress, vars.Port };
                //locatie bestand
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                //bastand opslaan
                using (StreamWriter saveLogin = new StreamWriter(Path.Combine(docPath, "Login_Database_" + vars.Database + ".txt")))
                {
                    foreach (string info in login)
                    {
                        saveLogin.WriteLine(info);
                    }
                }
                MessageBox.Show("Login opgeslagen in " + docPath, "Opties", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}