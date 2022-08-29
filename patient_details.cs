using System;
using System.Collections.Generic;
using System.Text;

namespace patient
{
    public class patient_details:display.display1, Idisplay
    {
        display.display1 di = new display.display1();
        public string pa_name { get; set; }
        public int age { get; set; }
        public string address { get; set; }

        public string appointment_type { get; set; }

        public void show()
        {
            Console.Write(di.id + " " + pa_name + " " + age + " "+address+" "+appointment_type);
        }
        public void enter()
        {
            Console.WriteLine("Enter Patient Id- ");
            di.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Patient Name- ");
            pa_name = Console.ReadLine();
            Console.WriteLine("Enter Patients Age- ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Address- ");
            address = Console.ReadLine();
            Console.WriteLine("Patients Details Are- ");
        }
    }
}
