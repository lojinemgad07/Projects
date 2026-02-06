using DataBaseProjectPawell;
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
    public partial class MedicalRecords : Form
    {
        private Controller ContObj;

        private VetOptions Caller;
        private string VetID;
        private DataTable ApptInfo_dt;
        private string SelectedApptID, SelectedCustomerID, SelectedAnimalName;
        public MedicalRecords(VetOptions PCaller, int PVetID)
        {
            InitializeComponent();
            ContObj = new Controller();

            Caller = PCaller;
            VetID = PVetID.ToString();
            SelectedApptID = SelectedCustomerID = SelectedAnimalName = "";

            HideAllErrorLabels();

            ApptInfo_dt = ContObj.GetVetAppts(VetID);
            //ApptInfo_dt.Columns.Add("ApptInfo", typeof(string), " A_Name + [Date] + Start_Time");
            //Appt_cmb.DisplayMember = ApptInfo_dt.Columns[1] + " / " + ApptInfo_dt.Columns[2] + " / " + ApptInfo_dt.Columns[3];
            //Appt_cmb.DisplayMember = "ApptInfo";
            Appt_cmb.DataSource = ApptInfo_dt;
            Appt_cmb.DisplayMember = "A_Name";
            Appt_cmb.ValueMember = "AppointmentID";
        }

        private void HideAllErrorLabels()
        {
            EmptyField_lb.Hide();
        }
        private void Appt_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedApptID = Appt_cmb.SelectedValue.ToString();
            SelectedCustomerID = ContObj.GetApptCustomer(SelectedApptID);
            SelectedAnimalName = ApptInfo_dt.Rows[Appt_cmb.SelectedIndex][1].ToString();
            if (SelectedApptID != "")
            {
                /*
                DataTable dt = ContObj.GetAnimalBirthDate(SelectedCustomerID, SelectedAnimalName);
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dt;
                DateTime BirthDate = Convert.ToDateTime(dgv.Rows[0].Cells["Birth_Date"].Value);
                //DateTime BirthDate = Convert.ToDateTime(ContObj.GetAnimalBirthDate(SelectedCustomerID, SelectedAnimalName));
                int Months = DateTime.Today.Month - BirthDate.Month;
                int Years = DateTime.Today.Year - BirthDate.Year;
                if (Months < 0)
                {
                    Months += 12;
                    Years -= 1;
                }
                Age_tb.Text = Years.ToString() + " yrs, " + Months.ToString() + " months";
                */
                Gender_tb.Text = ContObj.GetAnimalGender(SelectedCustomerID, SelectedAnimalName);
                CurrentWt_tb.Text = ContObj.GetCurrentWt(SelectedCustomerID, SelectedAnimalName);
                BirtthWt_tb.Text = ContObj.GetBirthWt(SelectedCustomerID, SelectedAnimalName);
                Species_tb.Text = ContObj.GetSpecies(SelectedCustomerID, SelectedAnimalName);
                Diet_tb.Text = ContObj.GetDiet(SelectedCustomerID, SelectedAnimalName);
                Breed_tb.Text = ContObj.GetBreed(SelectedCustomerID, SelectedAnimalName);
                AvgWt_tb.Text = ContObj.GetAvgBreedWt(SelectedCustomerID, SelectedAnimalName);
                LifeExp_tb.Text = ContObj.GetLifeExpectancy(SelectedCustomerID, SelectedAnimalName) + " yrs";

                Diagnoses_dgv.DataSource = ContObj.GetDiagnoses(SelectedCustomerID, SelectedAnimalName);
                Diagnoses_dgv.Refresh();
                Prescriptions_dgv.DataSource = ContObj.GetPrescriptions(SelectedCustomerID, SelectedAnimalName);
                Prescriptions_dgv.Refresh();
                Procedures_dgv.DataSource = ContObj.GetProcedures(SelectedCustomerID, SelectedAnimalName);
                Procedures_dgv.Refresh();

                CompletedVaccines_dgv.DataSource = ContObj.GetCompletedVaccines(SelectedCustomerID, SelectedAnimalName);
                CompletedVaccines_dgv.Refresh();
                PendingVaccines_dgv.DataSource = ContObj.GetPendingVaccines(SelectedCustomerID, SelectedAnimalName);
                PendingVaccines_dgv.Refresh();
            }
            else
            {
                Age_tb.Text = "";
                Gender_tb.Text = "";
                CurrentWt_tb.Text = "";
                BirtthWt_tb.Text = "";
                Species_tb.Text = "";
                Diet_tb.Text = "";
                Breed_tb.Text = "";
                AvgWt_tb.Text = "";
                LifeExp_tb.Text = "";

                Diagnoses_dgv.DataSource = null;
                Diagnoses_dgv.Refresh();
                Prescriptions_dgv.DataSource = null;
                Prescriptions_dgv.Refresh();
                Procedures_dgv.DataSource = null;
                Procedures_dgv.Refresh();

                CompletedVaccines_dgv.DataSource = null;
                CompletedVaccines_dgv.Refresh();
                PendingVaccines_dgv.DataSource = null;
                PendingVaccines_dgv.Refresh();
            }
        }

        private void Type_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Record_cmb.DataSource = ContObj.GetRecords(SelectedCustomerID, SelectedAnimalName, Type_cmb.SelectedText);
            Record_cmb.DisplayMember = Type_cmb.SelectedText;
            Record_cmb.Refresh();
        }

        private void AddDiagnosis_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();
            if (NewDiagnosis_tb.Text == "")
                EmptyField_lb.Show();
            else
            {
                ContObj.AddDiagnosis(SelectedApptID, NewDiagnosis_tb.Text);
                Diagnoses_dgv.DataSource = ContObj.GetDiagnoses(SelectedCustomerID, SelectedAnimalName);
                Diagnoses_dgv.Refresh();
                Record_cmb.DataSource = ContObj.GetRecords(SelectedCustomerID, SelectedAnimalName, Type_cmb.SelectedText);
                Record_cmb.DisplayMember = Type_cmb.SelectedText;
                Record_cmb.Refresh();
            }
        }

        private void AddPrescription_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();
            if (NewPrescription_tb.Text == "")
                EmptyField_lb.Show();
            else
            {
                ContObj.AddPrescription(SelectedApptID, NewPrescription_tb.Text);
                Prescriptions_dgv.Refresh();
                Prescriptions_dgv.DataSource = ContObj.GetPrescriptions(SelectedCustomerID, SelectedAnimalName);
                Prescriptions_dgv.Refresh();
                Record_cmb.DataSource = ContObj.GetRecords(SelectedCustomerID, SelectedAnimalName, Type_cmb.SelectedText);
                Record_cmb.DisplayMember = Type_cmb.SelectedText;
                Record_cmb.Refresh();
            }
        }

        private void AddProcedure_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();
            if (NewProcedure_tb.Text == "")
                EmptyField_lb.Show();
            else
            {
                ContObj.AddProcedure(SelectedApptID, NewProcedure_tb.Text);
                Diagnoses_dgv.Refresh();
                Procedures_dgv.DataSource = ContObj.GetPrescriptions(SelectedCustomerID, SelectedAnimalName);
                Procedures_dgv.Refresh();
                Record_cmb.DataSource = ContObj.GetRecords(SelectedCustomerID, SelectedAnimalName, Type_cmb.SelectedText);
                Record_cmb.DisplayMember = Type_cmb.SelectedText;
                Record_cmb.Refresh();
            }
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();
            if (false) // edit later if validation required
                EmptyField_lb.Show();
            else
            {
                ContObj.DeleteRecord(SelectedCustomerID, SelectedAnimalName, Type_cmb.SelectedText, Record_cmb.SelectedText);
                Diagnoses_dgv.DataSource = ContObj.GetDiagnoses(SelectedCustomerID, SelectedAnimalName);
                Diagnoses_dgv.Refresh();
                Prescriptions_dgv.DataSource = ContObj.GetPrescriptions(SelectedCustomerID, SelectedAnimalName);
                Prescriptions_dgv.Refresh();
                Procedures_dgv.DataSource = ContObj.GetProcedures(SelectedCustomerID, SelectedAnimalName);
                Procedures_dgv.Refresh();
                Record_cmb.DataSource = ContObj.GetRecords(SelectedCustomerID, SelectedAnimalName, Type_cmb.SelectedText);
                Record_cmb.DisplayMember = Type_cmb.SelectedText;
                Record_cmb.Refresh();
            }
        }

        private void Update_bt_Click(object sender, EventArgs e)
        {

        }

        private void AddVaccine_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();
            if (false) // edit later if validation required
                EmptyField_lb.Show();
            else
            {
                ContObj.AddImmunization(SelectedApptID, SelectedCustomerID, SelectedAnimalName, Vaccine_cmb.SelectedText);
                CompletedVaccines_dgv.DataSource = ContObj.GetCompletedVaccines(SelectedCustomerID, SelectedAnimalName);
                CompletedVaccines_dgv.Refresh();
                PendingVaccines_dgv.DataSource = ContObj.GetPendingVaccines(SelectedCustomerID, SelectedAnimalName);
                PendingVaccines_dgv.Refresh();
            }
        }

        private void UpdateWt_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();
            CurrentWt_tb.BackColor = Color.White;
            if (CurrentWt_tb.Text == "")
                EmptyField_lb.Show();
            else
            {
                ContObj.UpdateWt(SelectedCustomerID, SelectedAnimalName, CurrentWt_tb.Text);
                CurrentWt_tb.BackColor = Color.LightSkyBlue;
                CurrentWt_tb.Text = ContObj.GetCurrentWt(SelectedCustomerID, SelectedAnimalName);
                CurrentWt_tb.Refresh();
            }
        }

        private void Appt_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MedicalRecords_Load(object sender, EventArgs e)
        {

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
