using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Scores
    {
        double FinalScoreHit { get; set; }
        double FinalScoreMiss { get; set; }
        public Scores(List<Shapes> shapesHit, List<Shapes> shapesMissed)
        {
            ShapeScoreHit(shapesHit);
            ShapeScoreMissed(shapesMissed);
            FinalScore();
        }

        public void ShapeScoreHit(List<Shapes>shapesHit)
        {
            //Get Circles & Squares from shapesHit list based on Shape name and select that object
            var Circles = from i in shapesHit where i.Shape == "CIRCLE" select i;
            var Squares = from i in shapesHit where i.Shape == "SQUARE" select i;

            foreach (var circle in Circles)
            {
                //Set typepoint for circle, get points from circle and calculate the area
                var typePoints = 2;
                var instancePoints = circle.Points;
                var PiTimesFour = Math.PI * 4;
                var area = Math.Pow(circle.Length,2) / PiTimesFour;
                //Calculate score for circle and add to FinalScoreHit 
                var score = typePoints * instancePoints / area;
                FinalScoreHit += score;
            }
            foreach(var square in Squares)
            {
                //Set typepoint for square, get points from square and calculate the area
                var typePoints = 1;
                var instancePoints = square.Points;
                var area = Math.Pow(square.Length / 4, 2);
                //Calculate score for square and add to FinalScoreHit
                var score = typePoints * instancePoints / area;
                FinalScoreHit += score;
            }
        }
        public void ShapeScoreMissed(List<Shapes> shapesMissed)
        {
            //Get Circles & Squares from shapesMissed list based on Shape name and select that object
            var Circles = from i in shapesMissed where i.Shape == "CIRCLE" select i;
            var Squares = from i in shapesMissed where i.Shape == "SQUARE" select i;

            foreach (var circle in Circles)
            {
                //Set typepoint for circle, get points from circle and calculate the area
                var typePoints = 2;
                var instancePoints = circle.Points;
                var PiTimesFour = Math.PI * 4;
                var area = Math.Pow(circle.Length, 2) / PiTimesFour;
                //Calculate score for circle and add to FinalScoreMiss
                var score = typePoints * instancePoints / area;
                FinalScoreMiss += score;
            }
            foreach (var square in Squares)
            {
                //Set typepoint for square, get points from square and calculate the area
                var typePoints = 1;
                var instancePoints = square.Points;
                var area = Math.Pow(square.Length / 4, 2);
                //Calculate score for square and add to FinalScoreMiss
                var score = typePoints * instancePoints / area;
                FinalScoreMiss += score;
            }
        }
        public void FinalScore()
        {
            //Calculate and round up finalScore to nearest integer
            int finalScore = (int)Math.Round(FinalScoreHit - FinalScoreMiss / 4);
            //Write the finalScore!
            Console.WriteLine("\n" + finalScore);
        }

    }
}
