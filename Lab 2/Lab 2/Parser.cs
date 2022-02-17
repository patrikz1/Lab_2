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
            // Split the two inputs by comma
            string[] pointcordSep = pointCord.Split(",");        

            int pointCordInt = 0;
            //Create a int array with the two split numbers and remove any inputs that is not integers (including whitespace)
            var parseArrayToInt = (from i in pointcordSep where int.TryParse(i, out pointCordInt) select pointCordInt).ToArray();
            //Count number of array elements
            int arraylength = parseArrayToInt.Count();
            //If count equals 2, set these two to xCord and yCord respectivly. 
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
            /*This creates a string array then splits the csvData, trims each csvData element at the start and end of the string, 
              replaces any potential spaces in middle of string with emptyspace (removes them) and then finally removes any completely null entries and converts to an array */
            string[] rowSep = csvData.Split(';').Select(csvData => csvData.Trim().Replace(" ","")).Where(csvData => !string.IsNullOrEmpty(csvData)).ToArray();

            // assign values to variables in shapes based on name of header OR simply the order since they are always ordered.
            // kanske behöver multi dimensional array   
            

        }

    }
}
