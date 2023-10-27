using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_6_oct_26
{
    internal class MedicalRecords : Patient
    {
        public int RecordId { get; set; }   
        public int TreatmentCost {  get; set; }
       public static List<MedicalRecords> medicalRecordsList=new List<MedicalRecords>();
        public void AddMedicalRecord(int recID,string Name,string Diagnosis,int treatmentCost)
        {
            MedicalRecords medicalRecord = new MedicalRecords();
            if (string.IsNullOrEmpty(Name))
            {
                throw new CoustomException(MedicalRecordExceptionHandling.exmess["Name"]);
            }
            else
            {
                medicalRecord.PatientName = Name;
                Console.WriteLine("You have entered the correct name");
            }
            if (string.IsNullOrEmpty(Diagnosis))
            {
                throw new CoustomException(MedicalRecordExceptionHandling.exmess["Daiagnosis"]);
            }
            else
            {
                medicalRecord.Diagnosis = Diagnosis;
                Console.WriteLine("You have entered the correct Diagnosis");

            }
            if (treatmentCost <0 )
            {
                throw new CoustomException(MedicalRecordExceptionHandling.exmess["treatmentCost"]);
            }
            else
            {
                medicalRecord.TreatmentCost= treatmentCost;
                Console.WriteLine("You have entered the correct treatmentCost");

            }
            medicalRecord.PatientId= recID;
            medicalRecordsList.Add(medicalRecord);
        }
        public void DisplayMedicalRecord()
        {

            Console.WriteLine(medicalRecordsList[0].RecordId + medicalRecordsList[0].PatientName + medicalRecordsList[0].Diagnosis + medicalRecordsList[0].TreatmentCost);
        }


        
    }
}
