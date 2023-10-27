using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class MedicalHistory : MedicalRecords
    {
        
        public string? Description {  get; set; }
        public int Date {  get; set; }
        public static List<MedicalHistory> medicalHistoryList = new List<MedicalHistory>(); 

        public void AddMedicalHistory(int RecordId,int PatientId,string Description ,int date)
        {
           MedicalHistory medicalHistory = new MedicalHistory();
            medicalHistory.RecordId = RecordId;
            medicalHistory.PatientId = PatientId;
            medicalHistory.Description = Description;
            medicalHistory.Date = date;
            medicalHistoryList.Add(medicalHistory); 

        }
        public void ReadMedicalHistory()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\MedicalHistory2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string Records = sr.ReadToEnd();
            Console.WriteLine(Records);
            sr.Close();
            fs.Close();

        }
        public void WriteMedicalHistory()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\MedicalHistory2.txt",
               FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            foreach (var medicalHistory in medicalHistoryList)
            {
                sw.WriteLine("Patient id : {0} Record id : {1} Description : {2} Date :{3} ", medicalHistory.RecordId, medicalHistory.PatientId, medicalHistory.Description, medicalHistory.Date);
            }
           // string? str = PatientsList[0].ToString();
            //string? str = "Patient id : {0} Patient Name : {1} patient Diagnosis : {2} Total Cost :{3} ", PatientsList[0];
           // sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
