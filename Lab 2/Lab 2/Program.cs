// See https://aka.ms/new-console-template for more information
using Lab_2;

Console.WriteLine("Hello, World!");
Shapes shapes = new Shapes();

/* ________________________________________________________________________________________________________________________________________________
exempel på csv readers (andra ser mer doable ut)

using Microsoft.VisualBasic.FileIO;

var path = @"C:\Person.csv"; // Habeeb, "Dubai Media City, Dubai"
using (TextFieldParser csvParser = new TextFieldParser(path))
{
    csvParser.CommentTokens = new string[] { "#" };
    csvParser.SetDelimiters(new string[] { "," });
    csvParser.HasFieldsEnclosedInQuotes = true;

    // Skip the row with the column names
    csvParser.ReadLine();

    while (!csvParser.EndOfData)
    {
       // Read current line fields, pointer moves to the next line.
        string[] fields = csvParser.ReadFields();
        string Name = fields[0];
        string Address = fields[1];
        }
____________________________________________________________________________________________________________________________________________________
var column1 = new List<string>();
var column2 = new List<string>();
using (var rd = new StreamReader("filename.csv"))
{
    while (!rd.EndOfStream)
    {
        var splits = rd.ReadLine().Split(';');
        column1.Add(splits[0]);
        column2.Add(splits[1]);
    }
}
// print column1
Console.WriteLine("Column 1:");
foreach (var element in column1)
    Console.WriteLine(element);

// print column2
Console.WriteLine("Column 2:");
foreach (var element in column2)
    Console.WriteLine(element);
} */