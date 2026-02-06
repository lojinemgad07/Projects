using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DataBaseProjectPawell
{
    public partial class ViewProfile : Form
    {
        Controller controllerobj;
        int ssn;
        string user;
        public ViewProfile(int Ssn,string username)
        {
            InitializeComponent();
            controllerobj = new Controller();
            ssn = Ssn;
            user = username;
            SSN.Text = ssn.ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    ssn = Convert.ToInt32(SSN.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("SSN must be a number");
            //    return;
            //}
            if (FirstName.Text == "" || LastName.Text == "" || Email.Text == "" || cardnumber.Text == "" || Bank.Text == "")
            {
                MessageBox.Show("make sure personal and financial details are all filled");


            }
            else
            {
                int result = controllerobj.UpdateCustomerData(ssn, FirstName.Text, LastName.Text, Email.Text, PhoneNumber.Text, cardnumber.Text, Bank.Text, governorate.Text, city.Text, street.Text, building.Text, apartment.Text, zipCode.Text);

                if (result == 0)
                    MessageBox.Show("profile not updated succesfully");
                else
                    MessageBox.Show("profile updated succesfully");
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            SSN.ReadOnly = true;
            //int ssn;

            //try
            //{
            //    ssn = Convert.ToInt32(SSN.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("SSN must be a number");
            //    return;
            //}
            DataTable dt = controllerobj.CustomerData(ssn);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                SSN.Text = r["UserSSN"].ToString();
                FirstName.Text = r["First_Name"].ToString();
                LastName.Text = r["Last_Name"].ToString();
                Email.Text = r["Email"].ToString();
                PhoneNumber.Text = r["Phone_Number"].ToString();

                governorate.Text = r["Governorate"].ToString();
                city.Text = r["City"].ToString();
                street.Text = r["Street"].ToString();
                building.Text = r["Building"].ToString();
                apartment.Text = r["Apartment"].ToString();
                zipCode.Text = r["ZIP_Code"].ToString();

                cardnumber.Text = r["Card_Number"].ToString();
                Bank.Text = r["Bank"].ToString();
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            SSN.ReadOnly = true;
            SSN.Text = ssn.ToString();
          
            DataTable dt = controllerobj.CustomerData(ssn);

            if (dt.Rows.Count > 0)
            {
                DataRow r = dt.Rows[0];

                SSN.Text = r["UserSSN"].ToString();
                FirstName.Text = r["First_Name"].ToString();
                LastName.Text = r["Last_Name"].ToString();
                Email.Text = r["Email"].ToString();
                PhoneNumber.Text = r["Phone_Number"].ToString();

                governorate.Text = r["Governorate"].ToString();
                city.Text = r["City"].ToString();
                street.Text = r["Street"].ToString();
                building.Text = r["Building"].ToString();
                apartment.Text = r["Apartment"].ToString();
                zipCode.Text = r["ZIP_Code"].ToString();

                cardnumber.Text = r["Card_Number"].ToString();
                Bank.Text = r["Bank"].ToString();
            }

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            int i = 0;
            CustomerOptions customerOptions = new CustomerOptions(user,ssn);
            customerOptions.Show();
            this.Hide();
        }
    }
}
