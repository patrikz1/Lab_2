using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Parser
    {
      public int xCord { get; set; }
      public int yCord { get; set; }

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
            var csvRows = csvData.Split(';');
            List<Shapes> shapes = new List<Shapes>();
            if (csvRows.Count() > 0)
                foreach (var row in csvRows)
                {
                    var csvColumn = row.Split(',').Select(csvData => csvData.Replace(" ", "")).Where(csvData => !string.IsNullOrEmpty(csvData)).Distinct().ToList();
                        if (csvColumn.Count() == 5)
                        {
                            shapes.Add(new()
                            {
                                shape = csvColumn[0], //where csvcolumns[0] contains = "shape"



                            });
                        }
                        else
                        {
                        Console.WriteLine(row + " does not have 5 inputs and cannot be added!");
                        }
                }            
            else
                {
                Console.WriteLine("No CSV data input");
                }

          
            
            //OLD STUFF BELOW -> TA BORT SEN

            /*This creates a string array, then splits the csvData rows, replaces spacing from " " to "" at any point in the string, 
              removes any null(shouldn't be any due to readline check) or empty string entries, splits the columns and converts to an array */
            //string[][] rowSep = csvData.Split(';').
            //    Select(csvData => csvData.Replace(" ", "")).Where(csvData => !string.IsNullOrEmpty(csvData)).Select(csvData => csvData.Split(',')).ToArray();

            //If the array length is 0 write "no valid csv data". (already checked for null at readline initially AND above, but can still be 0 if there was an empty string that got removed above)
            //if (rowSep.Length == 0)
            //{
            //    Console.WriteLine("No valid csv data");
            //}        

        }

    }
}
