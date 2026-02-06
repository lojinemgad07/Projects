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
    public partial class AddCustomer: Form
    {
        Controller controllerObj;

        public AddCustomer()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void AddCustomer_Load(object sender, EventArgs e)
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
           string.IsNullOrWhiteSpace(txtcard.Text) ||
           string.IsNullOrWhiteSpace(txtbank.Text))
            {
                MessageBox.Show("Please fill in all required fields:\nSSN, Username, Password, Name, Email, Card Number, Bank.");
                return;
            }

            int ssn;
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
            

            if (!string.IsNullOrWhiteSpace(txtzip.Text) && !int.TryParse(txtzip.Text, out zipCode))
            {
                MessageBox.Show("ZIP Code must be a number.");
                return;
            }



            if (txtpass.Text.Length < 8)
            {
                MessageBox.Show("Password is too weak (Must be at least 8 characters.");
                return;
            }


            int result = controllerObj.AddCustomer(
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
                txtcard.Text,
                txtbank.Text
            );

            if (result > 0)
            {
                MessageBox.Show("Customer Added Successfully!");
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

                txtbank.Clear();
                txtcard.Clear();


            }
            else
            {
                MessageBox.Show("Failed to add Customer. Username or SSN might already exist.");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
