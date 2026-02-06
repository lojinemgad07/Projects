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
    public partial class VetOptions : Form
    {
        string name;
        int vetSSN;
        public VetOptions(string user,int vetssn)
        {
            InitializeComponent();
            guna2HtmlLabel1.Text = "Welcome, Dr. " + user;
            name = user;
            vetSSN = vetssn;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Vetprofile vetprofile = new Vetprofile(name);
            vetprofile.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            VetAvail vetAvail = new VetAvail(name);
            vetAvail.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MedicalRecords medicalRecords = new MedicalRecords(this, vetSSN);
            medicalRecords.Show();
            this.Hide();
        }
    }
}
