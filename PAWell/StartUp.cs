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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            CustomerLogin c = new CustomerLogin();
            c.Show();
        }

        private void Vet_Click(object sender, EventArgs e)
        {
            VetLogin c = new VetLogin();
            c.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {

            AdminLogin c = new AdminLogin();
            c.Show();
        }

        private void StartUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MedicalRecords m = new MedicalRecords();
            //m.Show();
        }

        private void Customer_Click_1(object sender, EventArgs e)
        {
            CustomerLogin c = new CustomerLogin();
            c.Show();
        }

        private void Vet_Click_1(object sender, EventArgs e)
        {
            VetLogin c = new VetLogin();
            c.Show();
        }

        private void Admin_Click_1(object sender, EventArgs e)
        {
            AdminLogin c = new AdminLogin();
            c.Show();
        }




    }
}
