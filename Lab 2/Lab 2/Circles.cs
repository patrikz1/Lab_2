using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Circles
    {
        public int x { get; set; }
        public int y { get; set; }
        public int length { get; set; }

        static void areaCircle(int length)  // en av de fyra kraven var inga static classes metoder eller variablar... ändra till public lr nåt*/
        {
            Console.Write("Enter Length: ");
            double l = Convert.ToDouble(Console.ReadLine());
            double Area = Math.PI * length * length;
            Console.WriteLine("Area of circle: " + Area);
            Console.ReadKey();
        }

        //public void calculateCircumference(int length)
        //{
        //    return 2 * Math.PI * radius;
        //}

        //console.log(Math.PI);
        
    }
        
    
}
