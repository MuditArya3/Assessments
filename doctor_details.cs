using System;
using System.Collections.Generic;
using System.Text;


namespace doctor
{
    public class doctor_details:display.display1,Ishow
    {
        display.display1 di = new display.display1();

        public string doc_name { get; set; }
        public int experience { get; set; }
        public string speciality { get; set; }
        public void show()
        {
            Console.Write(di.id + " " + doc_name + " " + experience + " " + speciality);
        }

        public void enter()
        {

            Console.WriteLine("Enter Doctors Id- ");
            di.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Doctors Name- ");
            doc_name = Console.ReadLine();
            Console.WriteLine("Enter Experience- ");
            experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Speciality- ");
            speciality = Console.ReadLine();
            Console.WriteLine("Doctors Details Are- ");
        }
    }
}
