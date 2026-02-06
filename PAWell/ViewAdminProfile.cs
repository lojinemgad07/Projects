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
    public partial class ViewAdminProfile: Form
    {
        Controller controllerObj;
        int adminSSN;
        bool isEditMode = false;

        public ViewAdminProfile(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.adminSSN = ssn;
        }
        private void LoadProfileData()
        {
            DataTable dt = controllerObj.GetAdminProfile(adminSSN);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                txtssn.Text = row["UserSSN"].ToString();
                txtusername.Text = row["Username"].ToString();

                txtfirst.Text = row["First_Name"].ToString();
                txtlast.Text = row["Last_Name"].ToString();
                txtpass.Text = row["Password"].ToString();
                txtphone.Text = row["Phone_Number"].ToString();

                txtgov.Text = row["Governorate"].ToString();
                txtcity.Text = row["City"].ToString();
                txtstreet.Text = row["Street"].ToString();
                txtbuilding.Text = row["Building"].ToString();
                txtapart.Text = row["Apartment"].ToString();
                txtzip.Text = row["ZIP_Code"].ToString();

                if (row["E_Start_Date"] != DBNull.Value)
                {
                    DateTime dtStart = (DateTime)row["E_Start_Date"];
                    txtdate.Text = dtStart.ToShortDateString();
                }

                txtsalary.Text = row["Salary"].ToString();
                txtbank.Text = row["Bank"].ToString();
                txtacc.Text = row["Account_Number"].ToString();
            }
            else
            {
                MessageBox.Show("Error: Could not retrieve user data.");
                this.Close();
            }
        }
        private void ChangeFormState(bool isEditable)
        {
            txtssn.ReadOnly = true;
            txtusername.ReadOnly = true;

            txtsalary.ReadOnly = true;
            txtdate.ReadOnly = true;
            txtbank.ReadOnly = true;
            txtacc.ReadOnly = true;

            txtfirst.ReadOnly = !isEditable;
            txtlast.ReadOnly = !isEditable;
            txtpass.ReadOnly = !isEditable;
            txtphone.ReadOnly = !isEditable;

            txtgov.ReadOnly = !isEditable;
            txtcity.ReadOnly = !isEditable;
            txtstreet.ReadOnly = !isEditable;
            txtbuilding.ReadOnly = !isEditable;
            txtapart.ReadOnly = !isEditable;
            txtzip.ReadOnly = !isEditable;


            if (isEditable)
            {
                isEditMode = true;
                btnupdate.Text = "Save Changes";
                btnupdate.BackColor = Color.LightGreen;
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                isEditMode = false;
                btnupdate.Text = "Edit Profile";
                btnupdate.BackColor = SystemColors.Control;
                txtpass.UseSystemPasswordChar = true;
            }
        }
        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void ViewAdminProfile_Load(object sender, EventArgs e)
        {
            LoadProfileData();
            ChangeFormState(false);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (isEditMode == false)
            {
                ChangeFormState(true);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtfirst.Text) ||
                string.IsNullOrWhiteSpace(txtlast.Text) ||
                string.IsNullOrWhiteSpace(txtpass.Text) ||
                string.IsNullOrWhiteSpace(txtemail.Text))
                {
                    MessageBox.Show("First Name, Last Name, Email, and Password cannot be empty.");
                    return;
                }

                if (txtpass.Text.Length < 3)
                {
                    MessageBox.Show("Password is too short.");
                    return;
                }


                int result = controllerObj.UpdateAdminProfile(
                    adminSSN,
                    txtfirst.Text,
                    txtlast.Text,
                    txtpass.Text,
                    txtphone.Text,
                    txtgov.Text,
                    txtcity.Text,
                    txtstreet.Text,
                    txtbuilding.Text,
                    txtapart.Text,
                    txtzip.Text
                );

                if (result > 0)
                {
                    MessageBox.Show("Profile Updated Successfully!");

                    ChangeFormState(false);
                }
                else
                {
                    MessageBox.Show("Update Failed. No changes were saved.");
                }
            }
        }


        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
