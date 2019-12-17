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
    public partial class Pharmacist_Portal : Form
    {
        public Pharmacist_Portal()
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

        private void Pharmacist_Portal_Load(object sender, EventArgs e)
        {
            buttonPharmHome.BackColor = Color.FromArgb(41, 39, 40);
            userControlPharmHome1.BringToFront();
        }

        private void buttonPharmHome_Click(object sender, EventArgs e)
        {
            buttonPharmHome.BackColor= Color.FromArgb(41, 39, 40);
            buttonPharmIssue.BackColor= Color.Black;
            buttonPharmOrder.BackColor= Color.Black;
            buttonPharmAdd.BackColor= Color.Black;
            ////////////////////////////////////
            userControlPharmHome1.BringToFront();

        }

        private void buttonPharmAdd_Click(object sender, EventArgs e)
        {
            buttonPharmAdd.BackColor= Color.FromArgb(41, 39, 40);
            buttonPharmHome.BackColor = Color.Black;
            buttonPharmIssue.BackColor = Color.Black;
            buttonPharmOrder.BackColor = Color.Black;
            ////////////////////////////////////
            userControlPharmAdd1.BringToFront();
        }

        private void buttonPharmIssue_Click(object sender, EventArgs e)
        {
            buttonPharmIssue.BackColor= Color.FromArgb(41, 39, 40);
            buttonPharmHome.BackColor = Color.Black;
            buttonPharmOrder.BackColor = Color.Black;
            buttonPharmAdd.BackColor = Color.Black;
            ////////////////////////////////////
            userControlPharmIssue1.BringToFront();
        }

        private void buttonPharmOrder_Click(object sender, EventArgs e)
        {
            buttonPharmOrder.BackColor= Color.FromArgb(41, 39, 40);
            buttonPharmAdd.BackColor = Color.Black;
            buttonPharmHome.BackColor = Color.Black;
            buttonPharmIssue.BackColor = Color.Black;
            ////////////////////////////////////
            userControlPharmOrder1.BringToFront();
        }
    }
}
