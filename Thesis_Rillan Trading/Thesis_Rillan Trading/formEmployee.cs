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

namespace Thesis_Rillan_Trading
{
    public partial class formEmployee : Form
    {
        // Variable 
        public MySqlConnection conn;


        // Variable for Reference Forms
        public Form refAdminHome { get; set; }
        public int ref_Emp_empID;


        public formEmployee()
        {
            InitializeComponent();
            conn = new MySqlConnection("Server=localhost; Database=rillan_trading; Uid=root; Pwd=root;");
        }

        // - - - Form Load - - -
        private void formEmployee_Load(object sender, EventArgs e)
        {
            // - - Date and Time label - -
            timer.Start();
            lbl_DateTime.Text = DateTime.Now.ToShortTimeString() + " " + DateTime.Now.ToLongDateString();

            // - - Data Grid View - - 
            try
            {
                conn.Open();

                MySqlCommand comm = new MySqlCommand("SELECT * FROM employee", conn);
                MySqlDataAdapter adp = new MySqlDataAdapter(comm);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                dataGV_Emp.DataSource = dt; // filing in data from database to datagridview

                

                conn.Close();
            }
            catch (Exception ee)
            {
                conn.Close();
            }
        }

        // Logout Button
        private void btn_Logout_Click_1(object sender, EventArgs e)
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
            fAdminHome.ref_empID = ref_Emp_empID;
            fAdminHome.Show();
            this.Hide();
        }
        
        // Save Button - saving input to database
        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        // Info Button - - Create/Find
        private void btn_Info_Click(object sender, EventArgs e)
        {
            /*This happens, when Info is clicked. Change to create mode.
             * 
             * if (btn_Info.Text == "Create Mode")
            {
                btn_Submit.Enabled = false;

                // Field Colors change to Blue for Search Mode
                tbox_firstName.BackColor = Color.LightBlue;
                tbox_lastName.BackColor = Color.LightBlue;
                tbox_middleName.BackColor = Color.LightBlue;
                tbox_mobileNum.BackColor = Color.LightBlue;
            }
            */
        }

        private void pnl_Header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGV_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_lastName_Click(object sender, EventArgs e)
        {

        }

        private void tbox_lastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
