//using PAWell_V2;
using Guna.UI2.AnimatorNS;
using Microsoft.VisualBasic;
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
    public partial class AdminAvailAppt : Form
    {
        private Controller ContObj;

        private Form1 Caller;
        public AdminAvailAppt(Form1 PCaller)
        {
            InitializeComponent();
            ContObj = new Controller();

            Caller = PCaller;

            HideAllErrorLabels();

            Availabilities_dgv.DataSource = ContObj.GetAllUpcomingAvailabilities(false);
            Appointments_dgv.DataSource = ContObj.GetAllPastAppointments(false);
        }

        private void HideAllErrorLabels()
        {
            SelectionError_lb.Hide();
            AlreadyConfirmed_lb.Hide();
        }
        private void ConfirmPayment_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();

            if (Appointments_dgv.SelectedRows == null)
                SelectionError_lb.Show();
            else if (Appointments_dgv.SelectedRows[2].Equals(1))
                AlreadyConfirmed_lb.Show();
            else
            {
                ContObj.ConfirmPayment(Appointments_dgv.SelectedRows[3].ToString());
                Appointments_dgv.DataSource = ContObj.GetAllPastAppointments(ShowPaid_cb.Checked);
                Appointments_dgv.Refresh();
                Availabilities_dgv.DataSource = ContObj.GetAllUpcomingAvailabilities(ShowBooked_cb.Checked);
                Availabilities_dgv.Refresh();
            }
        }

        private void ShowPaid_cb_CheckedChanged(object sender, EventArgs e)
        {
            Appointments_dgv.DataSource = ContObj.GetAllPastAppointments(ShowPaid_cb.Checked);
            Appointments_dgv.Refresh();
        }

        private void ShowBooked_cb_CheckedChanged(object sender, EventArgs e)
        {
            Availabilities_dgv.DataSource = ContObj.GetAllUpcomingAvailabilities(ShowBooked_cb.Checked);
            Availabilities_dgv.Refresh();
        }

        private void Back_bt_Click(object sender, EventArgs e)
        {
            Caller.Show();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
