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

// kolla om csv data är uppdelat här, isf kan vi skicka den + pointcord tsms till en point metod
// annars skicka med pointcord till csvSep å sen efter uppdelningen i kvar, skicka båda till en point metod.



