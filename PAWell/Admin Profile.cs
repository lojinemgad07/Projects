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
    public partial class Form1: Form
    {
        Controller controllerObj;
        int adminssn;


        public Form1(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            this.adminssn = ssn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string AdminName = controllerObj.GetUserName(adminssn);


            lblwelcome.Text = "Welcome, " + AdminName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();


            if (adminssn != 0)
            {
                ViewAdminProfile myForm = new ViewAdminProfile(adminssn);
                myForm.Show();
            }
            else
            {
                MessageBox.Show("No users found in database to test with!");
            }
        }

        private void btnvet_Click(object sender, EventArgs e)
        {
            Add_Vet form = new Add_Vet();
            form.Show();
        }

        private void btncust_Click(object sender, EventArgs e)
        {
            AddCustomer form = new AddCustomer();
            form.Show();
        }

        private void btnanimal_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AddAdmin form = new AddAdmin();
            form.Show();
        }

        private void btnstat_Click(object sender, EventArgs e)
        {
            HospitalStatistics form = new HospitalStatistics(this);
            form.Show();
            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            AdminLogin login = new AdminLogin();

            login.Show();

            this.Close();
        }

        private void btnvacc_Click(object sender, EventArgs e)
        {
            AvailableVaccines vaccineStock = new AvailableVaccines(this);
            vaccineStock.Show();
            this.Hide();
        }
    }
}
