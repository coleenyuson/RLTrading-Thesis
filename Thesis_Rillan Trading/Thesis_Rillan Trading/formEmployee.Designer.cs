namespace Thesis_Rillan_Trading
{
    partial class formEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.picBox_User = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbtn_sexFemale = new System.Windows.Forms.RadioButton();
            this.rdbtn_sexMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.tbox_mobileNum = new System.Windows.Forms.TextBox();
            this.tbox_address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_lastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_middleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbox_firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listview_Emp = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_User)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.label1);
            this.pnl_Header.Controls.Add(this.btn_Settings);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.Controls.Add(this.lbl_Name);
            this.pnl_Header.Controls.Add(this.picBox_User);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-1, -1);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1108, 43);
            this.pnl_Header.TabIndex = 1;
            this.pnl_Header.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Header_Paint);
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Back_32px_3;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(10, -1);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 44);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(976, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Settings
            // 
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(1001, 0);
            this.btn_Settings.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(45, 44);
            this.btn_Settings.TabIndex = 4;
            this.btn_Settings.UseVisualStyleBackColor = true;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Exit_32px;
            this.btn_Logout.Location = new System.Drawing.Point(1050, -1);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(45, 44);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Name.Location = new System.Drawing.Point(836, 11);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(141, 25);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "JANE DOE";
            // 
            // picBox_User
            // 
            this.picBox_User.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Male_User_32px;
            this.picBox_User.Location = new System.Drawing.Point(802, 8);
            this.picBox_User.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picBox_User.Name = "picBox_User";
            this.picBox_User.Size = new System.Drawing.Size(32, 32);
            this.picBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_User.TabIndex = 3;
            this.picBox_User.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.comboBox_role);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.rdbtn_sexFemale);
            this.panel1.Controls.Add(this.rdbtn_sexMale);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtp_Birthdate);
            this.panel1.Controls.Add(this.tbox_mobileNum);
            this.panel1.Controls.Add(this.tbox_address);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbox_lastName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbox_middleName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbox_firstName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(10, 55);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 561);
            this.panel1.TabIndex = 2;
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(18, 507);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(273, 28);
            this.comboBox_role.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 484);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Role";
            // 
            // rdbtn_sexFemale
            // 
            this.rdbtn_sexFemale.AutoSize = true;
            this.rdbtn_sexFemale.Location = new System.Drawing.Point(179, 446);
            this.rdbtn_sexFemale.Name = "rdbtn_sexFemale";
            this.rdbtn_sexFemale.Size = new System.Drawing.Size(78, 24);
            this.rdbtn_sexFemale.TabIndex = 14;
            this.rdbtn_sexFemale.TabStop = true;
            this.rdbtn_sexFemale.Text = "Female";
            this.rdbtn_sexFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtn_sexMale
            // 
            this.rdbtn_sexMale.AutoSize = true;
            this.rdbtn_sexMale.Location = new System.Drawing.Point(91, 446);
            this.rdbtn_sexMale.Name = "rdbtn_sexMale";
            this.rdbtn_sexMale.Size = new System.Drawing.Size(63, 24);
            this.rdbtn_sexMale.TabIndex = 13;
            this.rdbtn_sexMale.TabStop = true;
            this.rdbtn_sexMale.Text = "Male";
            this.rdbtn_sexMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 448);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Birthdate";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.Location = new System.Drawing.Point(17, 400);
            this.dtp_Birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(274, 27);
            this.dtp_Birthdate.TabIndex = 10;
            this.dtp_Birthdate.Value = new System.DateTime(2018, 4, 22, 14, 48, 30, 0);
            // 
            // tbox_mobileNum
            // 
            this.tbox_mobileNum.Location = new System.Drawing.Point(17, 337);
            this.tbox_mobileNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_mobileNum.Name = "tbox_mobileNum";
            this.tbox_mobileNum.Size = new System.Drawing.Size(276, 27);
            this.tbox_mobileNum.TabIndex = 5;
            // 
            // tbox_address
            // 
            this.tbox_address.Location = new System.Drawing.Point(18, 229);
            this.tbox_address.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_address.Multiline = true;
            this.tbox_address.Name = "tbox_address";
            this.tbox_address.Size = new System.Drawing.Size(275, 72);
            this.tbox_address.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 315);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mobile Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // tbox_lastName
            // 
            this.tbox_lastName.Location = new System.Drawing.Point(17, 166);
            this.tbox_lastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_lastName.Name = "tbox_lastName";
            this.tbox_lastName.Size = new System.Drawing.Size(276, 27);
            this.tbox_lastName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Last Name";
            // 
            // tbox_middleName
            // 
            this.tbox_middleName.Location = new System.Drawing.Point(16, 103);
            this.tbox_middleName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_middleName.Name = "tbox_middleName";
            this.tbox_middleName.Size = new System.Drawing.Size(276, 27);
            this.tbox_middleName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Middle Name";
            // 
            // tbox_firstName
            // 
            this.tbox_firstName.Location = new System.Drawing.Point(16, 41);
            this.tbox_firstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_firstName.Name = "tbox_firstName";
            this.tbox_firstName.Size = new System.Drawing.Size(276, 27);
            this.tbox_firstName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Submit.FlatAppearance.BorderSize = 0;
            this.btn_Submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Submit.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.Location = new System.Drawing.Point(10, 620);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(306, 38);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Save";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBox8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox8.Location = new System.Drawing.Point(708, 55);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(216, 27);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = "Search";
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(929, 55);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 28);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Filter By";
            // 
            // listview_Emp
            // 
            this.listview_Emp.Location = new System.Drawing.Point(321, 89);
            this.listview_Emp.Name = "listview_Emp";
            this.listview_Emp.Size = new System.Drawing.Size(773, 470);
            this.listview_Emp.TabIndex = 18;
            this.listview_Emp.UseCompatibleStateImageBehavior = false;
            this.listview_Emp.View = System.Windows.Forms.View.Details;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Search_32px;
            this.pictureBox1.Location = new System.Drawing.Point(671, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Info
            // 
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btn_Info.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Info.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Info_32px;
            this.btn_Info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.Location = new System.Drawing.Point(10, 662);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(137, 29);
            this.btn_Info.TabIndex = 4;
            this.btn_Info.Text = "Create Mode";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // formEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 702);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listview_Emp);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btn_Info);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Header);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Employee";
            this.Load += new System.EventHandler(this.formEmployee_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_User)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox picBox_User;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbox_mobileNum;
        private System.Windows.Forms.TextBox tbox_address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_lastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_middleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbox_firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.RadioButton rdbtn_sexFemale;
        private System.Windows.Forms.RadioButton rdbtn_sexMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listview_Emp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}