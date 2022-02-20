using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Parser
    {
      public int XCord { get; set; }
      public int YCord { get; set; }

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
                XCord = parseArrayToInt[0];
                YCord = parseArrayToInt[1];
            }
            else
            {
                Console.WriteLine("Not 2 valid coordinates separated by a comma");
            }

        }

        public void CsvParser(string csvData)
        {
            var csvRows = csvData.Replace(" ","").Split(';').ToList();
            var headerValues = csvRows[0].Split(',');

            var colShape = headerValues.ToList().FindIndex(i => i.Equals("SHAPE"));
            var colX = headerValues.ToList().FindIndex(i => i.Equals("X"));
            var colY = headerValues.ToList().FindIndex(i => i.Equals("Y"));
            var colLength = headerValues.ToList().FindIndex(i => i.Equals("LENGTH"));
            var colPoints = headerValues.ToList().FindIndex(i => i.Equals("POINTS"));

            List<Shapes> shapes = new List<Shapes>();

            if (csvRows.Count() > 0) 
            {
                try
                {
                    foreach (var row in csvRows.Skip(1))
                    {
                        var csvColumn = row.Split(',');

                        if (csvColumn.Count() == 5)
                        {
                            shapes.Add(new()  // ta bort 'shapes' inom new?
                            {
                                Shape = csvColumn[colShape],
                                X = Int32.Parse(csvColumn[colX]),
                                Y = Int32.Parse(csvColumn[colY]),
                                Length = Int32.Parse(csvColumn[colLength]),
                                Points = Int32.Parse(csvColumn[colPoints]),

                            }) ;    
                            
                        }
                        else
                        {
                            Console.WriteLine(" ' " + row +" ' " + " does not have 5 inputs and cannot be added!");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong : \n" + e);
                }
            }
            else
            {
                Console.WriteLine("No CSV data input");
            }

            pointer newpointer = new pointer(XCord, YCord, shapes);
        }
    }
}
