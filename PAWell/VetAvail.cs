using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace DataBaseProjectPawell
{
    public partial class VetAvail : Form
    {
        Controller controllerObj;
        string UserName;

        private DateTime selectedDate;
        private TimeSpan selectedStart;
        private bool hasSelection = false;
        private void sttime_ValueChanged(object sender, EventArgs e)
        {
            // You can leave this empty for now
        }

        public VetAvail(string User)
        {
            InitializeComponent();
            controllerObj = new Controller();
            UserName = User;


            DataTable ap = controllerObj.GetVetBookedAppointments_ByUsername(UserName.Trim());

          //  guna2DataGridView2.DataSource = ap;

            if (ap == null)
            {
                guna2DataGridView2.DataSource = null;
                return;
            }

            guna2DataGridView2.AutoGenerateColumns = false;
            guna2DataGridView2.Columns[0].DataPropertyName = "ApptDate";
            guna2DataGridView2.Columns[1].DataPropertyName = "StartTime";
            guna2DataGridView2.Columns[2].DataPropertyName = "AnimalName";
            guna2DataGridView2.Columns[3].DataPropertyName = "OwnerName";

            guna2DataGridView2.Columns[0].HeaderText = "Date";
            guna2DataGridView2.Columns[1].HeaderText = "Start Time";
            guna2DataGridView2.Columns[2].HeaderText = "Animal";
            guna2DataGridView2.Columns[3].HeaderText = "Owner";


            guna2DataGridView2.DataSource = ap;


            DataTable dt = controllerObj.GetVetAvailabilityByUsername(UserName.Trim());
            // guna2DataGridView1.AutoGenerateColumns = true;
           // guna2DataGridView1.DataSource = dt;

            if (dt == null)
            {
                guna2DataGridView1.DataSource = null;
                return;
            }
            //MessageBox.Show(controllerObj.GetUserSSNByUsername(UserName).ToString());
            guna2DataGridView1.AutoGenerateColumns = false;
            guna2DataGridView1.Columns[0].DataPropertyName = "Date";
            guna2DataGridView1.Columns[1].DataPropertyName = "Start_Time";
            guna2DataGridView1.Columns[2].DataPropertyName = "End_Time";
            guna2DataGridView1.Columns[0].HeaderText = "Date";
            guna2DataGridView1.Columns[1].HeaderText = "Start Time";
            guna2DataGridView1.Columns[2].HeaderText = "End Time";
            guna2DataGridView1.DataSource = dt;
        }

        private void VetAvail_Load(object sender, EventArgs e)
        {
            sttime.Format = DateTimePickerFormat.Custom;
            sttime.CustomFormat = "hh:mm tt";
            sttime.ShowUpDown = true;

            endtime.Format = DateTimePickerFormat.Custom;
            endtime.CustomFormat = "hh:mm tt";
            endtime.ShowUpDown = true;


        }

        private void enftime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vetSSN = controllerObj.GetUserSSNByUsername(UserName);
            DateTime date = AvDate.Value.Date;

            DateTime startDT = sttime.Value;
            DateTime endDT = endtime.Value;

            if (endDT <= startDT)
            {
                MessageBox.Show("End time must be after start time.");
                return;
            }

            TimeSpan start = startDT.TimeOfDay;
            TimeSpan end = endDT.TimeOfDay;

            int slotMinutes = 30;
            int inserted = 0;

            TimeSpan cur = start;
            while (cur.Add(TimeSpan.FromMinutes(slotMinutes)) <= end)
            {
                TimeSpan slotEnd = cur.Add(TimeSpan.FromMinutes(slotMinutes));

                inserted += controllerObj.AddAvailabilitySlot(vetSSN, date, cur, slotEnd);

                cur = slotEnd;
            }

            MessageBox.Show("Inserted slots: " + inserted);

            // Refresh grid
            guna2DataGridView1.DataSource = controllerObj.GetVetAvailability(vetSSN);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

            selectedDate = Convert.ToDateTime(row.Cells[0].Value).Date;       // Date column
            selectedStart = TimeSpan.Parse(row.Cells[1].Value.ToString());    // Start_Time column
            hasSelection = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!hasSelection)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            int vetSSN = controllerObj.GetUserSSNByUsername(UserName);

            int rows = controllerObj.DeleteAvailability(vetSSN, selectedDate, selectedStart);

            if (rows > 0) MessageBox.Show("Deleted successfully!");
            else MessageBox.Show("Delete failed.");

            // refresh grid
            guna2DataGridView1.DataSource = controllerObj.GetVetAvailability(vetSSN);
            hasSelection = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!hasSelection)
            {
                MessageBox.Show("Please select a row first.");
                return;
            }

            int vetSSN = controllerObj.GetUserSSNByUsername(UserName);

            // new values from the pickers
            DateTime newDate = AvDate.Value.Date;
            TimeSpan newStart = sttime.Value.TimeOfDay;
            TimeSpan newEnd = endtime.Value.TimeOfDay;

            // enforce 30-min slot
            if (newEnd - newStart != TimeSpan.FromMinutes(30))
            {
                MessageBox.Show("Update must be exactly 30 minutes.");
                return;
            }

            int rows = controllerObj.UpdateAvailability(
                vetSSN,
                selectedDate,      // from the grid selection
                selectedStart,     // from the grid selection
                newDate,
                newStart,
                newEnd
            );

            if (rows > 0) MessageBox.Show("Updated successfully!");
            else MessageBox.Show("Update failed (maybe duplicate slot or not found).");

            // refresh
            guna2DataGridView1.DataSource = controllerObj.GetVetAvailability(vetSSN);
            hasSelection = false;
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AvDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Close();
            //Vetprofile vp = new Vetprofile(UserName);
            //vp.Show();
        }

        private void profile_Click_1(object sender, EventArgs e)
        {

        }

        private void Schedule_Click(object sender, EventArgs e)
        {
            VetAvail v = new VetAvail(UserName);
            v.Show();
        }

        private void VetAvail_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;

            DataGridViewRow row = guna2DataGridView1.Rows[e.RowIndex];

            selectedDate = Convert.ToDateTime(row.Cells[0].Value).Date;       // Date column
            selectedStart = TimeSpan.Parse(row.Cells[1].Value.ToString());    // Start_Time column
            hasSelection = true;
        }
    }
}
