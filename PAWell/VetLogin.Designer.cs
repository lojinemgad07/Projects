
using System;
using System.Drawing;
using System.Windows.Forms;
namespace DataBaseProjectPawell
{
    partial class VetLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            groupBox1 = new GroupBox();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            label1 = new Label();
            EmptyFields = new Label();
            PassError = new Label();
            UsernameError = new Label();
            Pass = new TextBox();
            checkBox1 = new CheckBox();
            Password = new Label();
            button2 = new Button();
            User = new TextBox();
            button1 = new Button();
            Username = new Label();
            groupBox1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(guna2Panel2);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1086, 765);
            groupBox1.TabIndex = 94;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = SystemColors.ButtonHighlight;
            guna2Panel2.Controls.Add(label2);
            guna2Panel2.Controls.Add(label1);
            guna2Panel2.Controls.Add(EmptyFields);
            guna2Panel2.Controls.Add(PassError);
            guna2Panel2.Controls.Add(UsernameError);
            guna2Panel2.Controls.Add(Pass);
            guna2Panel2.Controls.Add(checkBox1);
            guna2Panel2.Controls.Add(Password);
            guna2Panel2.Controls.Add(button2);
            guna2Panel2.Controls.Add(User);
            guna2Panel2.Controls.Add(button1);
            guna2Panel2.Controls.Add(Username);
            guna2Panel2.CustomizableEdges = customizableEdges1;
            guna2Panel2.Location = new Point(225, 29);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel2.Size = new Size(604, 656);
            guna2Panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(234, 102);
            label2.Name = "label2";
            label2.Size = new Size(129, 37);
            label2.TabIndex = 91;
            label2.Text = "Vet Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(163, 46);
            label1.Name = "label1";
            label1.Size = new Size(322, 47);
            label1.TabIndex = 90;
            label1.Text = "PAWell Pet Hospital";
            // 
            // EmptyFields
            // 
            EmptyFields.AutoSize = true;
            EmptyFields.ForeColor = Color.Red;
            EmptyFields.Location = new Point(184, 507);
            EmptyFields.Name = "EmptyFields";
            EmptyFields.Size = new Size(260, 32);
            EmptyFields.TabIndex = 89;
            EmptyFields.Text = "Field's Cant't be empty";
            // 
            // PassError
            // 
            PassError.AutoSize = true;
            PassError.ForeColor = Color.Red;
            PassError.Location = new Point(211, 323);
            PassError.Name = "PassError";
            PassError.Size = new Size(192, 32);
            PassError.TabIndex = 88;
            PassError.Text = "Wrong password";
            // 
            // UsernameError
            // 
            UsernameError.AutoSize = true;
            UsernameError.ForeColor = Color.Red;
            UsernameError.Location = new Point(184, 219);
            UsernameError.Name = "UsernameError";
            UsernameError.Size = new Size(269, 32);
            UsernameError.TabIndex = 87;
            UsernameError.Text = "User name doesn't exist";
            // 
            // Pass
            // 
            Pass.Location = new Point(285, 271);
            Pass.Name = "Pass";
            Pass.Size = new Size(200, 39);
            Pass.TabIndex = 83;
            Pass.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(195, 376);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(208, 36);
            checkBox1.TabIndex = 84;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(117, 271);
            Password.Name = "Password";
            Password.Size = new Size(111, 32);
            Password.TabIndex = 82;
            Password.Text = "Password";
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Location = new Point(322, 432);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 86;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // User
            // 
            User.Location = new Point(285, 163);
            User.Name = "User";
            User.Size = new Size(200, 39);
            User.TabIndex = 81;
            // 
            // button1
            // 
            button1.Location = new Point(140, 432);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 85;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(105, 163);
            Username.Name = "Username";
            Username.Size = new Size(121, 32);
            Username.TabIndex = 80;
            Username.Text = "Username";
            // 
            // VetLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 765);
            Controls.Add(groupBox1);
            Name = "VetLogin";
            Text = "VetLogin";
            groupBox1.ResumeLayout(false);
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label2;
        private Label label1;
        private Label EmptyFields;
        private Label PassError;
        private Label UsernameError;
        private TextBox Pass;
        private CheckBox checkBox1;
        private Label Password;
        private Button button2;
        private TextBox User;
        private Button button1;
        private Label Username;
    }
}