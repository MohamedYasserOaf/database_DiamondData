using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_database.Encryption;

namespace Project_database
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text == "1") { 
            Doctor_Portal D = new Doctor_Portal();
            D.Show();
        }
            if (textBoxID.Text == "2")
            {
                Receptionist_Portal R = new Receptionist_Portal();
                R.Show();
            }
            if (textBoxID.Text == "3")
            {
                Pharmacist_Portal P = new Pharmacist_Portal();
                P.Show();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void labelSignUp_Click(object sender, EventArgs e)
        {
            SignUp S = new SignUp(this);
            S.Show();
        }
    }
}
