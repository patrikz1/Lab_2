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

        public Parser(string pointCord, string CsvInput)
        {
            PointParser(pointCord);
            CsvParser(CsvInput);

        }

        public void PointParser(string pointCord)
        {
            // Split the two inputs by comma
            string[] pointcordSep =  pointCord.Replace("\"" , "").Split(",");
            

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
                Console.WriteLine("Not 2 valid coordinates separated by a comma, please try again!");
                Environment.Exit(1);
            }

        }

        public void CsvParser(string CsvInput)
        {
            //Replace spaces into empty strings in order to nullify whitespace and split rows based on ';'
            var Rows = CsvInput.Replace(" ","").Split(';')
                .Where(row => !string.IsNullOrWhiteSpace(row)).Distinct().ToList();

            //Isolate only the first row (the header) and split the columns based on ','
            var HeaderColumns = Rows[0].Split(',').ToList();

            /*Make variables based on where the index of the headerText equals the string name
            of what im searching for to be able to assign the values correctly no matter what order the input comes in.*/
            var columnShape = HeaderColumns.FindIndex(i => i.Equals("SHAPE"));
            var columnX = HeaderColumns.FindIndex(i => i.Equals("X"));
            var columnY = HeaderColumns.FindIndex(i => i.Equals("Y"));
            var columnLength = HeaderColumns.FindIndex(i => i.Equals("LENGTH"));
            var columnPoints = HeaderColumns.FindIndex(i => i.Equals("POINTS"));

            List<Shapes> shapes = new List<Shapes>();
            //If there is any rows
            if (Rows.Count > 0) 
            {
                try
                {   //foreach, skip first as it's the HeaderColumns
                    foreach (var row in Rows.Skip(1))
                    {
                        //Split columns based on ','
                        var columns = row.Split(',');
                        //If there is 5 columns then..
                        if (columns.Count() == 5)
                        {   //Add to list based on index which i specified above and parse Integers/Convert to double
                            shapes.Add(new()  
                            {
                                Shape = columns[columnShape],
                                X = Int32.Parse(columns[columnX]),
                                Y = Int32.Parse(columns[columnY]),
                                Length = Convert.ToDouble(columns[columnLength]),
                                Points = Int32.Parse(columns[columnPoints]),

                            }) ;    
                            
                        }
                        else
                        {   //Message if it does not have 5 inputs
                            Console.WriteLine(" ' " + row +" ' " + " <-- Is not configured correctly, please add 5 valid inputs separated by a comma!");
                        }
                    }
                }//Catch exceptions and display them for clarification
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong : \n" + e);
                }
            }// if Rows count is 0
            else
            {
                Console.WriteLine("No CSV data input, please try again!");
                Environment.Exit(0);
            }
            //Send XCord and YCord from PointerParser (which was stored in variables at the top) as well as the list just created to constructor of pointer
            pointer newpointer = new pointer(XCord, YCord, shapes);
        }
    }
}
