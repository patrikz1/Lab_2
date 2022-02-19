using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Shapes 
    {
        public string shape { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int length { get; set; }
        public int points { get; set; }


        // ^ Behöver vi inte {get; set;} på dom?

        //public string GetShape() { return shape; }



        public Shapes()
        {

        }
        public Shapes(List<Shapes> shapes)
        {

        }
        



    }
}
