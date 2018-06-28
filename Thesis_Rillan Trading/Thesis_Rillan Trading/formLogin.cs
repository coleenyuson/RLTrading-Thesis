using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_Rillan_Trading
{
    public partial class formLogin : Form
    {

        //Connection to Database
        //public MySqlConnection conn;

        //Variables
        public Form refAdminHome { get; set; }
        public Form refEmployee { get; set; }

        public formLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            formAdminHome fAdminHome = new formAdminHome();
            fAdminHome.refLogin = this;
            fAdminHome.Show();
            this.Hide();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
