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
    public partial class AvailableVaccines : Form
    {
        private Controller ContObj;

        private Form1 Caller;
        public AvailableVaccines(Form1 PCaller)
        {
            InitializeComponent();
            ContObj = new Controller();

            Caller = PCaller;

            HideAllErrorLabels();

            Vaccine_dgv.DataSource = ContObj.GetAllVaccineStock();
            Vaccine_dgv.Refresh();
            Requirements_dgv.DataSource = ContObj.GetAllVaccineRequirements();
            Requirements_dgv.Refresh();
            AddReqVaccine_cmb.DataSource = ContObj.GetVaccinesWithoutRequirements();
            AddReqVaccine_cmb.DisplayMember = "Trade_Name";
            AddReqVaccine_cmb.Refresh();
            Species_cmb.DataSource = ContObj.GetAllSpeciesCommonNames();
            Species_cmb.DisplayMember = "Common_Name";
            Species_cmb.Refresh();
            UpdateStockVaccine_cmb.DataSource = ContObj.GetAllVaccineNames();
            UpdateStockVaccine_cmb.DisplayMember = "Trade_Name";
            UpdateStockVaccine_cmb.Refresh();
        }

        private void HideAllErrorLabels()
        {
            EmptyField_lb.Hide();
            YearsError_lb.Hide();
            StockError_lb.Hide();
            NameError_lb.Hide();
            CodeError_lb.Hide();
        }

        private void AddVaccine_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();

            if (AddCode_tb.Text == "" || AddName_tb.Text == "" || AddManufacturer_tb.Text == "" || AddDisease_tb.Text == "" || AddStock_tb.Text == "")
                EmptyField_lb.Show();
            else if (Convert.ToInt16(AddStock_tb.Text) < 0)
                StockError_lb.Show();
            else
            {
                int Success = ContObj.AddVaccine(Convert.ToInt16(AddCode_tb.Text), AddName_tb.Text, AddManufacturer_tb.Text, AddDisease_tb.Text, Convert.ToInt16(AddStock_tb.Text), AddExpiry_dtpck.Value.Date.ToString());
                switch (Success)
                {
                    case 0:
                        Vaccine_dgv.DataSource = ContObj.GetAllVaccineStock();
                        Vaccine_dgv.Refresh();
                        AddReqVaccine_cmb.DataSource = ContObj.GetVaccinesWithoutRequirements();
                        AddReqVaccine_cmb.DisplayMember = "Trade_Name";
                        AddReqVaccine_cmb.Refresh();
                        UpdateStockVaccine_cmb.DataSource = ContObj.GetAllVaccineNames();
                        UpdateStockVaccine_cmb.DisplayMember = "Trade_Name";
                        UpdateStockVaccine_cmb.Refresh();
                        break;
                    case 1:
                        NameError_lb.Show();
                        break;
                    case 2:
                        CodeError_lb.Show();
                        break;
                }
            }
        }

        private void AddReq_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();

            if (Years_tb.Text == "")
                EmptyField_lb.Show();
            else if (Convert.ToInt16(Years_tb.Text) < 0)
                YearsError_lb.Show();
            else
            {
                ContObj.AddRequirement(AddReqVaccine_cmb.SelectedText, Species_cmb.SelectedText, Years_tb.Text, Months_cmb.SelectedText);
                Requirements_dgv.DataSource = ContObj.GetAllVaccineRequirements();
                Requirements_dgv.Refresh();
            }
        }

        private void UpdateStock_bt_Click(object sender, EventArgs e)
        {
            HideAllErrorLabels();

            if (UpdateStock_tb.Text == "")
                EmptyField_lb.Show();
            else if (Convert.ToInt16(UpdateStock_tb.Text) < 0)
                StockError_lb.Show();
            else
            {
                ContObj.UpdateVaccineStock(UpdateStockVaccine_cmb.SelectedText, UpdateStock_tb.Text, UpdateExpiry_dtpck.Value.Date.ToString());
                Vaccine_dgv.DataSource = ContObj.GetAllVaccineStock();
                Vaccine_dgv.Refresh();
            }
        }

        private void Back_bt_Click(object sender, EventArgs e)
        {
            Caller.Show();
            this.Close();
        }

        private void Vaccine_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
