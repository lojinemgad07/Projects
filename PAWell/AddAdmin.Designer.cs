using System;
using System.Drawing;
using System.Windows.Forms;


namespace DataBaseProjectPawell
{
    partial class AddAdmin
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtlast = new System.Windows.Forms.TextBox();
            this.lbllast = new System.Windows.Forms.Label();
            this.txtfirst = new System.Windows.Forms.TextBox();
            this.lblfirst = new System.Windows.Forms.Label();
            this.lblssn = new System.Windows.Forms.Label();
            this.txtssn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.lblzip = new System.Windows.Forms.Label();
            this.txtapart = new System.Windows.Forms.TextBox();
            this.lblapart = new System.Windows.Forms.Label();
            this.txtbuilding = new System.Windows.Forms.TextBox();
            this.lblbuilding = new System.Windows.Forms.Label();
            this.txtstreet = new System.Windows.Forms.TextBox();
            this.lblstreet = new System.Windows.Forms.Label();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.lblcity = new System.Windows.Forms.Label();
            this.txtgov = new System.Windows.Forms.TextBox();
            this.lblgov = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtacc = new System.Windows.Forms.TextBox();
            this.lblacc = new System.Windows.Forms.Label();
            this.txtbank = new System.Windows.Forms.TextBox();
            this.lblbank = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.lblsalary = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Controls.Add(this.btnback);
            this.guna2Panel1.Location = new System.Drawing.Point(1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(172, 822);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Silver;
            this.btnback.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnback.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnback.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnback.FillColor = System.Drawing.Color.Silver;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.Location = new System.Drawing.Point(27, 58);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(115, 28);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "Back";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.txtemail);
            this.guna2Panel2.Controls.Add(this.lblemail);
            this.guna2Panel2.Controls.Add(this.txtphone);
            this.guna2Panel2.Controls.Add(this.lblphone);
            this.guna2Panel2.Controls.Add(this.txtlast);
            this.guna2Panel2.Controls.Add(this.lbllast);
            this.guna2Panel2.Controls.Add(this.txtfirst);
            this.guna2Panel2.Controls.Add(this.lblfirst);
            this.guna2Panel2.Controls.Add(this.lblssn);
            this.guna2Panel2.Controls.Add(this.txtssn);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Location = new System.Drawing.Point(225, 108);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(345, 362);
            this.guna2Panel2.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(154, 275);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(132, 22);
            this.txtemail.TabIndex = 10;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(85, 273);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(51, 23);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "Email";
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(154, 227);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(132, 22);
            this.txtphone.TabIndex = 8;
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(9, 225);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(127, 23);
            this.lblphone.TabIndex = 7;
            this.lblphone.Text = "Phone Number";
            // 
            // txtlast
            // 
            this.txtlast.Location = new System.Drawing.Point(154, 182);
            this.txtlast.Name = "txtlast";
            this.txtlast.Size = new System.Drawing.Size(132, 22);
            this.txtlast.TabIndex = 6;
            // 
            // lbllast
            // 
            this.lbllast.AutoSize = true;
            this.lbllast.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllast.Location = new System.Drawing.Point(44, 180);
            this.lbllast.Name = "lbllast";
            this.lbllast.Size = new System.Drawing.Size(91, 23);
            this.lbllast.TabIndex = 5;
            this.lbllast.Text = "Last Name";
            // 
            // txtfirst
            // 
            this.txtfirst.Location = new System.Drawing.Point(154, 134);
            this.txtfirst.Name = "txtfirst";
            this.txtfirst.Size = new System.Drawing.Size(132, 22);
            this.txtfirst.TabIndex = 4;
            // 
            // lblfirst
            // 
            this.lblfirst.AutoSize = true;
            this.lblfirst.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirst.Location = new System.Drawing.Point(44, 132);
            this.lblfirst.Name = "lblfirst";
            this.lblfirst.Size = new System.Drawing.Size(92, 23);
            this.lblfirst.TabIndex = 3;
            this.lblfirst.Text = "First Name";
            // 
            // lblssn
            // 
            this.lblssn.AutoSize = true;
            this.lblssn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblssn.Location = new System.Drawing.Point(94, 86);
            this.lblssn.Name = "lblssn";
            this.lblssn.Size = new System.Drawing.Size(41, 23);
            this.lblssn.TabIndex = 2;
            this.lblssn.Text = "SSN";
            // 
            // txtssn
            // 
            this.txtssn.Location = new System.Drawing.Point(154, 88);
            this.txtssn.Name = "txtssn";
            this.txtssn.Size = new System.Drawing.Size(132, 22);
            this.txtssn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal Information";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.txtzip);
            this.guna2Panel3.Controls.Add(this.lblzip);
            this.guna2Panel3.Controls.Add(this.txtapart);
            this.guna2Panel3.Controls.Add(this.lblapart);
            this.guna2Panel3.Controls.Add(this.txtbuilding);
            this.guna2Panel3.Controls.Add(this.lblbuilding);
            this.guna2Panel3.Controls.Add(this.txtstreet);
            this.guna2Panel3.Controls.Add(this.lblstreet);
            this.guna2Panel3.Controls.Add(this.txtcity);
            this.guna2Panel3.Controls.Add(this.lblcity);
            this.guna2Panel3.Controls.Add(this.txtgov);
            this.guna2Panel3.Controls.Add(this.lblgov);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Location = new System.Drawing.Point(645, 108);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(345, 362);
            this.guna2Panel3.TabIndex = 12;
            // 
            // txtzip
            // 
            this.txtzip.Location = new System.Drawing.Point(151, 293);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(165, 22);
            this.txtzip.TabIndex = 21;
            // 
            // lblzip
            // 
            this.lblzip.AutoSize = true;
            this.lblzip.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzip.Location = new System.Drawing.Point(44, 291);
            this.lblzip.Name = "lblzip";
            this.lblzip.Size = new System.Drawing.Size(80, 23);
            this.lblzip.TabIndex = 20;
            this.lblzip.Text = "ZIP Code";
            // 
            // txtapart
            // 
            this.txtapart.Location = new System.Drawing.Point(151, 246);
            this.txtapart.Name = "txtapart";
            this.txtapart.Size = new System.Drawing.Size(165, 22);
            this.txtapart.TabIndex = 19;
            // 
            // lblapart
            // 
            this.lblapart.AutoSize = true;
            this.lblapart.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblapart.Location = new System.Drawing.Point(22, 244);
            this.lblapart.Name = "lblapart";
            this.lblapart.Size = new System.Drawing.Size(102, 23);
            this.lblapart.TabIndex = 18;
            this.lblapart.Text = "Appartment";
            // 
            // txtbuilding
            // 
            this.txtbuilding.Location = new System.Drawing.Point(151, 198);
            this.txtbuilding.Name = "txtbuilding";
            this.txtbuilding.Size = new System.Drawing.Size(165, 22);
            this.txtbuilding.TabIndex = 17;
            // 
            // lblbuilding
            // 
            this.lblbuilding.AutoSize = true;
            this.lblbuilding.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuilding.Location = new System.Drawing.Point(52, 196);
            this.lblbuilding.Name = "lblbuilding";
            this.lblbuilding.Size = new System.Drawing.Size(72, 23);
            this.lblbuilding.TabIndex = 16;
            this.lblbuilding.Text = "Building";
            // 
            // txtstreet
            // 
            this.txtstreet.Location = new System.Drawing.Point(151, 149);
            this.txtstreet.Name = "txtstreet";
            this.txtstreet.Size = new System.Drawing.Size(165, 22);
            this.txtstreet.TabIndex = 15;
            // 
            // lblstreet
            // 
            this.lblstreet.AutoSize = true;
            this.lblstreet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstreet.Location = new System.Drawing.Point(70, 147);
            this.lblstreet.Name = "lblstreet";
            this.lblstreet.Size = new System.Drawing.Size(54, 23);
            this.lblstreet.TabIndex = 14;
            this.lblstreet.Text = "Street";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(151, 105);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(165, 22);
            this.txtcity.TabIndex = 13;
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(85, 103);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(39, 23);
            this.lblcity.TabIndex = 12;
            this.lblcity.Text = "City";
            // 
            // txtgov
            // 
            this.txtgov.Location = new System.Drawing.Point(151, 66);
            this.txtgov.Name = "txtgov";
            this.txtgov.Size = new System.Drawing.Size(165, 22);
            this.txtgov.TabIndex = 11;
            // 
            // lblgov
            // 
            this.lblgov.AutoSize = true;
            this.lblgov.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgov.Location = new System.Drawing.Point(19, 64);
            this.lblgov.Name = "lblgov";
            this.lblgov.Size = new System.Drawing.Size(105, 23);
            this.lblgov.TabIndex = 11;
            this.lblgov.Text = "Governorate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.White;
            this.guna2Panel4.Controls.Add(this.dtp1);
            this.guna2Panel4.Controls.Add(this.txtacc);
            this.guna2Panel4.Controls.Add(this.lblacc);
            this.guna2Panel4.Controls.Add(this.txtbank);
            this.guna2Panel4.Controls.Add(this.lblbank);
            this.guna2Panel4.Controls.Add(this.lbldate);
            this.guna2Panel4.Controls.Add(this.txtsalary);
            this.guna2Panel4.Controls.Add(this.lblsalary);
            this.guna2Panel4.Controls.Add(this.label3);
            this.guna2Panel4.Location = new System.Drawing.Point(225, 502);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(345, 298);
            this.guna2Panel4.TabIndex = 13;
            // 
            // txtacc
            // 
            this.txtacc.Location = new System.Drawing.Point(165, 236);
            this.txtacc.Name = "txtacc";
            this.txtacc.Size = new System.Drawing.Size(132, 22);
            this.txtacc.TabIndex = 28;
            // 
            // lblacc
            // 
            this.lblacc.AutoSize = true;
            this.lblacc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblacc.Location = new System.Drawing.Point(18, 234);
            this.lblacc.Name = "lblacc";
            this.lblacc.Size = new System.Drawing.Size(141, 23);
            this.lblacc.TabIndex = 27;
            this.lblacc.Text = "Account Number";
            // 
            // txtbank
            // 
            this.txtbank.Location = new System.Drawing.Point(154, 179);
            this.txtbank.Name = "txtbank";
            this.txtbank.Size = new System.Drawing.Size(132, 22);
            this.txtbank.TabIndex = 26;
            // 
            // lblbank
            // 
            this.lblbank.AutoSize = true;
            this.lblbank.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbank.Location = new System.Drawing.Point(89, 177);
            this.lblbank.Name = "lblbank";
            this.lblbank.Size = new System.Drawing.Size(47, 23);
            this.lblbank.TabIndex = 25;
            this.lblbank.Text = "Bank";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(50, 129);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(86, 23);
            this.lbldate.TabIndex = 23;
            this.lbldate.Text = "Start Date";
            // 
            // txtsalary
            // 
            this.txtsalary.Location = new System.Drawing.Point(165, 79);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(132, 22);
            this.txtsalary.TabIndex = 11;
            // 
            // lblsalary
            // 
            this.lblsalary.AutoSize = true;
            this.lblsalary.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalary.Location = new System.Drawing.Point(80, 79);
            this.lblsalary.Name = "lblsalary";
            this.lblsalary.Size = new System.Drawing.Size(55, 23);
            this.lblsalary.TabIndex = 11;
            this.lblsalary.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 22;
            this.label3.Text = "Employee Information";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.White;
            this.guna2Panel5.Controls.Add(this.txtpass);
            this.guna2Panel5.Controls.Add(this.lblpass);
            this.guna2Panel5.Controls.Add(this.txtusername);
            this.guna2Panel5.Controls.Add(this.lblusername);
            this.guna2Panel5.Controls.Add(this.label4);
            this.guna2Panel5.Location = new System.Drawing.Point(645, 502);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(345, 222);
            this.guna2Panel5.TabIndex = 30;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(151, 145);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(165, 22);
            this.txtpass.TabIndex = 31;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(44, 143);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(80, 23);
            this.lblpass.TabIndex = 30;
            this.lblpass.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(151, 81);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(165, 22);
            this.txtusername.TabIndex = 22;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(37, 79);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(87, 23);
            this.lblusername.TabIndex = 29;
            this.lblusername.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Account Information";
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(165, 130);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(132, 22);
            this.dtp1.TabIndex = 29;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Silver;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.Silver;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(909, 26);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(125, 40);
            this.btnadd.TabIndex = 36;
            this.btnadd.Text = "Add";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Location = new System.Drawing.Point(218, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 41);
            this.label5.TabIndex = 37;
            this.label5.Text = "Add Admin";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 819);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtlast;
        private System.Windows.Forms.Label lbllast;
        private System.Windows.Forms.TextBox txtfirst;
        private System.Windows.Forms.Label lblfirst;
        private System.Windows.Forms.Label lblssn;
        private System.Windows.Forms.TextBox txtssn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.Label lblzip;
        private System.Windows.Forms.TextBox txtapart;
        private System.Windows.Forms.Label lblapart;
        private System.Windows.Forms.TextBox txtbuilding;
        private System.Windows.Forms.Label lblbuilding;
        private System.Windows.Forms.TextBox txtstreet;
        private System.Windows.Forms.Label lblstreet;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.TextBox txtgov;
        private System.Windows.Forms.Label lblgov;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.TextBox txtacc;
        private System.Windows.Forms.Label lblacc;
        private System.Windows.Forms.TextBox txtbank;
        private System.Windows.Forms.Label lblbank;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label lblsalary;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp1;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private System.Windows.Forms.Label label5;
    }
}