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
    public partial class VetLogin : Form
    {

        Controller controllerObj;
        public VetLogin()
        {
            InitializeComponent();
            controllerObj = new Controller();


            UsernameError.Visible = false;
            PassError.Visible = false;
            EmptyFields.Visible = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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

            DataTable dt = controllerObj.GetVetByUsername(User.Text);

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

            //Vetprofile c = new Vetprofile(User.Text);
            //c.Show();
            int vetSSN = controllerObj.GetUserSSNByUsername(User.Text);
            VetOptions vetOptions = new VetOptions(User.Text,vetSSN);
            vetOptions.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
