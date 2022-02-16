using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Parser
    {
        int xCord { get; set; }
        int yCord { get; set; }

        public Parser(string pointCord, string csvData)
        {
            string[] rowSep = csvData.Split(';');






            string[] pointcordSep = pointCord.Split(",");
            int pointCordInt = 0;
            var parseArrayToInt = (from i in pointcordSep where int.TryParse(i, out pointCordInt) select pointCordInt).ToArray();
            int arraylength = parseArrayToInt.Count();

            if (arraylength == 2)
            {
                xCord = parseArrayToInt[0];
                yCord = parseArrayToInt[1];

                // set x = pointCordInt[0] o Y = pointCordInt[1] å skicka, alternativt skicka array till pointer dirr
            }
            else
            {
                Console.WriteLine("Not 2 valid coordinates separated by a comma");
            }
            pointer newpointer = new pointer(xCord, yCord);
        }
    }
}
