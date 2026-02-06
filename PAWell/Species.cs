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
    public partial class Species : Form
    {
        Controller controllerobj;
        public Species()
        {
            InitializeComponent();
            controllerobj = new Controller();
            ErrorSpecies.Visible = false;
            ErrorBreed.Visible = false;
        }

        private void PersonalInfo_Click(object sender, EventArgs e)
        {

        }

        private void AddSpecies_Click(object sender, EventArgs e)
        {
            int result=controllerobj.InsertSpecies(name.Text,genus.Text,spec.Text,Class.Text,Diet.Text);
            if (result == 0)
                ErrorSpecies.Visible = true;
            else
            {
                MessageBox.Show("Species added succesfully");
                ErrorSpecies.Visible = false;

            }

        }

        private void AddBreed_Click(object sender, EventArgs e)
        {
            int result=controllerobj.InsertBreed(breedname.Text,specname.Text,Convert.ToDouble(avgweight.Text),Convert.ToInt16(lifexpectancy.Text));
            if (result == 0)
                ErrorBreed.Visible = true;
            else
            {
                MessageBox.Show("Breed added succesfully");
                ErrorBreed.Visible = false;
            }
        }
    }
}
