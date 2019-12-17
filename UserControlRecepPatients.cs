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
    public partial class UserControlRecepPatients : UserControl
    {
        Controller controllerObj;
        public UserControlRecepPatients()
        {
            InitializeComponent();

        }

        private void buttonRecepPatientsFilter_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            DataTable PatientInfo = controllerObj.GetPtientInfo(Convert.ToInt32(textBoxRecepPatientID.Text));
            dataGridViewFilterPatients.DataSource = PatientInfo; dataGridViewFilterPatients.Refresh();
        }

        private void buttonRecepPatientsEdit_Click(object sender, EventArgs e)
        {
            Controller controllerObj = new Controller();
            int row, column;
            row = Convert.ToInt32(dataGridViewFilterPatients.SelectedRows);
            column = Convert.ToInt32(dataGridViewFilterPatients.SelectedColumns);
            // controllerObj.updatePatientInfo();

        }
    }
}
