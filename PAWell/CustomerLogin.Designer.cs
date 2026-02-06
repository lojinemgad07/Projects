
using System.Drawing;
using System.Windows.Forms;
namespace  DataBaseProjectPawell
{
    partial class CustomerLogin
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EmptyFields = new System.Windows.Forms.Label();
            this.PassError = new System.Windows.Forms.Label();
            this.UsernameError = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.guna2ShadowPanel1);
            this.groupBox1.Location = new System.Drawing.Point(192, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(496, 362);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.EmptyFields);
            this.guna2ShadowPanel1.Controls.Add(this.PassError);
            this.guna2ShadowPanel1.Controls.Add(this.UsernameError);
            this.guna2ShadowPanel1.Controls.Add(this.Pass);
            this.guna2ShadowPanel1.Controls.Add(this.checkBox1);
            this.guna2ShadowPanel1.Controls.Add(this.Password);
            this.guna2ShadowPanel1.Controls.Add(this.button2);
            this.guna2ShadowPanel1.Controls.Add(this.User);
            this.guna2ShadowPanel1.Controls.Add(this.button1);
            this.guna2ShadowPanel1.Controls.Add(this.Username);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(82, 32);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 12;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 20;
            this.guna2ShadowPanel1.ShadowShift = 0;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(311, 291);
            this.guna2ShadowPanel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(90, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Customer Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(60, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "PAWell Pet Hospital";
            // 
            // EmptyFields
            // 
            this.EmptyFields.AutoSize = true;
            this.EmptyFields.ForeColor = System.Drawing.Color.Red;
            this.EmptyFields.Location = new System.Drawing.Point(73, 238);
            this.EmptyFields.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EmptyFields.Name = "EmptyFields";
            this.EmptyFields.Size = new System.Drawing.Size(142, 16);
            this.EmptyFields.TabIndex = 21;
            this.EmptyFields.Text = "Field\'s Cant\'t be empty";
            // 
            // PassError
            // 
            this.PassError.AutoSize = true;
            this.PassError.ForeColor = System.Drawing.Color.Red;
            this.PassError.Location = new System.Drawing.Point(90, 146);
            this.PassError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PassError.Name = "PassError";
            this.PassError.Size = new System.Drawing.Size(109, 16);
            this.PassError.TabIndex = 20;
            this.PassError.Text = "Wrong password";
            // 
            // UsernameError
            // 
            this.UsernameError.AutoSize = true;
            this.UsernameError.ForeColor = System.Drawing.Color.Red;
            this.UsernameError.Location = new System.Drawing.Point(73, 94);
            this.UsernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameError.Name = "UsernameError";
            this.UsernameError.Size = new System.Drawing.Size(150, 16);
            this.UsernameError.TabIndex = 19;
            this.UsernameError.Text = "User name doesn\'t exist";
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(135, 120);
            this.Pass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(125, 22);
            this.Pass.TabIndex = 15;
            this.Pass.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(80, 172);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 20);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(32, 120);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 14;
            this.Password.Text = "Password";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(158, 200);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(135, 66);
            this.User.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(125, 22);
            this.User.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 200);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(25, 66);
            this.Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(70, 16);
            this.Username.TabIndex = 7;
            this.Username.Text = "Username";
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(816, 494);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerLogin";
            this.Text = "CustomerLogin";
            this.groupBox1.ResumeLayout(false);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
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