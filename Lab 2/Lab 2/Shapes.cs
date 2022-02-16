using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    public class Shapes 
    {
        string shape { get; set; }
        int x { get; set; }
        int y { get; set; }
        int length { get; set; }
        int points { get; set; }

        // ^ Behöver vi inte {get; set;} på dom?

        public string GetShape() { return shape; }


    
        public Shapes() {

        }

        public void CsvSeparation(string csvData)
        {
            string[] rowSep = csvData.Split(';');
            foreach (string line in rowSep)
            {
              
            }
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
