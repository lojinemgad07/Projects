using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DataBaseProjectPawell
{
    public partial class ViewCustomerProfile : Form
    {
        Controller controllerobj = new Controller();
        public ViewCustomerProfile()
        {
            InitializeComponent();
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewCustomerProfile_Load(object sender, EventArgs e)
        {
            SSN.ReadOnly = true;
            SSN.Text = "1001";
            int ssn;

            try
            {
                ssn = Convert.ToInt32(SSN.Text);
            }
            catch
            {
                MessageBox.Show("SSN must be a number");
                return;
            }
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

            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (FirstName.Text == "" || LastName.Text == "" || Email.Text == "" )
            {
                MessageBox.Show("make sure personal details are all filled");


            }
            else
            {
                int result; //controllerobj.UpdateCustomerData(ssn, FirstName.Text, LastName.Text, Email.Text, PhoneNumber.Text, cardnumber.Text, Bank.Text, governorate.Text, city.Text, street.Text, building.Text, apartment.Text, zipCode.Text);
                result = 1;
                if (result == 0)
                    MessageBox.Show("profile not updated succesfully");
                else
                    MessageBox.Show("profile updated succesfully");
            }
        }
    }
}
