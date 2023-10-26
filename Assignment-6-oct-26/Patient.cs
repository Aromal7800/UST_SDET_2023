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
