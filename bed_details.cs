using System;
using System.Collections.Generic;
using System.Text;

namespace bed
{
    public class bed_details:display.display1,Ishows
    {
        display.display1 di = new display.display1();
        public string availability { get; set; }
        public string bed_type { get; set; }
        public void show()
        {
            Console.Write(di.id + " " + availability + " " + bed_type );
        }
        public void enter()
        {
            Console.WriteLine("Enter Bed Id- ");
            di.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Availability- ");
            availability = Console.ReadLine();
            Console.WriteLine("Enter type of Bed- ");
            bed_type = Console.ReadLine();
            Console.WriteLine("Bed Details Are- ");
        }
    }
}
