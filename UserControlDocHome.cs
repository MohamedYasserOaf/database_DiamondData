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
    public partial class UserControlDocHome : UserControl
    {
        string date;
        int H1, H2, M1, M2, S1, S2;
        Controller controllerObj;

        public UserControlDocHome()
        {
            InitializeComponent();
            controllerObj = new Controller();
            timer1.Start();
        }

        private void UserControlDocHome_Load(object sender, EventArgs e)
        {
          /*  timer1.Start();             //start timer


            object appoint = controllerObj.GetNextAppointmentTime();            //Next appointment time (the table sorted asc by date and time)
            TimeSpan apptime = (TimeSpan)appoint;
            string apptimestr = Convert.ToString(apptime);
            textBoxNxtAppoint.Text = apptimestr;


            int H1Nextapp= Convert.ToInt16(apptimestr[0] - '0');        //next appointment time is split to integers
            int H2Nextapp= Convert.ToInt16(apptimestr[1] - '0');
            int M1Nextapp= Convert.ToInt16(apptimestr[3] - '0');
            int M2Nextapp= Convert.ToInt16(apptimestr[4] - '0');
            int S1Nextapp= Convert.ToInt16(apptimestr[6] - '0');
            int S2Nextapp= Convert.ToInt16(apptimestr[7] - '0');


            object apptype = controllerObj.GetNextAppointmentType();            //Next appointment type
            textBoxAppointType.Text = (string)apptype;

            if (H1 == H1Nextapp && H2 == H2Nextapp && M1 == M1Nextapp && M2 == M2Nextapp && S1 == S1Nextapp && S2 == S2Nextapp) {
                timer1.Stop();
                int rowsaff = controllerObj.DeleteLastAppointment();
                timer1.Start();
            }*/

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string DateFormat = "HH:mm:ss";
            string date = DateTime.Now.ToString(DateFormat);
             H1 = Convert.ToInt16(date[0] - '0');        //current date is split to integers
             H2 = Convert.ToInt16(date[1] - '0');
             M1 = Convert.ToInt16(date[3] - '0');
             M2 = Convert.ToInt16(date[4] - '0');
             S1 = Convert.ToInt16(date[6] - '0');
             S2 = Convert.ToInt16(date[7] - '0');

            object appoint = controllerObj.GetNextAppointmentTime();            //Next appointment time (the table sorted asc by date and time)
            TimeSpan apptime = (TimeSpan)appoint;
            string apptimestr = Convert.ToString(apptime);
            textBoxNxtAppoint.Text = apptimestr;


            int H1Nextapp = Convert.ToInt16(apptimestr[0] - '0');        //next appointment time is split to integers
            int H2Nextapp = Convert.ToInt16(apptimestr[1] - '0');
            int M1Nextapp = Convert.ToInt16(apptimestr[3] - '0');
            int M2Nextapp = Convert.ToInt16(apptimestr[4] - '0');
            int S1Nextapp = Convert.ToInt16(apptimestr[6] - '0');
            int S2Nextapp = Convert.ToInt16(apptimestr[7] - '0');


            object apptype = controllerObj.GetNextAppointmentType();            //Next appointment type
            textBoxAppointType.Text = (string)apptype;

            if (H1 == H1Nextapp && H2 == H2Nextapp && M1 == M1Nextapp && M2 == M2Nextapp && S1 == S1Nextapp && S2 == S2Nextapp)
            {
                timer1.Stop();
                int rowsaff = controllerObj.DeleteLastAppointment();
                timer1.Start();
            }
            
        }
    }
}
