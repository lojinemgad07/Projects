
using System;
using System.Drawing;
using System.Windows.Forms;
namespace DataBaseProjectPawell
{
    partial class StartUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Admin = new System.Windows.Forms.Button();
            this.Vet = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2Panel1);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(726, 332);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Window;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Admin);
            this.guna2Panel1.Controls.Add(this.Vet);
            this.guna2Panel1.Controls.Add(this.Customer);
            this.guna2Panel1.Location = new System.Drawing.Point(73, 19);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(602, 302);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label2.Location = new System.Drawing.Point(58, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(501, 46);
            this.label2.TabIndex = 17;
            this.label2.Text = "Welcome to PAWell Pet Hospital";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(160, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 16;
            this.label1.Text = "Please Choose User Type";
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.SystemColors.Highlight;
            this.Admin.Location = new System.Drawing.Point(249, 213);
            this.Admin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(92, 23);
            this.Admin.TabIndex = 15;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // Vet
            // 
            this.Vet.BackColor = System.Drawing.SystemColors.Highlight;
            this.Vet.Location = new System.Drawing.Point(249, 172);
            this.Vet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Vet.Name = "Vet";
            this.Vet.Size = new System.Drawing.Size(92, 23);
            this.Vet.TabIndex = 14;
            this.Vet.Text = "Vet";
            this.Vet.UseVisualStyleBackColor = false;
            this.Vet.Click += new System.EventHandler(this.Vet_Click);
            // 
            // Customer
            // 
            this.Customer.BackColor = System.Drawing.SystemColors.Highlight;
            this.Customer.Location = new System.Drawing.Point(249, 136);
            this.Customer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(92, 23);
            this.Customer.TabIndex = 13;
            this.Customer.Text = "Customer";
            this.Customer.UseVisualStyleBackColor = false;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 349);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StartUp";
            this.Text = "StartUp";
            this.groupBox1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label2;
        private Label label1;
        private Button Admin;
        private Button Vet;
        private Button Customer;
    }
}