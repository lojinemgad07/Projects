using DataBaseProjectPawell;
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
    public partial class CustomerOptions : Form
    {
        int SSN;
        string name;
        public CustomerOptions(string username,int ssn)
        {
            InitializeComponent();
            SSN = ssn;
            name = username;
            guna2HtmlLabel1.Text = "Welcome, " + username;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AnimalProfile AnimalProfile = new AnimalProfile(this, SSN);
            AnimalProfile.Show();
            this.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //ViewVaccines viewVaccines = new ViewVaccines();
            //viewVaccines.Show();

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            BookingAppointments bookingAppointments = new BookingAppointments(name,SSN);
            bookingAppointments.Show();
            this.Hide();

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            ViewProfile viewProfile = new ViewProfile(SSN,name);
            viewProfile.Show();
            this.Hide();
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
