using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseProjectPawell
{
    public partial class AdminLogin : Form
    {
        Controller controllerObj;
        public AdminLogin()
        {
            InitializeComponent();

            UsernameError.Visible = false;
            PassError.Visible = false;
            EmptyFields.Visible = false;


            guna2TabControl1.Appearance = TabAppearance.FlatButtons;
            guna2TabControl1.ItemSize = new Size(0, 1);
            guna2TabControl1.SizeMode = TabSizeMode.Fixed;

            guna2TabControl1.SelectedIndex = 0; // Login first

            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
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

            DataTable dt = controllerObj.GetAdminByUsername(User.Text);

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
            int ssn = controllerObj.GetUserSSN(User.Text, Pass.Text);

            if (ssn > 0)
            {
                MessageBox.Show("Login Successful!");

                Form1 form = new Form1(ssn);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            MessageBox.Show("Login Successful!");
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

        private void login_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = 0;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = 1;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UsernameError.Visible = false;
            PassError.Visible = false;
            EmptyFields.Visible = false;

            if (string.IsNullOrEmpty(User.Text) || string.IsNullOrEmpty(Pass.Text))
            {
                EmptyFields.Visible = true;
                return;
            }

            DataTable dt = controllerObj.GetAdminByUsername(User.Text);

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

            // MessageBox.Show("Login Successful!");

            VetAvail c = new VetAvail(User.Text);
            c.Show();
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Assn.Text) ||
     string.IsNullOrWhiteSpace(APass.Text) ||
     string.IsNullOrWhiteSpace(Auser.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int ssn = int.Parse(Assn.Text);

            int result = controllerObj.AddAdmin(
                ssn,
                Auser.Text.Trim(),
                APass.Text.Trim(),
                Fname.Text.Trim(),
                Lname.Text.Trim(),
                Email.Text.Trim(),
                PN.Text.Trim(),
                Gover.Text.Trim(),
                city.Text.Trim(),
                street.Text.Trim(),
                building.Text.Trim(),
                apartment.Text.Trim(),
                zipcode.Text.Trim()
            );
            if (APass.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

             if (result > 0)
            {
                MessageBox.Show("Account created successfully. Please login.");

                // Prefill login
                User.Text = Auser.Text;
                Pass.Clear();

                guna2TabControl1.SelectedIndex = 0; // back to login
            }
            else
            {
                MessageBox.Show("Sign up failed. Username or SSN may already exist.");
            }


        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            guna2TabControl1.SelectedIndex = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Assn.Text) ||
    string.IsNullOrWhiteSpace(APass.Text) ||
    string.IsNullOrWhiteSpace(Auser.Text))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            int ssn = int.Parse(Assn.Text);

            int result = controllerObj.AddAdmin(
                ssn,
                Auser.Text.Trim(),
                APass.Text.Trim(),
                Fname.Text.Trim(),
                Lname.Text.Trim(),
                Email.Text.Trim(),
                PN.Text.Trim(),
                Gover.Text.Trim(),
                city.Text.Trim(),
                street.Text.Trim(),
                building.Text.Trim(),
                apartment.Text.Trim(),
                zipcode.Text.Trim()
            );
            if (APass.Text != textBox1.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (result > 0)
            {
                MessageBox.Show("Account created successfully. Please login.");

                // Prefill login
                User.Text = Auser.Text;
                Pass.Clear();

                guna2TabControl1.SelectedIndex = 0; // back to login
            }
            else
            {
                MessageBox.Show("Sign up failed. Username or SSN may already exist.");
            }
        }
    }
}
