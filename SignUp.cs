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
    public partial class SignUp : Form
    {
        Form parentglobal;
        public SignUp(Form Parent)
        {
            InitializeComponent();
                Parent.Hide();
                parentglobal = Parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parentglobal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = comboBoxUserType.Text;
            if (type == "Doctor")
            {
                textBoxFirstName.Enabled = false;
                textBoxMidName.Enabled = false;
                textBoxLastName.Enabled = false;
            }
            else
            {
                textBoxFirstName.Enabled = true;
                textBoxMidName.Enabled = true;
                textBoxLastName.Enabled = true;
            }
        }
    }
}
