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
        }
        public void CsvParser(string csvData)
        {
            /*This creates a string array, then splits the csvData, replaces spacing from " " to "" at any point in the string, 
              removes any null(shouldn't be any due to readline check) or empty string entries and converts to an array */
            string[] rowSep = csvData.Split(';').Select(csvData => csvData.Replace(" ","")).Where(csvData => !string.IsNullOrEmpty(csvData)).ToArray();

            //If the aray length is 0 write "no valid csv data". (already checked for null at readline initially AND above, but can still be 0 if there was an empty string that got removed above)
            if (rowSep.Length == 0)
            {
                Console.WriteLine("No valid csv data");
            }
 
            // assign values to variables in shapes based on name of header OR simply the order since they are always ordered.
            // kanske behöver multi dimensional array ( splitta två gånger )   
            //kanske behöver join för å joina values med text på row[0]

        }

    }
}
