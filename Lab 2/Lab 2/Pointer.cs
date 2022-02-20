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

            PointsHit(XCord, YCord, shapes);
            PointsMissed(XCord, YCord, shapes);
            
        }

        public void PointsHit(int XCord, int YCord, List<Shapes> shapes)
        {
            //Calculate all points hit! store in shapesHit List!
        }
        public void PointsMissed(int XCord, int YCord, List<Shapes> shapes)
        {
            //All points NOT in shapesHit List from shapes == MISSED! store in shapesMissed
            //Skicka båda listorna (shapesHit & shapesMissed) till "Scores" klass där uträkning körs ("Scores" har konstruktor input 2 listor av shapes, 1 hit å 1 missed)
        }
    }
         
}
