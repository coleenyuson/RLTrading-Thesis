﻿namespace Thesis_Rillan_Trading
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
            this.components = new System.ComponentModel.Container();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel_empInfo = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBox_Branch = new System.Windows.Forms.ComboBox();
            this.lbl_Branch = new System.Windows.Forms.Label();
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGV_Emp = new System.Windows.Forms.DataGridView();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.pnl_Footer = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DateTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_empInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Emp)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.pnl_Footer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.ForeColor = System.Drawing.Color.SteelBlue;
            this.btn_Back.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Back_32px_3;
            this.btn_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Back.Location = new System.Drawing.Point(12, 2);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 44);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "BACK";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel_empInfo
            // 
            this.panel_empInfo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_empInfo.Controls.Add(this.label5);
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
            this.panel_empInfo.Location = new System.Drawing.Point(10, 105);
            this.panel_empInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_empInfo.Name = "panel_empInfo";
            this.panel_empInfo.Size = new System.Drawing.Size(312, 586);
            this.panel_empInfo.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(493, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(101, 24);
            this.radioButton1.TabIndex = 21;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Deactivate";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(493, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 24);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Active";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Status";
            // 
            // cmbBox_Branch
            // 
            this.cmbBox_Branch.FormattingEnabled = true;
            this.cmbBox_Branch.Location = new System.Drawing.Point(103, 70);
            this.cmbBox_Branch.Name = "cmbBox_Branch";
            this.cmbBox_Branch.Size = new System.Drawing.Size(273, 28);
            this.cmbBox_Branch.TabIndex = 18;
            // 
            // lbl_Branch
            // 
            this.lbl_Branch.AutoSize = true;
            this.lbl_Branch.Location = new System.Drawing.Point(47, 78);
            this.lbl_Branch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Branch.Name = "lbl_Branch";
            this.lbl_Branch.Size = new System.Drawing.Size(54, 20);
            this.lbl_Branch.TabIndex = 17;
            this.lbl_Branch.Text = "Branch";
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Location = new System.Drawing.Point(103, 33);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(273, 28);
            this.comboBox_role.TabIndex = 16;
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(47, 36);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(39, 20);
            this.lbl_role.TabIndex = 15;
            this.lbl_role.Text = "Role";
            // 
            // rdbtn_sexFemale
            // 
            this.rdbtn_sexFemale.AutoSize = true;
            this.rdbtn_sexFemale.Location = new System.Drawing.Point(183, 536);
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
            this.rdbtn_sexMale.Location = new System.Drawing.Point(95, 536);
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
            this.lbl_sex.Location = new System.Drawing.Point(18, 536);
            this.lbl_sex.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sex.Name = "lbl_sex";
            this.lbl_sex.Size = new System.Drawing.Size(32, 20);
            this.lbl_sex.TabIndex = 12;
            this.lbl_sex.Text = "Sex";
            // 
            // lbl_bdate
            // 
            this.lbl_bdate.AutoSize = true;
            this.lbl_bdate.Location = new System.Drawing.Point(12, 464);
            this.lbl_bdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_bdate.Name = "lbl_bdate";
            this.lbl_bdate.Size = new System.Drawing.Size(70, 20);
            this.lbl_bdate.TabIndex = 11;
            this.lbl_bdate.Text = "Birthdate";
            // 
            // dtp_Birthdate
            // 
            this.dtp_Birthdate.Location = new System.Drawing.Point(16, 486);
            this.dtp_Birthdate.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_Birthdate.Name = "dtp_Birthdate";
            this.dtp_Birthdate.Size = new System.Drawing.Size(274, 27);
            this.dtp_Birthdate.TabIndex = 10;
            this.dtp_Birthdate.Value = new System.DateTime(2018, 4, 22, 14, 48, 30, 0);
            // 
            // tbox_mobileNum
            // 
            this.tbox_mobileNum.Location = new System.Drawing.Point(14, 423);
            this.tbox_mobileNum.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_mobileNum.Name = "tbox_mobileNum";
            this.tbox_mobileNum.Size = new System.Drawing.Size(276, 27);
            this.tbox_mobileNum.TabIndex = 5;
            // 
            // tbox_address
            // 
            this.tbox_address.Location = new System.Drawing.Point(17, 301);
            this.tbox_address.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_address.Multiline = true;
            this.tbox_address.Name = "tbox_address";
            this.tbox_address.Size = new System.Drawing.Size(275, 72);
            this.tbox_address.TabIndex = 9;
            // 
            // lbl_contactNum
            // 
            this.lbl_contactNum.AutoSize = true;
            this.lbl_contactNum.Location = new System.Drawing.Point(10, 401);
            this.lbl_contactNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contactNum.Name = "lbl_contactNum";
            this.lbl_contactNum.Size = new System.Drawing.Size(118, 20);
            this.lbl_contactNum.TabIndex = 4;
            this.lbl_contactNum.Text = "Contact Number";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(12, 279);
            this.lbl_address.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(62, 20);
            this.lbl_address.TabIndex = 8;
            this.lbl_address.Text = "Address";
            // 
            // tbox_lastName
            // 
            this.tbox_lastName.Location = new System.Drawing.Point(17, 227);
            this.tbox_lastName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_lastName.Name = "tbox_lastName";
            this.tbox_lastName.Size = new System.Drawing.Size(276, 27);
            this.tbox_lastName.TabIndex = 7;
            this.tbox_lastName.TextChanged += new System.EventHandler(this.tbox_lastName_TextChanged);
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.Location = new System.Drawing.Point(14, 205);
            this.lbl_lastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(79, 20);
            this.lbl_lastName.TabIndex = 6;
            this.lbl_lastName.Text = "Last Name";
            this.lbl_lastName.Click += new System.EventHandler(this.lbl_lastName_Click);
            // 
            // tbox_middleName
            // 
            this.tbox_middleName.Location = new System.Drawing.Point(18, 164);
            this.tbox_middleName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_middleName.Name = "tbox_middleName";
            this.tbox_middleName.Size = new System.Drawing.Size(276, 27);
            this.tbox_middleName.TabIndex = 5;
            // 
            // lbl_midName
            // 
            this.lbl_midName.AutoSize = true;
            this.lbl_midName.Location = new System.Drawing.Point(15, 141);
            this.lbl_midName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_midName.Name = "lbl_midName";
            this.lbl_midName.Size = new System.Drawing.Size(100, 20);
            this.lbl_midName.TabIndex = 4;
            this.lbl_midName.Text = "Middle Name";
            // 
            // tbox_firstName
            // 
            this.tbox_firstName.Location = new System.Drawing.Point(18, 90);
            this.tbox_firstName.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_firstName.Name = "tbox_firstName";
            this.tbox_firstName.Size = new System.Drawing.Size(276, 27);
            this.tbox_firstName.TabIndex = 3;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.Location = new System.Drawing.Point(15, 68);
            this.lbl_firstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(80, 20);
            this.lbl_firstName.TabIndex = 2;
            this.lbl_firstName.Text = "First Name";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(10, 695);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(154, 38);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.textBox8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox8.Location = new System.Drawing.Point(708, 71);
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
            this.comboBox2.Location = new System.Drawing.Point(929, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 28);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Filter By";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Search_32px;
            this.pictureBox1.Location = new System.Drawing.Point(671, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("LuloCleanW01-One", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(168, 695);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(154, 38);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LuloCleanW01-OneBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "EMPLOYEE MANAGEMENT SETTINGS";
            // 
            // dataGV_Emp
            // 
            this.dataGV_Emp.AllowUserToAddRows = false;
            this.dataGV_Emp.AllowUserToDeleteRows = false;
            this.dataGV_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_Emp.Location = new System.Drawing.Point(327, 105);
            this.dataGV_Emp.Name = "dataGV_Emp";
            this.dataGV_Emp.ReadOnly = true;
            this.dataGV_Emp.RowTemplate.Height = 24;
            this.dataGV_Emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGV_Emp.Size = new System.Drawing.Size(768, 470);
            this.dataGV_Emp.TabIndex = 22;
            this.dataGV_Emp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_Emp_CellContentClick);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Header.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Header.Controls.Add(this.btn_Back);
            this.pnl_Header.Controls.Add(this.btn_Logout);
            this.pnl_Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnl_Header.Location = new System.Drawing.Point(-2, -2);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1112, 50);
            this.pnl_Header.TabIndex = 23;
            // 
            // btn_Logout
            // 
            this.btn_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logout.Image = global::Thesis_Rillan_Trading.Properties.Resources.icons8_Exit_32px;
            this.btn_Logout.Location = new System.Drawing.Point(1056, 4);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(40, 40);
            this.btn_Logout.TabIndex = 3;
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click_1);
            // 
            // pnl_Footer
            // 
            this.pnl_Footer.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Footer.Controls.Add(this.label3);
            this.pnl_Footer.Controls.Add(this.label1);
            this.pnl_Footer.Controls.Add(this.lbl_DateTime);
            this.pnl_Footer.Location = new System.Drawing.Point(-2, 747);
            this.pnl_Footer.Name = "pnl_Footer";
            this.pnl_Footer.Size = new System.Drawing.Size(1112, 30);
            this.pnl_Footer.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(73, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jane Doe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // lbl_DateTime
            // 
            this.lbl_DateTime.AutoSize = true;
            this.lbl_DateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_DateTime.Location = new System.Drawing.Point(938, 7);
            this.lbl_DateTime.Name = "lbl_DateTime";
            this.lbl_DateTime.Size = new System.Drawing.Size(158, 20);
            this.lbl_DateTime.TabIndex = 3;
            this.lbl_DateTime.Text = "hh:mm January 1, 2018";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.lbl_role);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox_role);
            this.panel1.Controls.Add(this.lbl_Branch);
            this.panel1.Controls.Add(this.cmbBox_Branch);
            this.panel1.Location = new System.Drawing.Point(327, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 110);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Employee Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LuloCleanW01-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "USER SETTINGS";
            // 
            // formEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Footer);
            this.Controls.Add(this.pnl_Header);
            this.Controls.Add(this.dataGV_Emp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.panel_empInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEmployee";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rillan Trading - Employee";
            this.Load += new System.EventHandler(this.formEmployee_Load);
            this.panel_empInfo.ResumeLayout(false);
            this.panel_empInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_Emp)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Footer.ResumeLayout(false);
            this.pnl_Footer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lbl_bdate;
        private System.Windows.Forms.DateTimePicker dtp_Birthdate;
        private System.Windows.Forms.RadioButton rdbtn_sexFemale;
        private System.Windows.Forms.RadioButton rdbtn_sexMale;
        private System.Windows.Forms.Label lbl_sex;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGV_Emp;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Panel pnl_Footer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DateTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBox_Branch;
        private System.Windows.Forms.Label lbl_Branch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}