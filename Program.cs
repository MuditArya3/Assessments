using System;
using doctor;
using patient;
using bed;
namespace ASSESSMENT_4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n;
            string answer = "Y";
            for (; answer.ToUpper() == "Y";)
            {

                Console.WriteLine("Enter 1 for registering Doctors");
                Console.WriteLine("Enter 2 for registering Patients");
                Console.WriteLine("Enter 3 for booking a Bed ");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                       
                        doctor_details doc = new doctor_details();
                        doc.enter();
                        doc.show();
                        break;
                    case 2:
                        patient_details pa = new patient_details();
                        pa.enter();
                        pa.show();
                        break;
                    case 3:
                        bed_details b = new bed_details();
                        b.enter();
                        b.show();
                        break;
                    default:
                        Console.WriteLine("Invalid Input, Please select between 1 to 3 only");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Do you want to add more details or want to review the details? (Y/N)-");
                answer = Console.ReadLine();
            }
        }
    }
}