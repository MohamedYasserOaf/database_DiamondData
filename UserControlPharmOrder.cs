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
    public partial class UserControlPharmOrder : UserControl
    {
        public UserControlPharmOrder()
        {
            InitializeComponent();

        }

        private void UserControlPharmOrder_Load(object sender, EventArgs e)
        {

        }

        private void buttonPharmOrderReserList_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            dataGridViewMedsStock.DataSource = controllerObj.GetFinishingMeds();
            dataGridViewMedsStock.Refresh();
        }
    }
}
