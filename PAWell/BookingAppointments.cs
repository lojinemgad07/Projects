using Guna.UI2.WinForms;
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
    public partial class BookingAppointments : Form
    {
        Controller controllerobj;
        int selectedVetSSN;
        DateTime selectedDate;
        TimeSpan selectedStartTime;
        string USER;
        int SSN;
        public BookingAppointments(string username, int ssn)
        {
            InitializeComponent();
            controllerobj = new Controller();
            USER = username;
            SSN = ssn;
        }
           

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        
            if (e.RowIndex < 0) return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

            selectedVetSSN = Convert.ToInt32(row.Cells["VetSSN"].Value);
            selectedDate = Convert.ToDateTime(row.Cells["Date"].Value);
            selectedStartTime = (TimeSpan)row.Cells["Start_Time"].Value;

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void BookingAppointments_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerobj.RetrieveBookings();
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.ReadOnly = true;
            guna2DataGridView1.ColumnHeadersVisible = true;
            guna2DataGridView1.Columns["VetSSN"].Visible = false;

            DataTable dt2 = controllerobj.RetrieveAnimals(1001);
            if (dt2 == null || dt2.Rows.Count == 0)
            {
                MessageBox.Show("No animals found");
                return;
            }

            AnimalName.DataSource = dt2;
            AnimalName.DisplayMember = "A_Name";

            DataTable dt3 = controllerobj.RetrieveCardnumber(1001);
            cardnumber.Text = dt3.Rows[0]["Card_Number"].ToString();

        }

        private void AnimalName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            int result2 = controllerobj.CheckAvailability(selectedVetSSN, selectedDate, selectedStartTime);
            if (result2 >= 1)
                MessageBox.Show("Appointment already booked");
            else
            {
                int result = controllerobj.BookAppointment(AnimalName.Text, SSN, selectedVetSSN, selectedDate, selectedStartTime, DateTime.Now);
                if (result == 0)
                    MessageBox.Show(@"Appointment not booked succesfully
                    make sure you filled all the needed information");
                else
                    MessageBox.Show("Appointment booked succesfully");
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CustomerOptions customerOptions = new CustomerOptions(USER,SSN);
            customerOptions.Show();
            this.Hide();
        }
    }
}
