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
    public partial class Form3 : Form
    {
        Variables vars = new Variables();
        SqlBusiness database = new SqlBusiness();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dgv_edit.DataSource = vars.DataTable;
        }
    }
}
