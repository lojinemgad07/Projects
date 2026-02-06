using DataBaseProjectPawell;
using Guna.UI2.AnimatorNS;
using System.Windows.Forms.DataVisualization.Charting;
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
    public partial class HospitalStatistics : Form
    {
        private Controller ContObj;

        private Form1 Caller;

        public HospitalStatistics(Form1 PCaller)
        {
            InitializeComponent();
            ContObj = new Controller();

            Caller = PCaller;

            ChartSetup();

            StatLoad();
        }

        private void ChartSetup()
        {
            //Avail_ch.DataSource = ContObj.GetAvailabilitiesOverTime();
            //Appt_ch.DataSource = ContObj.GetAppointmentsOverTime();
            //Vaccine_ch.DataSource = ContObj.GetAllVaccineStock();
            //Bank_ch.DataSource = ContObj.GetCustomerBanks();
            Appt_ch.DataSource = ContObj.GetAllVaccineStock();
            Bank_ch.DataSource = ContObj.GetAllVaccineStock();

            Appt_ch.Series.Add("Vaccine Stock");
            Appt_ch.Series["Vaccine Stock"].ChartType = SeriesChartType.Column;
            Appt_ch.Series["Vaccine Stock"].XValueMember = "Trade_Name";
            Appt_ch.Series["Vaccine Stock"].YValueMembers = "Stock_Number";
            Appt_ch.Titles.Add("Vaccine Stock");
            Appt_ch.Series["Vaccine Stock"].AxisLabel = "Trade Name";

            Bank_ch.Series.Add("Vaccine Stock");
            Bank_ch.Series["Vaccine Stock"].ChartType = SeriesChartType.Bar;
            Bank_ch.Series["Vaccine Stock"].XValueMember = "Trade_Name";
            Bank_ch.Series["Vaccine Stock"].YValueMembers = "Stock_Number";
            Bank_ch.Titles.Add("Vaccine Stock");
            Bank_ch.Series["Vaccine Stock"].AxisLabel = "Trade Name";
            /*
            Avail_ch.Series.Add("Animals Per Vet");
            Avail_ch.Series["Animals Per Vet"].ChartType = SeriesChartType.StepLine;
            Avail_ch.Series["Animals Per Vet"].XValueMember = "VetSSN";
            Avail_ch.Series["Animals Per Vet"].YValueMembers = "AnC";
            Avail_ch.Titles.Add("Animals Per Vet");
            Avail_ch.Series["Animals Per Vet"].AxisLabel = "Date";

            Appt_ch.Series.Add("Past Appointments");
            Appt_ch.Series["Past Appointments"].ChartType = SeriesChartType.StepLine;
            Appt_ch.Series["Past Appointments"].XValueMember = "[Date]";
            Appt_ch.Series["Past Appointments"].YValueMembers = "ApptCount";
            Appt_ch.Titles.Add("Past Appointments");
            Appt_ch.Series["Past Appointments"].AxisLabel = "Date";

            
            Vaccine_ch.Series.Add("Vaccine Stock");
            Vaccine_ch.Series["Vaccine Stock"].ChartType = SeriesChartType.Column;
            Vaccine_ch.Series["Vaccine Stock"].XValueMember = "Trade_Name";
            Vaccine_ch.Series["Vaccine Stock"].YValueMembers = "Stock_Number";
            Vaccine_ch.Titles.Add("Vaccine Stock");
            Vaccine_ch.Series["Vaccine Stock"].AxisLabel = "Trade Name";
            */
            /*
            Bank_ch.Series.Add("Associated Banks");
            Bank_ch.Series["Associated Banks"].ChartType = SeriesChartType.Pie;
            Bank_ch.Series["Associated Banks"].XValueMember = "Bank";
            Bank_ch.Series["Associated Banks"].YValueMembers = "CustNum";
            Bank_ch.Titles.Add("Associated Banks");

            Avail_ch.Refresh();
            Appt_ch.Refresh();
            Vaccine_ch.Refresh();
            Bank_ch.Refresh();
            */
        }

        private void StatLoad()
        {
            AvailTotal_tb.Text = ContObj.GetTotalUpcomingAvailabilities();
            AvailAvg_tb.Text = ContObj.GetAverageUpcomingAvailabilities();
            ApptTotal_tb.Text = ContObj.GetTotalPastAppointments();
            ApptAvg_tb.Text = ContObj.GetAveragePastAppointments();

            MinStock_tb.Text = ContObj.GetMinVaccineStock();
            MaxStock_tb.Text = ContObj.GetMaxVaccineStock();
            MinImm_tb.Text = ContObj.GetMinCompletedImmunizations();
            MaxImm_tb.Text = ContObj.GetMaxCompletedImmunizations();
            AvgImm_tb.Text = ContObj.GetAvgCompletedImmunizations();
            TotalImm_tb.Text = ContObj.GetTotalCompletedImmunizations();

            CustBank_tb.Text = ContObj.GetMajorityCustBank();
            EmpBank_tb.Text = ContObj.GetMajorityEmpBank();
            CustAnimals_tb.Text = ContObj.GetAvgAnimalsPerCustomer();
            MinCost_tb.Text = ContObj.GetMinApptCost();
            MaxCost_tb.Text = ContObj.GetMaxApptCost();
            AvgImm_tb.Text = ContObj.GetAvgApptCost();
            Revenue_tb.Text = ContObj.GetTotalRevenue();
        }

        private void Back_bt_Click(object sender, EventArgs e)
        {
            Caller.Show();
            this.Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
