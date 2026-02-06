using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataBaseProjectPawell
{
    public partial class CustomerLogin : Form
    {
        Controller controllerObj;

        public CustomerLogin()
        {
            InitializeComponent();
            UsernameError.Visible = false;
            PassError.Visible = false;
            EmptyFields.Visible = false;

            controllerObj = new Controller();

        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            UsernameError.Visible = false;
            PassError.Visible = false;
            EmptyFields.Visible = false;

            if (string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Pass.Text))
            {
                EmptyFields.Visible = true;
                return;
            }

            DataTable dt = controllerObj.GetUserByUsername(User.Text);

            if (dt == null || dt.Rows.Count == 0)
            {

                UsernameError.Visible = true;
                return;
            }
            string realPassword = dt.Rows[0]["Password"].ToString();
            if (Pass.Text != realPassword)
            {

                PassError.Visible = true;
                return;
            }

            MessageBox.Show("Login Successful!");
            int ssn = controllerObj.GetUserSSNByUsername(User.Text);
            CustomerOptions customerOptions = new CustomerOptions(User.Text,ssn);
            customerOptions.Show();
            this.Hide();

        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pass.UseSystemPasswordChar = false;  // show password
            }
            else
            {
                Pass.UseSystemPasswordChar = true;   // hide password
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Pass.UseSystemPasswordChar = false;  // show password
            }
            else
            {
                Pass.UseSystemPasswordChar = true;   // hide password
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            UsernameError.Visible = false;
            PassError.Visible = false;
            EmptyFields.Visible = false;

            if (string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Pass.Text))
            {
                EmptyFields.Visible = true;
                return;
            }

            DataTable dt = controllerObj.GetUserByUsername(User.Text);

            if (dt == null || dt.Rows.Count == 0)
            {

                UsernameError.Visible = true;
                return;
            }
            string realPassword = dt.Rows[0]["Password"].ToString();
            if (Pass.Text != realPassword)
            {

                PassError.Visible = true;
                return;
            }

            MessageBox.Show("Login Successful!");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
