using Lab_2;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            var pointCord = args[0];
            var CsvInput = args[1];

            //More likely to be just an empty string (which is parsed later) rather than null, but implemented to be fail-safe.
            if (pointCord != null && CsvInput != null && pointCord != "" && CsvInput != "")
            {
                Parser parser = new Parser(pointCord, CsvInput);
            }
            else
            {
                Console.WriteLine("Null or empty values, try again!");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("You encountered an issue, make sure you entered the 2 arguments with a space between them");
        }

    }

}




