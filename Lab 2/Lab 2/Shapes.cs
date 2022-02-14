using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Shapes 
    {
        string shape;
        int x;
        int y;
        int length;
        int points;

        Shapes() { }
        public Shapes(int p) { points = p; }
        public string GetShape() { return shape; }

        //Gör Circles, Squares, Triangles och de likadana attributen, skrivs här å gör så att de inherit denna class.
        // sen gör jag en lista av shapes här, å skickar det till en csv fil.
    }
}
