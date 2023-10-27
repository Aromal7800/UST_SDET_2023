// See https://aka.ms/new-console-template for more information
using Assignment_6_oct_26;
int flag = 0;
do
{
    Console.WriteLine("Menu");
    Console.WriteLine("0.Add medical record to list ");
    Console.WriteLine("1.Write to the file");
    Console.WriteLine("2.read from file ");
    Console.WriteLine("3.View the details of a perticular patient");
    int ch = Convert.ToInt32(Console.ReadLine());
    MedicalHistory medicalHistory1 = new MedicalHistory();
    switch (ch)
    {
        case 0:
            {
                Console.WriteLine("Enter the record id :");
                int recId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Patient id :");
                int patientID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Patient Description :");
                string patientDescription = Console.ReadLine();
                Console.WriteLine("Enter the date :");
                int Date = Convert.ToInt32(Console.ReadLine());
                medicalHistory1.AddMedicalHistory(recId, patientID, patientDescription, Date);
                break;

            }
        case 1:
            {
                medicalHistory1.WriteMedicalHistory();
                break;

            }
        case 2:
            {
                medicalHistory1.ReadMedicalHistory();
                break;
            }
            case 3:
            {
                
                break;
            }

    }
    Console.WriteLine("Do you want to continue : 1.yes 2.no");
} while (flag == 0);
/*
MedicalHistory medicalHistory=new MedicalHistory();
medicalHistory.AddMedicalHistory(1, 2,"Tuber culosis",234);
medicalHistory.WriteMedicalHistory();
medicalHistory.ReadMedicalHistory();

/*
Patient patient = new Patient();
int id = 34;
int age = 24;
string name = "Aromal";
string diagnosis = "TB";
patient.AddPatient(id, name,age, diagnosis);
Patient patient1 = new Patient();
patient1.AddPatient(23, "ef", 90,"enfj");
patient.WritePatient();
//patient.WritePatient();
patient.ReadPatient();
/*
string name = "Aromal";
string diagnosis = "TB";
int RecId = 34;
int Tcost = 890;
MedicalRecords medicalRecords = new MedicalRecords();
medicalRecords.AddMedicalRecord(RecId,name,diagnosis,Tcost);
medicalRecords.DisplayMedicalRecord();
//Console.WriteLine();
/*
Patient patient=new Patient();
int age = 24;
string name = "Aromal";
string diagnosis = "TB";

try
{
    patient.CheckName(name);
}
catch(NameCheck ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    patient.CheckAge(age);
}
catch(AgeCheck ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    patient.CheckDiagnosis(diagnosis);
}
catch(daiagnosisCheck ex)
{
Console.WriteLine(ex.Message);
}

/*
CallRecords callRecords = new CallRecords(1, 234, 456);
CallRecords.callRecordsList.Add(callRecords);
CallRecords callRecords1 = new CallRecords(1, 23488, 45600);
CallRecords.callRecordsList.Add(callRecords1);
CallRecords callRecords2 = new CallRecords(1, 234666, 456889);
CallRecords.callRecordsList.Add(callRecords2);
CallRecords callRecords3 = new CallRecords(1, 234, 456);
CallRecords.callRecordsList.Add(callRecords);
CallRecords callRecords4 = new CallRecords(1, 23488, 45600);
CallRecords.callRecordsList.Add(callRecords1);
CallRecords callRecords5 = new CallRecords(1, 234666, 456889);
CallRecords.callRecordsList.Add(callRecords2);
callRecords.CallHistory(234);
callRecords.TotalCalls();
/*
Customer customer=new Customer(1,"Arun",456,678);

Customer.CustomersList.Add(customer);
Customer customer1 = new Customer(2, "Aroo", 4512, 678324);

Customer.CustomersList.Add(customer1);
Customer customer2 = new Customer(3, "Aroo1", 45634, 67834);

Customer.CustomersList.Add(customer2);
customer.SearchByPhone(456);
   
*/