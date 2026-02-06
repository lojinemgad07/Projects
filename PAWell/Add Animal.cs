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
    public partial class Form2: Form
    {
        Controller controllerObj;

        public Form2()
        {
            InitializeComponent();
            controllerObj = new Controller();

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


            DataTable dtCustomers = controllerObj.GetAllCustomers();
            cmbcust.DataSource = dtCustomers;
            cmbcust.DisplayMember = "CustomerSSN";
            cmbcust.ValueMember = "CustomerSSN";

            DataTable dtSpecies = controllerObj.GetAllSpecies();
            cmbspecies.DataSource = dtSpecies;
            cmbspecies.DisplayMember = "Common_Name";
            cmbspecies.ValueMember = "Common_Name";

            cmbgender.Items.Clear();
            cmbgender.Items.Add("Male");
            cmbgender.Items.Add("Female");

            cmbbreed.DataSource = null;
        }

        private void cmbspecies_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbspecies.SelectedValue != null)
            {
                string selectedSpecies = cmbspecies.Text;

                DataTable dtBreeds = controllerObj.GetBreedsBySpecies(selectedSpecies);

                cmbbreed.DataSource = dtBreeds;
                cmbbreed.DisplayMember = "BreedName";
                cmbbreed.ValueMember = "BreedName";
                cmbbreed.Refresh();
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int ownerSSN = Convert.ToInt32(cmbcust.SelectedValue);
            if (string.IsNullOrWhiteSpace(txtname.Text))
            {
                MessageBox.Show("Animal Name is required.");
                return;
            }

            if (cmbcust.SelectedValue == null)
            {
                MessageBox.Show("Please select an Owner.");
                return;
            }
            if (cmbspecies.SelectedValue == null)
            {
                MessageBox.Show("Please select a Species.");
                return;
            }
            if (cmbbreed.SelectedValue == null)
            {
                MessageBox.Show("Please select a Breed.");
                return;
            }
            if (string.IsNullOrWhiteSpace(cmbgender.Text))
            {
                MessageBox.Show("Please select a Gender.");
                return;
            }

            decimal bWeight;
            decimal cWeight;

            if (!decimal.TryParse(txtbw.Text, out bWeight))
            {
                MessageBox.Show("Birth Weight must be a valid number.");
                return;
            }

            if (!decimal.TryParse(txtcw.Text, out cWeight))
            {
                MessageBox.Show("Current Weight must be a valid number.");
                return;
            }

            if (bWeight < 0 || cWeight < 0)
            {
                MessageBox.Show("Weights cannot be negative.");
                return;
            }


            int result = controllerObj.AddAnimal(
                txtname.Text,
                ownerSSN,
                cmbbreed.Text,
                cmbspecies.Text,
                dtp1.Value,
                bWeight,
                cWeight,
                cmbgender.Text
            );

            if (result > 0)
            {
                MessageBox.Show("Animal Added Successfully!");
                txtname.Clear();
                txtbw.Clear();
                txtcw.Clear();
            }
            else
            {
                MessageBox.Show("Failed to add animal.");
            }
        
    }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbbreed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
