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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.picBox_User = new System.Windows.Forms.PictureBox();
            this.panel_empInfo = new System.Windows.Forms.Panel();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.lbl_role = new System.Windows.Forms.Label();
            this.rdbtn_sexFemale = new System.Windows.Forms.RadioButton();
            this.rdbtn_sexMale = new System.Windows.Forms.RadioButton();
            this.lbl_sex = new System.Windows.Forms.Label();
            this.lbl_bdate = new System.Windows.Forms.Label();
            this.dtp_Birthdate = new System.Windows.Forms.DateTimePicker();
            this.tbox_mobileNum = new System.Windows.Forms.TextBox();
            this.tbox_address = new System.Windows.Forms.TextBox();
            this.lbl_contactNum = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tbox_lastName = new System.Windows.Forms.TextBox();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.tbox_middleName = new System.Windows.Forms.TextBox();
            this.lbl_midName = new System.Windows.Forms.Label();
            this.tbox_firstName = new System.Windows.Forms.TextBox();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listview_Emp = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Info = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_User)).BeginInit();
            this.panel_empInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.label1);
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
            this.label1.Location = new System.Drawing.Point(1025, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "|";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.lbl_Name.Location = new System.Drawing.Point(836, 9);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(141, 25);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "JANE DOE";
            // 
            // picBox_User
            // 
            this.picBox_User.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Male_User_32px;
            this.picBox_User.Location = new System.Drawing.Point(800, 4);
            this.picBox_User.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.picBox_User.Name = "picBox_User";
            this.picBox_User.Size = new System.Drawing.Size(32, 32);
            this.picBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBox_User.TabIndex = 3;
            this.picBox_User.TabStop = false;
            // 
            // panel_empInfo
            // 
            this.panel_empInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_empInfo.Controls.Add(this.comboBox_role);
            this.panel_empInfo.Controls.Add(this.lbl_role);
            this.panel_empInfo.Controls.Add(this.rdbtn_sexFemale);
            this.panel_empInfo.Controls.Add(this.rdbtn_sexMale);
            this.panel_empInfo.Controls.Add(this.lbl_sex);
            this.panel_empInfo.Controls.Add(this.lbl_bdate);
            this.panel_empInfo.Controls.Add(this.dtp_Birthdate);
            this.panel_empInfo.Controls.Add(this.tbox_mobileNum);
            this.panel_empInfo.Controls.Add(this.tbox_address);
            this.panel_empInfo.Controls.Add(this.lbl_contactNum);
            this.panel_empInfo.Controls.Add(this.lbl_address);
            this.panel_empInfo.Controls.Add(this.tbox_lastName);
            this.panel_empInfo.Controls.Add(this.lbl_lastName);
            this.panel_empInfo.Controls.Add(this.tbox_middleName);
            this.panel_empInfo.Controls.Add(this.lbl_midName);
            this.panel_empInfo.Controls.Add(this.tbox_firstName);
            this.panel_empInfo.Controls.Add(this.lbl_firstName);
            this.panel_empInfo.Location = new System.Drawing.Point(10, 55);
            this.panel_empInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_empInfo.Name = "panel_empInfo";
            this.panel_empInfo.Size = new System.Drawing.Size(306, 561);
            this.panel_empInfo.TabIndex = 2;
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(18, 507);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(273, 28);
            this.comboBox_role.TabIndex = 16;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(14, 484);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(39, 20);
            this.lbl_role.TabIndex = 15;
            this.lbl_role.Text = "Role";
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
            // lbl_sex
            // 
            this.lbl_sex.AutoSize = true;
            this.lbl_sex.Location = new System.Drawing.Point(14, 448);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(32, 20);
            this.lbl_sex.TabIndex = 12;
            this.lbl_sex.Text = "Sex";
            // 
            // lbl_bdate
            // 
            this.lbl_bdate.AutoSize = true;
            this.lbl_bdate.Location = new System.Drawing.Point(13, 378);
            this.lbl_bdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bdate.Name = "lbl_bdate";
            this.lbl_bdate.Size = new System.Drawing.Size(70, 20);
            this.lbl_bdate.TabIndex = 11;
            this.lbl_bdate.Text = "Birthdate";
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
            // lbl_contactNum
            // 
            this.lbl_contactNum.AutoSize = true;
            this.lbl_contactNum.Location = new System.Drawing.Point(13, 315);
            this.lbl_contactNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contactNum.Name = "lbl_contactNum";
            this.lbl_contactNum.Size = new System.Drawing.Size(118, 20);
            this.lbl_contactNum.TabIndex = 4;
            this.lbl_contactNum.Text = "Contact Number";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(13, 207);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(62, 20);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Address";
            // 
            // tbox_lastName
            // 
            this.tbox_lastName.Location = new System.Drawing.Point(17, 166);
            this.tbox_lastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_lastName.Name = "tbox_lastName";
            this.tbox_lastName.Size = new System.Drawing.Size(276, 27);
            this.tbox_lastName.TabIndex = 7;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(14, 144);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(79, 20);
            this.lbl_lastName.TabIndex = 6;
            this.lbl_lastName.Text = "Last Name";
            // 
            // tbox_middleName
            // 
            this.tbox_middleName.Location = new System.Drawing.Point(16, 103);
            this.tbox_middleName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_middleName.Name = "tbox_middleName";
            this.tbox_middleName.Size = new System.Drawing.Size(276, 27);
            this.tbox_middleName.TabIndex = 5;
            // 
            // lbl_midName
            // 
            this.lbl_midName.AutoSize = true;
            this.lbl_midName.Location = new System.Drawing.Point(13, 80);
            this.lbl_midName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_midName.Name = "lbl_midName";
            this.lbl_midName.Size = new System.Drawing.Size(100, 20);
            this.lbl_midName.TabIndex = 4;
            this.lbl_midName.Text = "Middle Name";
            // 
            // tbox_firstName
            // 
            this.tbox_firstName.Location = new System.Drawing.Point(16, 41);
            this.tbox_firstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_firstName.Name = "tbox_firstName";
            this.tbox_firstName.Size = new System.Drawing.Size(276, 27);
            this.tbox_firstName.TabIndex = 3;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(13, 19);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(80, 20);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "First Name";
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
            this.listview_Emp.Size = new System.Drawing.Size(773, 569);
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
            this.btn_Info.Location = new System.Drawing.Point(11, 662);
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
            this.Controls.Add(this.panel_empInfo);
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
            this.panel_empInfo.ResumeLayout(false);
            this.panel_empInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.PictureBox picBox_User;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel_empInfo;
        private System.Windows.Forms.TextBox tbox_mobileNum;
        private System.Windows.Forms.TextBox tbox_address;
        private System.Windows.Forms.Label lbl_contactNum;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox tbox_lastName;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.TextBox tbox_middleName;
        private System.Windows.Forms.Label lbl_midName;
        private System.Windows.Forms.TextBox tbox_firstName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lbl_bdate;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.RadioButton rdbtn_sexFemale;
        private System.Windows.Forms.RadioButton rdbtn_sexMale;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ListView listview_Emp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}