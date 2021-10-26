
namespace Loan.FORMS
{
    partial class Frm_Employee
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
            this.Btn_Exit = new FontAwesome.Sharp.IconButton();
            this.panel_Content = new System.Windows.Forms.Panel();
            this.DGV_DATAEMP = new System.Windows.Forms.DataGridView();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.CLEAR = new FontAwesome.Sharp.IconButton();
            this.iconButton8 = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TXT_NO = new System.Windows.Forms.TextBox();
            this.gender = new FontAwesome.Sharp.IconButton();
            this.RadioFemale = new System.Windows.Forms.RadioButton();
            this.RadioMale = new System.Windows.Forms.RadioButton();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.panel7 = new System.Windows.Forms.Panel();
            this.iconButton7 = new FontAwesome.Sharp.IconButton();
            this.TXT_EMAIL = new System.Windows.Forms.TextBox();
            this.DELETE = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.EDIT = new FontAwesome.Sharp.IconButton();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.SAVE = new FontAwesome.Sharp.IconButton();
            this.TXT_ADDRESS = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.TXT_PHONE = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.TXT_NAMEEN = new System.Windows.Forms.TextBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TXT_NAMEKH = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel_Content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATAEMP)).BeginInit();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.FlatAppearance.BorderSize = 0;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.Btn_Exit.ForeColor = System.Drawing.Color.MistyRose;
            this.Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.Btn_Exit.IconColor = System.Drawing.Color.LightCoral;
            this.Btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Exit.IconSize = 30;
            this.Btn_Exit.Location = new System.Drawing.Point(557, 3);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(35, 35);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // panel_Content
            // 
            this.panel_Content.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel_Content.Controls.Add(this.DGV_DATAEMP);
            this.panel_Content.Controls.Add(this.Btn_Exit);
            this.panel_Content.Location = new System.Drawing.Point(346, 0);
            this.panel_Content.Name = "panel_Content";
            this.panel_Content.Size = new System.Drawing.Size(604, 565);
            this.panel_Content.TabIndex = 8;
            // 
            // DGV_DATAEMP
            // 
            this.DGV_DATAEMP.AllowUserToAddRows = false;
            this.DGV_DATAEMP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DATAEMP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_DATAEMP.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DGV_DATAEMP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_DATAEMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DATAEMP.Location = new System.Drawing.Point(2, 63);
            this.DGV_DATAEMP.Name = "DGV_DATAEMP";
            this.DGV_DATAEMP.RowHeadersVisible = false;
            this.DGV_DATAEMP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_DATAEMP.Size = new System.Drawing.Size(590, 490);
            this.DGV_DATAEMP.TabIndex = 7;
            this.DGV_DATAEMP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_DATAEMP_CellContentClick);
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel_Left.Controls.Add(this.CLEAR);
            this.panel_Left.Controls.Add(this.iconButton8);
            this.panel_Left.Controls.Add(this.panel5);
            this.panel_Left.Controls.Add(this.TXT_NO);
            this.panel_Left.Controls.Add(this.gender);
            this.panel_Left.Controls.Add(this.RadioFemale);
            this.panel_Left.Controls.Add(this.RadioMale);
            this.panel_Left.Controls.Add(this.dob);
            this.panel_Left.Controls.Add(this.panel7);
            this.panel_Left.Controls.Add(this.iconButton7);
            this.panel_Left.Controls.Add(this.TXT_EMAIL);
            this.panel_Left.Controls.Add(this.DELETE);
            this.panel_Left.Controls.Add(this.panel6);
            this.panel_Left.Controls.Add(this.EDIT);
            this.panel_Left.Controls.Add(this.iconButton6);
            this.panel_Left.Controls.Add(this.SAVE);
            this.panel_Left.Controls.Add(this.TXT_ADDRESS);
            this.panel_Left.Controls.Add(this.panel2);
            this.panel_Left.Controls.Add(this.iconButton5);
            this.panel_Left.Controls.Add(this.TXT_PHONE);
            this.panel_Left.Controls.Add(this.panel1);
            this.panel_Left.Controls.Add(this.iconButton3);
            this.panel_Left.Controls.Add(this.TXT_NAMEEN);
            this.panel_Left.Controls.Add(this.iconButton4);
            this.panel_Left.Controls.Add(this.panel3);
            this.panel_Left.Controls.Add(this.panel4);
            this.panel_Left.Controls.Add(this.TXT_NAMEKH);
            this.panel_Left.Controls.Add(this.iconButton1);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(346, 565);
            this.panel_Left.TabIndex = 7;
            // 
            // CLEAR
            // 
            this.CLEAR.FlatAppearance.BorderSize = 0;
            this.CLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLEAR.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.CLEAR.ForeColor = System.Drawing.Color.LightCoral;
            this.CLEAR.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.CLEAR.IconColor = System.Drawing.Color.DarkSalmon;
            this.CLEAR.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CLEAR.IconSize = 30;
            this.CLEAR.Location = new System.Drawing.Point(181, 527);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(159, 35);
            this.CLEAR.TabIndex = 44;
            this.CLEAR.Text = "សំអាត | CLEAR";
            this.CLEAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // iconButton8
            // 
            this.iconButton8.FlatAppearance.BorderSize = 0;
            this.iconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton8.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton8.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconButton8.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton8.IconSize = 30;
            this.iconButton8.Location = new System.Drawing.Point(3, 26);
            this.iconButton8.Name = "iconButton8";
            this.iconButton8.Size = new System.Drawing.Size(32, 35);
            this.iconButton8.TabIndex = 42;
            this.iconButton8.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.ForeColor = System.Drawing.Color.MistyRose;
            this.panel5.Location = new System.Drawing.Point(2, 60);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(343, 3);
            this.panel5.TabIndex = 41;
            // 
            // TXT_NO
            // 
            this.TXT_NO.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_NO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_NO.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.TXT_NO.ForeColor = System.Drawing.Color.Black;
            this.TXT_NO.Location = new System.Drawing.Point(41, 27);
            this.TXT_NO.Name = "TXT_NO";
            this.TXT_NO.Size = new System.Drawing.Size(299, 30);
            this.TXT_NO.TabIndex = 43;
            this.TXT_NO.TextChanged += new System.EventHandler(this.TXT_NO_TextChanged);
            // 
            // gender
            // 
            this.gender.FlatAppearance.BorderSize = 0;
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.gender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gender.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.gender.IconColor = System.Drawing.Color.WhiteSmoke;
            this.gender.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.gender.IconSize = 30;
            this.gender.Location = new System.Drawing.Point(-1, 187);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(83, 49);
            this.gender.TabIndex = 40;
            this.gender.Text = "ភេទ";
            this.gender.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.gender.UseVisualStyleBackColor = true;
            // 
            // RadioFemale
            // 
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.Location = new System.Drawing.Point(216, 195);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(50, 31);
            this.RadioFemale.TabIndex = 39;
            this.RadioFemale.TabStop = true;
            this.RadioFemale.Text = "ស្រី";
            this.RadioFemale.UseVisualStyleBackColor = true;
            // 
            // RadioMale
            // 
            this.RadioMale.AutoSize = true;
            this.RadioMale.Location = new System.Drawing.Point(92, 195);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(60, 31);
            this.RadioMale.TabIndex = 38;
            this.RadioMale.TabStop = true;
            this.RadioMale.Text = "ប្រុស";
            this.RadioMale.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(44, 250);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(296, 34);
            this.dob.TabIndex = 37;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel7.ForeColor = System.Drawing.Color.MistyRose;
            this.panel7.Location = new System.Drawing.Point(2, 405);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(343, 3);
            this.panel7.TabIndex = 35;
            // 
            // iconButton7
            // 
            this.iconButton7.FlatAppearance.BorderSize = 0;
            this.iconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton7.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton7.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.iconButton7.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton7.IconSize = 30;
            this.iconButton7.Location = new System.Drawing.Point(3, 371);
            this.iconButton7.Name = "iconButton7";
            this.iconButton7.Size = new System.Drawing.Size(32, 35);
            this.iconButton7.TabIndex = 36;
            this.iconButton7.UseVisualStyleBackColor = true;
            // 
            // TXT_EMAIL
            // 
            this.TXT_EMAIL.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_EMAIL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_EMAIL.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.TXT_EMAIL.ForeColor = System.Drawing.Color.Black;
            this.TXT_EMAIL.Location = new System.Drawing.Point(44, 372);
            this.TXT_EMAIL.Name = "TXT_EMAIL";
            this.TXT_EMAIL.Size = new System.Drawing.Size(299, 30);
            this.TXT_EMAIL.TabIndex = 34;
            // 
            // DELETE
            // 
            this.DELETE.FlatAppearance.BorderSize = 0;
            this.DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DELETE.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.DELETE.ForeColor = System.Drawing.Color.LightCoral;
            this.DELETE.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.DELETE.IconColor = System.Drawing.Color.DarkSalmon;
            this.DELETE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DELETE.IconSize = 30;
            this.DELETE.Location = new System.Drawing.Point(3, 530);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(159, 35);
            this.DELETE.TabIndex = 19;
            this.DELETE.Text = "លុប | DELETE";
            this.DELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.ForeColor = System.Drawing.Color.MistyRose;
            this.panel6.Location = new System.Drawing.Point(-1, 459);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(343, 3);
            this.panel6.TabIndex = 31;
            // 
            // EDIT
            // 
            this.EDIT.FlatAppearance.BorderSize = 0;
            this.EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EDIT.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.EDIT.ForeColor = System.Drawing.Color.LightCoral;
            this.EDIT.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.EDIT.IconColor = System.Drawing.Color.DarkSalmon;
            this.EDIT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EDIT.IconSize = 30;
            this.EDIT.Location = new System.Drawing.Point(183, 486);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(159, 35);
            this.EDIT.TabIndex = 18;
            this.EDIT.Text = "កែប្រែ | EDIT";
            this.EDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EDIT.UseVisualStyleBackColor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // iconButton6
            // 
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.iconButton6.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 30;
            this.iconButton6.Location = new System.Drawing.Point(0, 425);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(32, 35);
            this.iconButton6.TabIndex = 32;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // SAVE
            // 
            this.SAVE.FlatAppearance.BorderSize = 0;
            this.SAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAVE.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.SAVE.ForeColor = System.Drawing.Color.LightCoral;
            this.SAVE.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SAVE.IconColor = System.Drawing.Color.DarkSalmon;
            this.SAVE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SAVE.IconSize = 30;
            this.SAVE.Location = new System.Drawing.Point(2, 486);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(159, 35);
            this.SAVE.TabIndex = 17;
            this.SAVE.Text = "រក្សាទុក | SAVE";
            this.SAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // TXT_ADDRESS
            // 
            this.TXT_ADDRESS.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_ADDRESS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_ADDRESS.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.TXT_ADDRESS.ForeColor = System.Drawing.Color.Black;
            this.TXT_ADDRESS.Location = new System.Drawing.Point(41, 426);
            this.TXT_ADDRESS.Name = "TXT_ADDRESS";
            this.TXT_ADDRESS.Size = new System.Drawing.Size(299, 30);
            this.TXT_ADDRESS.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.ForeColor = System.Drawing.Color.MistyRose;
            this.panel2.Location = new System.Drawing.Point(2, 347);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 3);
            this.panel2.TabIndex = 28;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt;
            this.iconButton5.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.Location = new System.Drawing.Point(3, 313);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(32, 35);
            this.iconButton5.TabIndex = 29;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // TXT_PHONE
            // 
            this.TXT_PHONE.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_PHONE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_PHONE.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.TXT_PHONE.ForeColor = System.Drawing.Color.Black;
            this.TXT_PHONE.Location = new System.Drawing.Point(44, 314);
            this.TXT_PHONE.Name = "TXT_PHONE";
            this.TXT_PHONE.Size = new System.Drawing.Size(299, 30);
            this.TXT_PHONE.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.ForeColor = System.Drawing.Color.MistyRose;
            this.panel1.Location = new System.Drawing.Point(1, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 3);
            this.panel1.TabIndex = 24;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButton3.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(2, 253);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(32, 35);
            this.iconButton3.TabIndex = 25;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // TXT_NAMEEN
            // 
            this.TXT_NAMEEN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_NAMEEN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_NAMEEN.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.TXT_NAMEEN.ForeColor = System.Drawing.Color.Black;
            this.TXT_NAMEEN.Location = new System.Drawing.Point(41, 137);
            this.TXT_NAMEEN.Name = "TXT_NAMEEN";
            this.TXT_NAMEEN.Size = new System.Drawing.Size(299, 30);
            this.TXT_NAMEEN.TabIndex = 14;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton4.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(3, 85);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(32, 35);
            this.iconButton4.TabIndex = 16;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.ForeColor = System.Drawing.Color.MistyRose;
            this.panel3.Location = new System.Drawing.Point(2, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(343, 3);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.ForeColor = System.Drawing.Color.MistyRose;
            this.panel4.Location = new System.Drawing.Point(2, 171);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(343, 3);
            this.panel4.TabIndex = 18;
            // 
            // TXT_NAMEKH
            // 
            this.TXT_NAMEKH.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TXT_NAMEKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_NAMEKH.Font = new System.Drawing.Font("Khmer OS Siemreap", 12F);
            this.TXT_NAMEKH.ForeColor = System.Drawing.Color.Black;
            this.TXT_NAMEKH.Location = new System.Drawing.Point(41, 86);
            this.TXT_NAMEKH.Name = "TXT_NAMEKH";
            this.TXT_NAMEKH.Size = new System.Drawing.Size(299, 30);
            this.TXT_NAMEKH.TabIndex = 17;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Khmer OS Siemreap", 10F);
            this.iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(3, 137);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(32, 35);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // Frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 565);
            this.Controls.Add(this.panel_Content);
            this.Controls.Add(this.panel_Left);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Frm_Employee";
            this.Text = "Frm_Employee";
            this.Load += new System.EventHandler(this.Frm_Employee_Load);
            this.panel_Content.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DATAEMP)).EndInit();
            this.panel_Left.ResumeLayout(false);
            this.panel_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btn_Exit;
        private System.Windows.Forms.Panel panel_Content;
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.TextBox TXT_NAMEEN;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TXT_NAMEKH;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView DGV_DATAEMP;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.TextBox TXT_ADDRESS;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.TextBox TXT_PHONE;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton DELETE;
        private FontAwesome.Sharp.IconButton EDIT;
        private FontAwesome.Sharp.IconButton SAVE;
        private System.Windows.Forms.Panel panel7;
        private FontAwesome.Sharp.IconButton iconButton7;
        private System.Windows.Forms.TextBox TXT_EMAIL;
        private FontAwesome.Sharp.IconButton gender;
        private System.Windows.Forms.RadioButton RadioFemale;
        private System.Windows.Forms.RadioButton RadioMale;
        private System.Windows.Forms.DateTimePicker dob;
        private FontAwesome.Sharp.IconButton iconButton8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TXT_NO;
        private FontAwesome.Sharp.IconButton CLEAR;
    }
}