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
    public partial class Add_Vet: Form
    {
        Controller controllerObj;

        public Add_Vet()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtssn.Text) ||
         string.IsNullOrWhiteSpace(txtusername.Text) ||
         string.IsNullOrWhiteSpace(txtpass.Text) ||
         string.IsNullOrWhiteSpace(txtfirst.Text) ||
         string.IsNullOrWhiteSpace(txtlast.Text) ||
         string.IsNullOrWhiteSpace(txtemail.Text) ||
         string.IsNullOrWhiteSpace(txtsalary.Text) ||
         string.IsNullOrWhiteSpace(txtbank.Text) ||
         string.IsNullOrWhiteSpace(txtacc.Text) ||
         string.IsNullOrWhiteSpace(txtdeg.Text) ||
         string.IsNullOrWhiteSpace(txtspec.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            int ssn;
            decimal salary;
            int zipCode;

            if (!int.TryParse(txtssn.Text, out ssn))
            {
                MessageBox.Show("SSN must be a valid number.");
                return;
            }
            if (txtssn.Text.Trim().Length < 8)
            {
                MessageBox.Show("SSN must be at least 8 digits.");
                return;
            }
            if (!decimal.TryParse(txtsalary.Text, out salary))
            {
                MessageBox.Show("Salary must be a valid number");
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtzip.Text) && !int.TryParse(txtzip.Text, out zipCode))
            {
                MessageBox.Show("ZIP Code must be a number.");
                return;
            }


            if (salary < 0)
            {
                MessageBox.Show("Salary cannot be negative.");
                return;
            }

            if (txtpass.Text.Length < 8)
            {
                MessageBox.Show("Password is too weak (Must be at least 8 characters.");
                return;
            }


            int result = controllerObj.AddVet(
                ssn,
                txtusername.Text,
                txtpass.Text,
                txtfirst.Text,
                txtlast.Text,
                txtemail.Text,
                txtphone.Text,
                txtgov.Text,
                txtcity.Text,
                txtstreet.Text,
                txtbuilding.Text,
                txtapart.Text,
                txtzip.Text,
                salary,
                dtp1.Value,
                txtbank.Text,
                txtacc.Text,
                txtdeg.Text,
                txtspec.Text
            );

            if (result > 0)
            {
                MessageBox.Show("Vet Added Successfully!");
                txtssn.Clear();
                txtusername.Clear();
                txtpass.Clear();

                txtfirst.Clear();
                txtlast.Clear();
                txtemail.Clear();
                txtphone.Clear();

                txtgov.Clear();
                txtcity.Clear();
                txtstreet.Clear();
                txtbuilding.Clear();
                txtapart.Clear();
                txtzip.Clear();

                txtsalary.Clear();
                txtbank.Clear();
                txtacc.Clear();
                txtdeg.Clear();

                dtp1.Value = DateTime.Now;

            }
            else
            {
                MessageBox.Show("Failed to add Vet. Username or SSN might already exist.");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
