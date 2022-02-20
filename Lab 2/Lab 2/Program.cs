// See https://aka.ms/new-console-template for more information
using Lab_2;

string? pointCord = Console.ReadLine();
string? csvData = Console.ReadLine();

//More likely to be just an empty string (which is parsed later) rather than null, but implemented to be fail-safe.
if (pointCord != null && csvData != null && pointCord != "" && csvData !="" )
{
    Parser parser = new Parser(pointCord, csvData);
}
else
{
    Console.WriteLine("Null or empty values, try again!");
}




