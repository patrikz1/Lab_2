using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Shapes 
    {
        string shape { get; set; }
        int x { get; set; }
        int y { get; set; }
        int length { get; set; }
        int points { get; set; }

        // ^ Behöver vi inte {get; set;} på dom?

        public string GetShape() { return shape; }


    
        public Shapes() {

        }

        public void CsvSeparation(string pointCord, string csvData)
        {
            string[] rowSep = csvData.Split(';');






            string[] pointcordSep = pointCord.Split(",");
            int pointCordInt = 0;
            var parseArrayToInt = (from i in pointcordSep where int.TryParse(i, out pointCordInt) select pointCordInt).ToArray();
            int arraylength = parseArrayToInt.Count();

            if (arraylength == 2)
            {
               // set x = pointCordInt[0] o Y = pointCordInt[1] å skicka, alternativt skicka array till pointer dirr
            }
            else
            {
                Console.WriteLine("Not 2 valid coordinates separated by a comma");
            }


        }


    }
}
