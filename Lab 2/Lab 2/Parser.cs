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
            PointParser(pointCord);
            CsvParser(csvData);
            pointer newpointer = new pointer(xCord, yCord);
        }

        public void PointParser(string pointCord)
        {
            string[] pointcordSep = pointCord.Split(",");
            int pointCordInt = 0;
            var parseArrayToInt = (from i in pointcordSep where int.TryParse(i, out pointCordInt) select pointCordInt).ToArray();
            int arraylength = parseArrayToInt.Count();

            if (arraylength == 2)
            {
                xCord = parseArrayToInt[0];
                yCord = parseArrayToInt[1];
            }
            else
            {
                Console.WriteLine("Not 2 valid coordinates separated by a comma");
            }
            //pointer newpointer = new pointer(xCord, yCord);
        }
        public void CsvParser(string csvData)
        {
            string[] rowSep = csvData.Split(';');
           // assign values to variables in shapes based on name of header OR simply the order since they are always ordered.

        }
        
    }
}
