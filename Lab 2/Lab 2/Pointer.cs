using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class pointer {
        List<Shapes> shapes { get; set; }
        List<Shapes> shapesHit { get; set; }
        List<Shapes> shapesMissed { get; set; }

        public int XCord { get; set; }
        public int YCord { get; set; }

        public pointer(int XCord, int YCord, List<Shapes> shapes)
        {
            this.shapes = shapes;
            this.XCord = XCord;
            this.YCord = YCord;
            // behöver kanske inte de "this." över ^ 

            HitOrMiss(XCord, YCord, shapes);
            
        }

        public void HitOrMiss(int XCord, int YCord, List<Shapes> shapes)
        {
            var Circles = from i in shapes where i.Shape == "CIRCLE" select i;
            shapesHit = new List<Shapes>();
            shapesMissed = new List<Shapes>();


            foreach (var shape in Circles)
            {
                var CircleXValue = shape.X;
                var CircleYValue = shape.Y;
                var Radius = shape.Length / 2;

                bool InsideCircle = ((XCord - CircleXValue) * (XCord - CircleXValue) +
                (YCord - CircleYValue) * (YCord - CircleYValue) <= Radius * Radius);
                if (InsideCircle)
                {
                    shapesHit.Add(shape);
                }
                else
                {
                    shapesMissed.Add(shape);
                }
            }

            
        }

    }
         
}
