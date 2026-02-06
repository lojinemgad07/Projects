
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBaseProjectPawell
{
    partial class Form1
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
            this.btnadmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnlogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnstat = new Guna.UI2.WinForms.Guna2Button();
            this.btnanimal = new Guna.UI2.WinForms.Guna2Button();
            this.btncust = new Guna.UI2.WinForms.Guna2Button();
            this.btnvet = new Guna.UI2.WinForms.Guna2Button();
            this.btnview = new Guna.UI2.WinForms.Guna2Button();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnvacc = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Controls.Add(this.btnvacc);
            this.guna2Panel1.Controls.Add(this.btnadmin);
            this.guna2Panel1.Controls.Add(this.btnlogout);
            this.guna2Panel1.Controls.Add(this.btnstat);
            this.guna2Panel1.Controls.Add(this.btnanimal);
            this.guna2Panel1.Controls.Add(this.btncust);
            this.guna2Panel1.Controls.Add(this.btnvet);
            this.guna2Panel1.Controls.Add(this.btnview);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, -2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(275, 564);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.Silver;
            this.btnadmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadmin.FillColor = System.Drawing.Color.Silver;
            this.btnadmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnadmin.ForeColor = System.Drawing.Color.Black;
            this.btnadmin.Location = new System.Drawing.Point(53, 289);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(163, 28);
            this.btnadmin.TabIndex = 6;
            this.btnadmin.Text = "Add Admin";
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Silver;
            this.btnlogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogout.FillColor = System.Drawing.Color.Silver;
            this.btnlogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlogout.ForeColor = System.Drawing.Color.Black;
            this.btnlogout.Location = new System.Drawing.Point(53, 487);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(163, 28);
            this.btnlogout.TabIndex = 5;
            this.btnlogout.Text = "Logout";
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnstat
            // 
            this.btnstat.BackColor = System.Drawing.Color.Silver;
            this.btnstat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstat.FillColor = System.Drawing.Color.Silver;
            this.btnstat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnstat.ForeColor = System.Drawing.Color.Black;
            this.btnstat.Location = new System.Drawing.Point(53, 347);
            this.btnstat.Name = "btnstat";
            this.btnstat.Size = new System.Drawing.Size(163, 28);
            this.btnstat.TabIndex = 4;
            this.btnstat.Text = "Hospital Statistics";
            this.btnstat.Click += new System.EventHandler(this.btnstat_Click);
            // 
            // btnanimal
            // 
            this.btnanimal.BackColor = System.Drawing.Color.Silver;
            this.btnanimal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnanimal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnanimal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnanimal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnanimal.FillColor = System.Drawing.Color.Silver;
            this.btnanimal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnanimal.ForeColor = System.Drawing.Color.Black;
            this.btnanimal.Location = new System.Drawing.Point(53, 233);
            this.btnanimal.Name = "btnanimal";
            this.btnanimal.Size = new System.Drawing.Size(163, 28);
            this.btnanimal.TabIndex = 3;
            this.btnanimal.Text = "Add Animal";
            this.btnanimal.Click += new System.EventHandler(this.btnanimal_Click);
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.Color.Silver;
            this.btncust.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncust.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncust.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncust.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncust.FillColor = System.Drawing.Color.Silver;
            this.btncust.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncust.ForeColor = System.Drawing.Color.Black;
            this.btncust.Location = new System.Drawing.Point(53, 176);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(163, 28);
            this.btncust.TabIndex = 2;
            this.btncust.Text = "Add Customer";
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // btnvet
            // 
            this.btnvet.BackColor = System.Drawing.Color.Silver;
            this.btnvet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnvet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnvet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnvet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnvet.FillColor = System.Drawing.Color.Silver;
            this.btnvet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnvet.ForeColor = System.Drawing.Color.Black;
            this.btnvet.Location = new System.Drawing.Point(53, 121);
            this.btnvet.Name = "btnvet";
            this.btnvet.Size = new System.Drawing.Size(163, 28);
            this.btnvet.TabIndex = 1;
            this.btnvet.Text = "Add Vet";
            this.btnvet.Click += new System.EventHandler(this.btnvet_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.Silver;
            this.btnview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnview.FillColor = System.Drawing.Color.Silver;
            this.btnview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnview.ForeColor = System.Drawing.Color.Black;
            this.btnview.Location = new System.Drawing.Point(53, 68);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(163, 28);
            this.btnview.TabIndex = 0;
            this.btnview.Text = "View/Update Profile";
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcome.Location = new System.Drawing.Point(475, 231);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(249, 41);
            this.lblwelcome.TabIndex = 1;
            this.lblwelcome.Text = "Welcome Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(352, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please choose one of the options below:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnvacc
            // 
            this.btnvacc.BackColor = System.Drawing.Color.Silver;
            this.btnvacc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnvacc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnvacc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnvacc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnvacc.FillColor = System.Drawing.Color.Silver;
            this.btnvacc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnvacc.ForeColor = System.Drawing.Color.Black;
            this.btnvacc.Location = new System.Drawing.Point(53, 402);
            this.btnvacc.Name = "btnvacc";
            this.btnvacc.Size = new System.Drawing.Size(163, 28);
            this.btnvacc.TabIndex = 7;
            this.btnvacc.Text = "Available Vaccines";
            this.btnvacc.Click += new System.EventHandler(this.btnvacc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 559);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblwelcome);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnview;
        private Guna.UI2.WinForms.Guna2Button btncust;
        private Guna.UI2.WinForms.Guna2Button btnvet;
        private Guna.UI2.WinForms.Guna2Button btnlogout;
        private Guna.UI2.WinForms.Guna2Button btnstat;
        private Guna.UI2.WinForms.Guna2Button btnanimal;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnadmin;
        private Guna.UI2.WinForms.Guna2Button btnvacc;
    }
}

