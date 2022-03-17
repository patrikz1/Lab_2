using Lab_2;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            var pointCord = args[0];
            var CsvInput = args[1];
            
            Parser parser = new Parser(pointCord, CsvInput);
        }
        catch (Exception)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("\nPlease enter arguments!");
            }
            else
            {
                Console.WriteLine("\nYou encountered an issue, make sure you entered the 2 arguments with a space between them");
            }
        }
    }

}




