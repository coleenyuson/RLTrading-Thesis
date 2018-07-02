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
    public partial class formEmployee : Form
    {
        // Variable for Reference Forms
        public Form refAdminHome { get; set; }
        public int ref_Emp_empID;

        public formEmployee()
        {
            InitializeComponent();
        }

        // - - - Form Load - - -
        private void formEmployee_Load(object sender, EventArgs e)
        {

        }

        // Logout Button
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            formLogin fLogin = new formLogin();
            fLogin.refEmployee = this;
            fLogin.Show();
            this.Hide();
        }

        // Back Button
        private void btn_Back_Click(object sender, EventArgs e)
        {
            formAdminHome fAdminHome = new formAdminHome();
            fAdminHome.refEmployee = this;
            fAdminHome.Show();
            this.Hide();
        }

        // Info Button - - Create/Find
        private void btn_Info_Click(object sender, EventArgs e)
        {
            if (btn_Info.Text == "Create Mode")
            {
                btn_Submit.Enabled = false;

                // Field Colors change to Blue for Search Mode
                tbox_firstName.BackColor = Color.LightBlue;
                tbox_lastName.BackColor = Color.LightBlue;
                tbox_middleName.BackColor = Color.LightBlue;
                tbox_mobileNum.BackColor = Color.LightBlue;
            }
        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
