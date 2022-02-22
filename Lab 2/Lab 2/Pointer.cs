using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class pointer {
        List<Shapes> shapesHit { get; set; }
        List<Shapes> shapesMissed { get; set; }

        public pointer(int XCord, int YCord, List<Shapes> shapes)
        {
            HitOrMiss(XCord, YCord, shapes);
        }

        public void HitOrMiss(int XCord, int YCord, List<Shapes> shapes)
        {
            var Circles = from i in shapes where i.Shape == "CIRCLE" select i;
            var Squares = from i in shapes where i.Shape == "SQUARE" select i;
            shapesHit = new List<Shapes>();
            shapesMissed = new List<Shapes>();

            if (Circles.Count() + Squares.Count() > 0)
            {
                foreach (var shape in Circles)
                {
                    var CircleXValue = shape.X;
                    var CircleYValue = shape.Y;
                    double Radius = shape.Length / Math.PI / 2;

                    bool InsideCircle = Math.Pow(XCord - CircleXValue, 2) +
                    Math.Pow(YCord - CircleYValue, 2) < Math.Pow(Radius, 2);

                    if (InsideCircle == true)
                    {
                        shapesHit.Add(shape);
                    }
                    else if (InsideCircle == false)
                    {
                        shapesMissed.Add(shape);
                    }
                }
                foreach (var shape in Squares)
                {
                    var SquareXValue = shape.X;
                    var SquareYValue = shape.Y;

                    var Radius = Math.Sqrt(Math.Pow(shape.Length / 4 / 2, 2) * 2);


                    bool InsideSquare = XCord - SquareXValue + YCord - SquareYValue <= Radius;

                    if (InsideSquare == true)
                    {
                        shapesHit.Add(shape);
                    }
                    else if (InsideSquare == false)
                    {
                        shapesMissed.Add(shape);

                    }
                }

                Scores scores = new Scores(shapesHit, shapesMissed);
            }
            else
            {
                Console.WriteLine("Could not find any valid Circles or Squares!");
            }
        }

    }
         
}
