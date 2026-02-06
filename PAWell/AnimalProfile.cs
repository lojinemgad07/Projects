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
    public partial class AnimalProfile : Form
    {
        private Controller ContObj;

        private CustomerOptions Caller;
        private string CustomerID;
        public AnimalProfile(CustomerOptions PCaller, int PCustomerID)
        {
            InitializeComponent();
            ContObj = new Controller();

            Caller = PCaller;
            CustomerID = PCustomerID.ToString();

            DataTable AnimalsDT = ContObj.RetrieveAnimals(Convert.ToInt16(CustomerID));
            Animal_cmb.DataSource = AnimalsDT;
            Animal_cmb.DisplayMember = "A_Name";
            Animal_cmb.ValueMember = "A_Name";
        }

        private void Animal_cmb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string AnimalName = Animal_cmb.SelectedText;
            if (AnimalName != "")
            {
                /*
                DataTable dt = ContObj.GetAnimalBirthDate(CustomerID, AnimalName);
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dt;
                DateTime BirthDate = Convert.ToDateTime(dgv.Rows[0].Cells["Birth_Date"].Value);
                int Months = DateTime.Now.Month - BirthDate.Month;
                int Years = DateTime.Now.Year - BirthDate.Year;
                if (Months < 0)
                {
                    Months += 12;
                    Years -= 1;
                }
                Age_tb.Text = Years.ToString() + " yrs, " + Months.ToString() + " months";
                */
                Gender_tb.Text = ContObj.GetAnimalGender(CustomerID, AnimalName);
                CurrentWt_tb.Text = ContObj.GetCurrentWt(CustomerID, AnimalName);
                BirtthWt_tb.Text = ContObj.GetBirthWt(CustomerID, AnimalName);
                Species_tb.Text = ContObj.GetSpecies(CustomerID, AnimalName);
                Diet_tb.Text = ContObj.GetDiet(CustomerID, AnimalName);
                Breed_tb.Text = ContObj.GetBreed(CustomerID, AnimalName);
                AvgWt_tb.Text = ContObj.GetAvgBreedWt(CustomerID, AnimalName);
                LifeExp_tb.Text = ContObj.GetLifeExpectancy(CustomerID, AnimalName) + " yrs";

                Diagnoses_dgv.DataSource = ContObj.GetDiagnoses(CustomerID, AnimalName);
                Diagnoses_dgv.Refresh();
                Prescriptions_dgv.DataSource = ContObj.GetPrescriptions(CustomerID, AnimalName);
                Prescriptions_dgv.Refresh();
                Procedures_dgv.DataSource = ContObj.GetProcedures(CustomerID, AnimalName);
                Procedures_dgv.Refresh();

                CompletedVaccines_dgv.DataSource = ContObj.GetCompletedVaccines(CustomerID, AnimalName);
                CompletedVaccines_dgv.Refresh();
                PendingVaccines_dgv.DataSource = ContObj.GetPendingVaccines(CustomerID, AnimalName);
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
        private void Back_bt_Click(object sender, EventArgs e)
        {
            Caller.Show();
            this.Close();
        }

        private void Animal_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnimalProfile_Load(object sender, EventArgs e)
        {

        }

        private void Animal_cmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
