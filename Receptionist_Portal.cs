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
    public partial class Receptionist_Portal : Form
    {
        public Receptionist_Portal()
        {
            InitializeComponent();
        }

        private void buttonExitDoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinDoc_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Receptionist_Portal_Load(object sender, EventArgs e)
        {
            buttonRecepHome.BackColor = Color.FromArgb(41, 39, 40);
            userControlRecepHome1.BringToFront();
        }

        private void buttonRecepReserve_Click(object sender, EventArgs e)
        {
            buttonRecepHome.BackColor = Color.Black;
            buttonRecepReserve.BackColor= Color.FromArgb(41, 39, 40);
            buttonRecepPayment.BackColor= Color.Black;
            buttonRecepPatient.BackColor= Color.Black;
            //////////////////////////////////////////
            userControlRecepReserve1.BringToFront();

        }

        private void buttonRecepPatient_Click(object sender, EventArgs e)
        {
            buttonRecepPatient.BackColor= Color.FromArgb(41, 39, 40);
            buttonRecepHome.BackColor= Color.Black;
            buttonRecepPayment.BackColor= Color.Black;
            buttonRecepReserve.BackColor= Color.Black;
            //////////////////////////////////////////
            userControlRecepPatients1.BringToFront();
        }

        private void buttonRecepHome_Click(object sender, EventArgs e)
        {
            buttonRecepHome.BackColor = Color.FromArgb(41, 39, 40);
            buttonRecepPatient.BackColor= Color.Black;
            buttonRecepPayment.BackColor= Color.Black;
            buttonRecepReserve.BackColor= Color.Black;
            //////////////////////////////////////////
            userControlRecepHome1.BringToFront();
        }

        private void buttonRecepPayment_Click(object sender, EventArgs e)
        {
            buttonRecepPayment.BackColor = Color.FromArgb(41, 39, 40);
            buttonRecepReserve.BackColor = Color.Black;
            buttonRecepPatient.BackColor = Color.Black;
            buttonRecepHome.BackColor = Color.Black;
            //////////////////////////////////////////
            userControlRecepPayment1.BringToFront();
        }
    }
}
