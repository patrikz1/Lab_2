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



            //Send to whatever method we need
            pointer newpointer = new pointer(xCord, yCord);
        }

        public void CsvParser(string csvData)
        {
            var csvRows = csvData.Split(';').ToList();
            var headerValues = csvRows[0].Split(',');

            var colShape = headerValues.ToList().FindIndex(i => i.Equals("SHAPE"));
            var colX = headerValues.ToList().FindIndex(i => i.Equals("X"));
            var colY = headerValues.ToList().FindIndex(i => i.Equals("Y"));
            var colLength = headerValues.ToList().FindIndex(i => i.Equals("LENGTH"));
            var colPoints = headerValues.ToList().FindIndex(i => i.Equals("POINTS"));

            List<Shapes> shapes = new List<Shapes>();
            //remove first entry (header)
            csvRows.RemoveAt(0);
            csvRows.RemoveAll(string.IsNullOrWhiteSpace);
            if (csvRows.Count() > 0)
                foreach (var row in csvRows)
                {
                    var csvColumn = row.Split(',');
                    try
                    {
                        if (csvColumn.Count() == 5)
                        {
                            shapes.Add(new()
                            {
                                shape = csvColumn[colShape],
                                x = Int32.Parse(csvColumn[colX]),
                                y = Int32.Parse(csvColumn[colY]),
                                length = Int32.Parse(csvColumn[colLength]),
                                points = Int32.Parse(csvColumn[colPoints]),
                            });
                        }
                        else
                        {
                            Console.WriteLine(row + " does not have 5 inputs and cannot be added!");
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You did not enter a valid integer for one or more of the fields! Give this message to IT: \n" + e);
                    }
                }            
            else
                {
                Console.WriteLine("No CSV data input");
                }



            // Send this wherever you need
            var Shapelist = new Shapes(shapes);
        }

    }
}
