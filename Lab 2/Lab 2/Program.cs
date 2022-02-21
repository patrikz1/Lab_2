using Lab_2;

string? pointCord = Console.ReadLine();
string? CsvInput = Console.ReadLine();

//More likely to be just an empty string (which is parsed later) rather than null, but implemented to be fail-safe.
if (pointCord != null && CsvInput != null && pointCord != "" && CsvInput !="" )
{
    Parser parser = new Parser(pointCord, CsvInput);
}
else
{
    Console.WriteLine("Null or empty values, try again!");
}




