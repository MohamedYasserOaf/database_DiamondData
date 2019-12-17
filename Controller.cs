using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Project_database
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        /*--------------------- Queries ------------------------------------*/
        /*--------------------- Doctors -------------------------*/
        public DataTable GetPastDiagnosis(int ID) {
            string query = "select Past_Diagnosis from Patient_Past_Diagnosis where P_ID =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetTakenMeds(int ID)
        {
            string query = "select Patient_Medication from Patient_Medication where P_ID =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetAllergies(int ID)
        {
            string query = "select ALLERGIES from Patient_Allergies where P_ID =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable GetPastSurgeries(int ID)
        {
            string query = "select Past_Surgeries from Patient_Past_Surgeries where P_ID =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }
        public  object  GetPatientName(int ID)
        {
            string query = "select Fname from Patient where P_ID =" + ID + ";";
            return dbMan.ExecuteScalar(query);
        }
        public object GetPatientAge(int ID)
        {
            string query = "select Age from Patient where P_ID =" + ID + ";";
            return dbMan.ExecuteScalar(query);
        }
        public object GetPatientGender(int ID)
        {
            string query = "select Gender from Patient where P_ID =" + ID + ";";
            return dbMan.ExecuteScalar(query);
        }
        public object GetNextAppointmentTime() {
            string query = "select top 1 [TIME] from Appointment order by [DATE],[TIME] ASC";
            return dbMan.ExecuteScalar(query);
        }
        public object GetNextAppointmentType() {
            string query = "select top 1 [TYPE] from Appointment";
            return dbMan.ExecuteScalar(query);
        }
        public int DeleteLastAppointment() {
            string query = "delete Top (1) from Appointment  where [TIME] in (select top 1[TIME] from Appointment order by[DATE],[TIME] ASC)";
            return dbMan.ExecuteNonQuery(query);
        }
        /*------------------------------------------------------------------------------------*/
        /*-------------------------------- RECEPTIONIST --------------------------------------*/
        public DataTable GetPtientInfo(int ID)
        {
            string query = "select * from Patient where P_ID =" + ID + ";";
            return dbMan.ExecuteReader(query);
        }

            
        public int updatePatientInfo(int ID, int column,string data)
        {
            if(column == 1)
            {
                string query = "update patient set Fname =" + data + "where P_ID=" + ID + ";";
                return dbMan.ExecuteNonQuery(query);
            }
            else if (column == 2)
            {
                string query = "update patient set Mname =" + data + "where P_ID=" + ID + ";";
                return dbMan.ExecuteNonQuery(query);
            }
            else if (column == 3)
            {
                string query = "update patient set Lname  =" + data + "where P_ID=" + ID + ";";
                return dbMan.ExecuteNonQuery(query);
            }
            else if (column == 4)
            {
                string query = "update patient set Gender  =" + data + "where P_ID=" + ID + ";";
                return dbMan.ExecuteNonQuery(query);
            }
            else
            {
                string query = "update patient set Age  =" + data + "where P_ID=" + ID + ";";
                return dbMan.ExecuteNonQuery(query);
            }
        }
        /*-----------------------------------------PHARMASIST ---------------------------------------*/
        /*public object*/ 
        public int InsertMedicine(int ID,string name,int DefaultAmount,int num,int MinNum,int price)
        {
            string query = "Insert into Medicine (M_ID,M_name,default_order_number,Number,Warning_number,price) values (" + ID + ",'" + name + "'," + DefaultAmount +","+ num+ "," + MinNum + "," + price + ");";
            return dbMan.ExecuteNonQuery(query);
        }
        public DataTable GetFinishingMeds()
        {
            string query = "select * from Medicine where Number < Warning_number";
            return dbMan.ExecuteReader(query);
        }
    }
}
