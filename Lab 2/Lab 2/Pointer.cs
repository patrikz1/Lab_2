using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Pointer {
        List<Shapes> shapesHit { get; set; } = null!;
        List<Shapes> shapesMissed { get; set; } = null!;

        public Pointer(int XCord, int YCord, List<Shapes> shapes)
        {
            HitOrMiss(XCord, YCord, shapes);
        }

        public void HitOrMiss(int XCord, int YCord, List<Shapes> shapes)
        {
            //Find objects in shape where the 'Shape' value equals CIRCLE or SQUARE
            var Circles = from i in shapes where i.Shape == "CIRCLE" select i;
            var Squares = from i in shapes where i.Shape == "SQUARE" select i;
            //Lists for hit/miss
            shapesHit = new List<Shapes>();
            shapesMissed = new List<Shapes>();
            //If there is any objects captured by Circles or Squares
            if (Circles.Count() + Squares.Count() > 0)
            {
                foreach (var shape in Circles)
                {
                    //Calculate radius and retrieve X & Y values
                    var CircleXValue = shape.X;
                    var CircleYValue = shape.Y;
                    double Radius = shape.Length / Math.PI / 2;
                    //Based on coordinates of the centre of the circle and radius, calculate if the point coordinates are inside the circle
                    bool InsideCircle = Math.Pow(XCord - CircleXValue, 2) +
                    Math.Pow(YCord - CircleYValue, 2) <= Math.Pow(Radius, 2);
                    //If the point coordinates are inside add to shapesHit, else to shapesMissed
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
                    //Calculate radius and retrieve X & Y values
                    var SquareXValue = shape.X;
                    var SquareYValue = shape.Y;
                    var Radius = Math.Sqrt(Math.Pow(shape.Length / 4 / 2, 2) * 2);

                    //Based on coordinates of the centre of the square and radius, calculate if the point coordinates are inside the square
                    bool InsideSquare = XCord - SquareXValue + YCord - SquareYValue <= Radius;

                    //If the point coordinates are inside add to shapesHit, else to shapesMissed
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
            //If there is no objects captured by Circle or Square
            else
            {
                Console.WriteLine("Could not find any valid Circles or Squares!");
            }
        }

    }
         
}
