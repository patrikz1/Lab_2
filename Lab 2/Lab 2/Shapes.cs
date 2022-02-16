using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Shapes 
    {
        string shape = "Square";
        int x;
        int y;
        int length;
        int points;

        // ^ Behöver vi inte {get; set;} på dom?

        public Shapes(int p) { points = p; }
         public string GetShape() { return shape; }


    
        public Shapes() {
    
           
        }

        //public List<Shapes> ListAddCsv()
        //{
        //    List<Shapes> NewShapes = new List<Shapes>();
        //    NewShapes.Add(new Squares("Square", 1, 5, 9, 100));
        //    NewShapes.Add(new Squares("Square", 1, 3, 5, 200));

        //    return NewShapes;


        //}


    }
}
