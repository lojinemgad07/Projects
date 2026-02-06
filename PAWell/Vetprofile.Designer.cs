using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBaseProjectPawell
{
    partial class Vetprofile
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Schedule = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.backpanel = new Guna.UI2.WinForms.Guna2Panel();
            this.profilepanel = new Guna.UI2.WinForms.Guna2Panel();
            this.name = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addresspanel = new Guna.UI2.WinForms.Guna2Panel();
            this.zipcode = new System.Windows.Forms.TextBox();
            this.Gover = new System.Windows.Forms.TextBox();
            this.building = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.TextBox();
            this.apartment = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.jobinfopanel = new Guna.UI2.WinForms.Guna2Panel();
            this.spview = new System.Windows.Forms.DataGridView();
            this.degview = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.Label();
            this.personalinfopanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.backpanel.SuspendLayout();
            this.profilepanel.SuspendLayout();
            this.addresspanel.SuspendLayout();
            this.jobinfopanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degview)).BeginInit();
            this.personalinfopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.guna2Panel1.Controls.Add(this.Schedule);
            this.guna2Panel1.Controls.Add(this.profile);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(204, 528);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Schedule
            // 
            this.Schedule.BackColor = System.Drawing.Color.SlateGray;
            this.Schedule.Location = new System.Drawing.Point(33, 78);
            this.Schedule.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Schedule.Name = "Schedule";
            this.Schedule.Size = new System.Drawing.Size(135, 23);
            this.Schedule.TabIndex = 1;
            this.Schedule.Text = "Schedule";
            this.Schedule.UseVisualStyleBackColor = false;
            this.Schedule.Click += new System.EventHandler(this.Schedule_Click_1);
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.SlateGray;
            this.profile.Location = new System.Drawing.Point(33, 40);
            this.profile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(135, 23);
            this.profile.TabIndex = 0;
            this.profile.Text = "Profile";
            this.profile.UseVisualStyleBackColor = false;
            // 
            // backpanel
            // 
            this.backpanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.backpanel.Controls.Add(this.profilepanel);
            this.backpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backpanel.Location = new System.Drawing.Point(204, 0);
            this.backpanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backpanel.Name = "backpanel";
            this.backpanel.Size = new System.Drawing.Size(980, 528);
            this.backpanel.TabIndex = 1;
            // 
            // profilepanel
            // 
            this.profilepanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilepanel.BackColor = System.Drawing.SystemColors.Control;
            this.profilepanel.Controls.Add(this.name);
            this.profilepanel.Controls.Add(this.button3);
            this.profilepanel.Controls.Add(this.button2);
            this.profilepanel.Controls.Add(this.button1);
            this.profilepanel.Controls.Add(this.addresspanel);
            this.profilepanel.Controls.Add(this.jobinfopanel);
            this.profilepanel.Controls.Add(this.personalinfopanel);
            this.profilepanel.Location = new System.Drawing.Point(-40, -2);
            this.profilepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilepanel.Name = "profilepanel";
            this.profilepanel.Size = new System.Drawing.Size(1061, 532);
            this.profilepanel.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.name.Location = new System.Drawing.Point(55, 15);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(150, 32);
            this.name.TabIndex = 6;
            this.name.Text = "Welcome Dr.";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(889, 487);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(916, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Edit Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // addresspanel
            // 
            this.addresspanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.addresspanel.Controls.Add(this.zipcode);
            this.addresspanel.Controls.Add(this.Gover);
            this.addresspanel.Controls.Add(this.building);
            this.addresspanel.Controls.Add(this.street);
            this.addresspanel.Controls.Add(this.apartment);
            this.addresspanel.Controls.Add(this.city);
            this.addresspanel.Controls.Add(this.label18);
            this.addresspanel.Controls.Add(this.label17);
            this.addresspanel.Controls.Add(this.label16);
            this.addresspanel.Controls.Add(this.label15);
            this.addresspanel.Controls.Add(this.label14);
            this.addresspanel.Controls.Add(this.label13);
            this.addresspanel.Controls.Add(this.label5);
            this.addresspanel.Location = new System.Drawing.Point(66, 196);
            this.addresspanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addresspanel.Name = "addresspanel";
            this.addresspanel.Size = new System.Drawing.Size(806, 146);
            this.addresspanel.TabIndex = 1;
            // 
            // zipcode
            // 
            this.zipcode.Location = new System.Drawing.Point(533, 96);
            this.zipcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(125, 22);
            this.zipcode.TabIndex = 70;
            // 
            // Gover
            // 
            this.Gover.Location = new System.Drawing.Point(214, 34);
            this.Gover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Gover.Name = "Gover";
            this.Gover.Size = new System.Drawing.Size(125, 22);
            this.Gover.TabIndex = 69;
            // 
            // building
            // 
            this.building.Location = new System.Drawing.Point(533, 64);
            this.building.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.building.Name = "building";
            this.building.Size = new System.Drawing.Size(125, 22);
            this.building.TabIndex = 68;
            // 
            // street
            // 
            this.street.Location = new System.Drawing.Point(214, 60);
            this.street.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(125, 22);
            this.street.TabIndex = 67;
            // 
            // apartment
            // 
            this.apartment.Location = new System.Drawing.Point(214, 93);
            this.apartment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apartment.Name = "apartment";
            this.apartment.Size = new System.Drawing.Size(125, 22);
            this.apartment.TabIndex = 66;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(533, 34);
            this.city.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(125, 22);
            this.city.TabIndex = 65;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(419, 96);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 16);
            this.label18.TabIndex = 64;
            this.label18.Text = "ZIP Code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(431, 38);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 16);
            this.label17.TabIndex = 63;
            this.label17.Text = "City";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(88, 62);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 16);
            this.label16.TabIndex = 62;
            this.label16.Text = "Street";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(419, 64);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 16);
            this.label15.TabIndex = 61;
            this.label15.Text = "Building";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(72, 93);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 60;
            this.label14.Text = "Apartment";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 34);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 59;
            this.label13.Text = "Governorate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label5.Location = new System.Drawing.Point(9, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            // 
            // jobinfopanel
            // 
            this.jobinfopanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.jobinfopanel.Controls.Add(this.spview);
            this.jobinfopanel.Controls.Add(this.degview);
            this.jobinfopanel.Controls.Add(this.label6);
            this.jobinfopanel.Controls.Add(this.startdate);
            this.jobinfopanel.Controls.Add(this.bank);
            this.jobinfopanel.Location = new System.Drawing.Point(66, 354);
            this.jobinfopanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.jobinfopanel.Name = "jobinfopanel";
            this.jobinfopanel.Size = new System.Drawing.Size(806, 156);
            this.jobinfopanel.TabIndex = 1;
            // 
            // spview
            // 
            this.spview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.spview.Location = new System.Drawing.Point(545, 40);
            this.spview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spview.Name = "spview";
            this.spview.RowHeadersWidth = 82;
            this.spview.Size = new System.Drawing.Size(198, 91);
            this.spview.TabIndex = 10;
            // 
            // degview
            // 
            this.degview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.degview.Location = new System.Drawing.Point(177, 40);
            this.degview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.degview.Name = "degview";
            this.degview.RowHeadersWidth = 82;
            this.degview.Size = new System.Drawing.Size(183, 91);
            this.degview.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label6.Location = new System.Drawing.Point(9, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Degree and Specialization";
            // 
            // startdate
            // 
            this.startdate.AutoSize = true;
            this.startdate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.startdate.Location = new System.Drawing.Point(96, 40);
            this.startdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(79, 23);
            this.startdate.TabIndex = 7;
            this.startdate.Text = "Degree 1";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bank.Location = new System.Drawing.Point(401, 46);
            this.bank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(128, 23);
            this.bank.TabIndex = 8;
            this.bank.Text = "Specialization 1";
            // 
            // personalinfopanel
            // 
            this.personalinfopanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.personalinfopanel.Controls.Add(this.lname);
            this.personalinfopanel.Controls.Add(this.fname);
            this.personalinfopanel.Controls.Add(this.username);
            this.personalinfopanel.Controls.Add(this.label4);
            this.personalinfopanel.Controls.Add(this.label3);
            this.personalinfopanel.Controls.Add(this.label2);
            this.personalinfopanel.Controls.Add(this.label1);
            this.personalinfopanel.Location = new System.Drawing.Point(66, 57);
            this.personalinfopanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.personalinfopanel.Name = "personalinfopanel";
            this.personalinfopanel.Size = new System.Drawing.Size(806, 125);
            this.personalinfopanel.TabIndex = 0;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(214, 84);
            this.lname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(284, 22);
            this.lname.TabIndex = 6;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(214, 62);
            this.fname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(284, 22);
            this.fname.TabIndex = 5;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(214, 33);
            this.username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(284, 22);
            this.username.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(62, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(62, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(2, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // Vetprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 528);
            this.Controls.Add(this.backpanel);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Vetprofile";
            this.Text = "Vetprofile";
            this.guna2Panel1.ResumeLayout(false);
            this.backpanel.ResumeLayout(false);
            this.profilepanel.ResumeLayout(false);
            this.profilepanel.PerformLayout();
            this.addresspanel.ResumeLayout(false);
            this.addresspanel.PerformLayout();
            this.jobinfopanel.ResumeLayout(false);
            this.jobinfopanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degview)).EndInit();
            this.personalinfopanel.ResumeLayout(false);
            this.personalinfopanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Button Schedule;
        private Button profile;
        private Guna.UI2.WinForms.Guna2Panel backpanel;
        private Guna.UI2.WinForms.Guna2Panel profilepanel;
        private Guna.UI2.WinForms.Guna2Panel personalinfopanel;
        private Guna.UI2.WinForms.Guna2Panel jobinfopanel;
        private Guna.UI2.WinForms.Guna2Panel addresspanel;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox lname;
        private TextBox fname;
        private TextBox username;
        private Label label5;
        private Label startdate;
        private Label bank;
        private Label label6;
        private TextBox zipcode;
        private TextBox Gover;
        private TextBox building;
        private TextBox street;
        private TextBox apartment;
        private TextBox city;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private Label name;
        private DataGridView spview;
        private DataGridView degview;
    }
}