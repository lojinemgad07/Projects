using Guna.UI2.WinForms;
//using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataBaseProjectPawell
{
    public partial class Vetprofile : Form
    {
        Controller controllerObj;
        string Username;
        public Vetprofile(string User)
        {
            InitializeComponent();
            controllerObj = new Controller();
            Username = User;


            LoadVetProfile();
            SetReadOnlyMode(true);

            button2.Visible = false;
            button1.Visible = true;

            profilepanel.Visible = true;
            name.Text = "Welcome, Dr. " + controllerObj.GetVetFullNameByUsername(Username);

            //view code

            LoadVetDegreesAndSpecializations();

        }

        void LoadVetDegreesAndSpecializations()
        {
            int vetSSN = controllerObj.GetUserSSNByUsername(Username.Trim());
            if (vetSSN == -1) return;

            degview.DataSource = controllerObj.GetVetDegrees(vetSSN);
            spview.DataSource = controllerObj.GetVetSpecializations(vetSSN);
        }
        void SetReadOnlyMode(bool readOnly)
        {
            username.ReadOnly = true;
            fname.ReadOnly = readOnly;
            lname.ReadOnly = readOnly;
            Gover.ReadOnly = readOnly;
            street.ReadOnly = readOnly;
            city.ReadOnly = readOnly;
            apartment.ReadOnly = readOnly;
            building.ReadOnly = readOnly;
            zipcode.ReadOnly = readOnly;
            //textBox1.ReadOnly = true;
            //textBox2.ReadOnly = true;
        }
        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void profilepanel_Paint(object sender, PaintEventArgs e)
        {

        }


        void LoadVetProfile()
        {
            // 1) get SSN
            int vetSSN;
            vetSSN = controllerObj.GetUserSSNByUsername(Username.Trim());
            if (vetSSN == -1)
            {
                MessageBox.Show("User not found.");
                return;
            }

            // 2) main profile info
            DataTable dt = controllerObj.GetVetProfileByUsername(Username.Trim());
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Vet profile not found.");
                return;
            }

            DataRow r = dt.Rows[0];

            username.Text = r["Username"].ToString();
            fname.Text = r["First_Name"].ToString();
            lname.Text = r["Last_Name"].ToString();

            // If you have email/phone textboxes, fill them too
            // email.Text = r["Email"].ToString();
            // phone.Text = r["Phone_Number"].ToString();

            Gover.Text = r["Governorate"].ToString();
            city.Text = r["City"].ToString();
            street.Text = r["Street"].ToString();
            building.Text = r["Building"].ToString();
            apartment.Text = r["Apartment"].ToString();
            zipcode.Text = r["ZIP_Code"].ToString();

            //// 3) degree + specialization (first row only)
            //DataTable deg = controllerObj.GetVetDegrees(vetSSN);
            //textBox1.Text = (deg != null && deg.Rows.Count > 0) ? deg.Rows[0]["Degree"].ToString() : "";

            //DataTable sp = controllerObj.GetVetSpecializations(vetSSN);
            //textBox2.Text = (sp != null && sp.Rows.Count > 0) ? sp.Rows[0]["Specialization"].ToString() : "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetReadOnlyMode(false);
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rows = controllerObj.UpdateVetProfileByUsername(
     Username.Trim(),
     fname.Text, lname.Text,
     Gover.Text, city.Text, street.Text,
     building.Text, apartment.Text, zipcode.Text
                       );

            if (rows > 0)
            {
                MessageBox.Show("Updated successfully!");

                SetReadOnlyMode(true);
                button2.Visible = false;
                button1.Visible = true;

                LoadVetProfile(); // refresh values
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }
        private void ShowPage(Control page)
        {
            // hide all pages inside the container
            foreach (Control c in guna2Panel1.Controls)
                c.Visible = false;

            page.Visible = true;
            page.BringToFront();
        }
        private void Vetprofile_Load(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            //   ShowPage(profilepanel);
            profilepanel.Visible = true;

        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            //        //ShowPage(schedulepanel);
            //        profilepanel.Visible = false;
            //        schedulepanel.Visible = true;
            //        MessageBox.Show(
            //$"Schedule children: {schedulepanel.Controls.Count}\n" +
            //$"Schedule Visible: {schedulepanel.Visible}");

            VetAvail m = new VetAvail(Username);
            m.Show();
        }

        private void schedulepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void degview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Schedule_Click_1(object sender, EventArgs e)
        {
            //        //ShowPage(schedulepanel);
            //        profilepanel.Visible = false;
            //        schedulepanel.Visible = true;
            //        MessageBox.Show(
            //$"Schedule children: {schedulepanel.Controls.Count}\n" +
            //$"Schedule Visible: {schedulepanel.Visible}");

            VetAvail m = new VetAvail(Username);
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SetReadOnlyMode(false);
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int rows = controllerObj.UpdateVetProfileByUsername(
    Username.Trim(),
    fname.Text, lname.Text,
    Gover.Text, city.Text, street.Text,
    building.Text, apartment.Text, zipcode.Text
                      );

            if (rows > 0)
            {
                MessageBox.Show("Updated successfully!");

                SetReadOnlyMode(true);
                button2.Visible = false;
                button1.Visible = true;

                LoadVetProfile(); // refresh values
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


