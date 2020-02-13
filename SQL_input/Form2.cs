using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Wilt u Afsluiten?", "Opties", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            //inloggegevens gebruiker invoeren
            vars.Database = tbx_dbname.Text;
            vars.Ipadress = tbx_ipaddress.Text;
            vars.Username = tbx_username.Text;
            vars.Password = tbx_password.Text;
            vars.Port = tbx_port.Text;
            login.DBconnect(vars.Ipadress, vars.Port, vars.Username, vars.Password, vars.Database);
            login.isConected();

        }
    }
}