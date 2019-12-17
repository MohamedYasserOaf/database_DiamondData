using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_database
{ 
    public partial class Doctor_Portal : Form
    {
        public Doctor_Portal()
        {
            InitializeComponent();
        }

        private void Doctor_Portal_Load(object sender, EventArgs e)
        {
            userControlDocHome1.BringToFront();
            buttonHome.BackColor = Color.FromArgb(41, 39, 40);
        }

        private void buttonExitDoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinDoc_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonHome.BackColor = Color.FromArgb(41, 39, 40);
            //////////////////////////////////////
            buttonPatientInfo.BackColor = Color.Black;
            buttonSchedule.BackColor = Color.Black;
            buttonDiagnosis.BackColor = Color.Black;
            ////////////////////////////////////////
            userControlDocHome1.BringToFront();

        }

        private void buttonPatientInfo_Click(object sender, EventArgs e)
        {
            buttonPatientInfo.BackColor = Color.FromArgb(41, 39, 40);
            ////////////////////////////////////////
            buttonSchedule.BackColor = Color.Black;
            buttonDiagnosis.BackColor = Color.Black;
            buttonHome.BackColor = Color.Black;
            ////////////////////////////////////////
            userControlPatientInfo1.BringToFront();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            buttonSchedule.BackColor = Color.FromArgb(41, 39, 40);
            /////////////////////////////////////////
            buttonDiagnosis.BackColor = Color.Black;
            buttonHome.BackColor = Color.Black;
            buttonPatientInfo.BackColor = Color.Black;
            /////////////////////////////////////////
            userControlSchedule1.BringToFront();
        }

        private void buttonDiagnosis_Click(object sender, EventArgs e)
        {
            buttonDiagnosis.BackColor = Color.FromArgb(41, 39, 40);
            /////////////////////////////////////
            buttonHome.BackColor = Color.Black;
            buttonPatientInfo.BackColor = Color.Black;
            buttonSchedule.BackColor = Color.Black;
            /////////////////////////////////////
            userControlDiagnosis1.BringToFront();
        }

        private void userControlDiagnosis1_Load(object sender, EventArgs e)
        {

        }
    }
}
