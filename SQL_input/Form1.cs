using MySql.Data.MySqlClient;
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
    public partial class Main_Form : Form
    {
        Variables vars = new Variables();
        SqlBusiness Database = new SqlBusiness();
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_export_excel.Enabled = false;
            btn_export_txt.Enabled = false;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            try { 
            //SQL qeurry
            vars.Sqlcommand = tbx_command.Text;
            //Data ophalen en in tabel stoppen
                //Dataadapter om qeury en te sturen en result op te vangen
                MySqlDataAdapter mySqlData = new MySqlDataAdapter(vars.Sqlcommand, SqlBusiness.DBconnection);
                //datatable waar het result in wordt opgeslagen
                mySqlData.Fill(vars.DataTable);
                //Tabel op het scherm de data aanweizen
               dgv_qeuryresult.DataSource = vars.DataTable;
            }
            catch (Exception y)
            {
                MessageBox.Show(y + "\n" + "Fout bij het sturen van de qeury.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (btn_edit.Enabled != true)
                {
                    btn_edit.Enabled = true;
                    btn_export_excel.Enabled = true;
                    btn_export_txt.Enabled = true;
                }
            Console.WriteLine(vars.DataTable);
        }

        private void btn_export_txt_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Wilt u Afsluiten?", "Opties", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void switchDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Wilt u van database veranderen?", "Opties", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Form go = new Form3();
            go.Show();
        }
    }
}