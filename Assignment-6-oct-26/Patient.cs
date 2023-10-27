using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class Patient
    {
        public int PatientId;
        public string? PatientName;
        public int Age;
        public string? Diagnosis;

        public Patient(int patientId, string? patientName, int age, string? diagnosis)
        {
            PatientId = patientId;
            PatientName = patientName;
            Age = age;
            Diagnosis = diagnosis;
        }

        public Patient()
        {
        }

        public static List<Patient> PatientsList = new List<Patient>();
        public void AddPatient(int patientId, string? patientName, int age, string? diagnosis)
        {
            Patient patient = new Patient();
            patient.PatientId = patientId;
            patient.PatientName = patientName;
            patient.Age = age;
            patient.Diagnosis = diagnosis;
            PatientsList.Add(patient);

        }
        public void ReadPatient()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\patient6.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string Records=sr.ReadToEnd();
            Console.WriteLine(Records);
            sr.Close();
            fs.Close();

        }
        public void WritePatient()
        {
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Desktop\\patient6.txt",
               FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
           
            foreach ( Patient patient in PatientsList )
            {
                sw.WriteLine("Patient id : {0} Patient Name : {1} patient Diagnosis : {2} Age :{3} ",patient.PatientId,patient.PatientName,patient.Diagnosis,patient.Age);
            }
           string? str = PatientsList[0].ToString();
           //string? str = "Patient id : {0} Patient Name : {1} patient Diagnosis : {2} Total Cost :{3} ", PatientsList[0];
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        public void CheckAge(int age)
        {
            if (Age > 0&&Age<=120)
            {
                Console.WriteLine("You have entered the correct age ");
            }
            else
            {
                throw new AgeCheck(PatientExceptionHandling.exmess["Age"]);
            }
        }
        public void CheckName(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                throw new NameCheck(PatientExceptionHandling.exmess["Name"]);
            }
            else
            {
                Console.WriteLine("You have entered the correct name");
            }
        }
        public void CheckDiagnosis(string diagnosis)
        {
            if (string.IsNullOrEmpty(diagnosis))
            {
                throw new daiagnosisCheck(PatientExceptionHandling.exmess["Daiagnosis"]);
            }
            else
            {
                Console.WriteLine("Your Diagnosis cannot be null or empty");
            }
        }

    }
}
