using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_database
{
    public partial class UserControlPatientInfo : UserControl
    {
        Controller controllerObj;
        public UserControlPatientInfo()
        {
            InitializeComponent();
        }

        private void UserControlPatientInfo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearchMedHistory_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            object Pname = controllerObj.GetPatientName(Convert.ToInt32(textBoxID.Text));
            textBoxPatientName.Text = Pname.ToString();
            object Page = controllerObj.GetPatientAge(Convert.ToInt32(textBoxID.Text));
            textBoxPatientAge.Text = Page.ToString();
            object Pgender = controllerObj.GetPatientGender(Convert.ToInt32(textBoxID.Text));
            gender.Text = Pgender.ToString();

            DataTable past_diagnosis = controllerObj.GetPastDiagnosis(Convert.ToInt32(textBoxID.Text));
            pastdiagnosis.DataSource=past_diagnosis;  pastdiagnosis.Refresh();

            DataTable taken_meds = controllerObj.GetTakenMeds(Convert.ToInt32(textBoxID.Text));
            takenmeds.DataSource = taken_meds; takenmeds.Refresh();

            DataTable allergies = controllerObj.GetAllergies(Convert.ToInt32(textBoxID.Text));
            Allergies.DataSource = allergies; Allergies.Refresh();

            DataTable past_surgery = controllerObj.GetPastSurgeries(Convert.ToInt32(textBoxID.Text));
            pastSurgeries.DataSource = past_surgery; pastSurgeries.Refresh();

        }
    }
}
