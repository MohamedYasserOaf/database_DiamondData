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
    public partial class UserControlPharmAdd : UserControl
    {
        Controller controllerObj;
        public UserControlPharmAdd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlPharmAdd_Load(object sender, EventArgs e)
        {
            textBoxPharmOrderExpiryDate.Text = Convert.ToString(DateTime.Today);
        }

        private void buttonPharmAddMedicine_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int result = controllerObj.InsertMedicine(Convert.ToInt32(textBoxID.Text),textBoxPharmAddNewMedName.Text, Convert.ToInt32(textBoxPharmAddAutoQty.Text), 0 , Convert.ToInt32(textBoxPharmAddWhenToOrd.Text), Convert.ToInt32(textBoxPharmAddPrice.Text));
    

        }
    }
}
