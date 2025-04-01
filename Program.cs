
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using wordCounter;


//byte size min and max sizes
const int minValue = 100;
const int maxValue = 1024;

//random object
var rand = new Random();

try
{
    using (var stream = new Booster.CodingTest.Library.WordStream())
    {
        while (true)
        {
            //clear clear console
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press enter (↵) to fetch words from Stream... ");

            //define bytearray with random sizing
            var buffer = new byte[rand.Next(minValue, maxValue)];
            int bytesRead;

            //read from stream
            bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            //stringify
            string content = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(content);

            processContent(content);

            Console.ReadLine();
        }


    }
}
catch (Exception ex)
{
    Console.WriteLine($"Exception Thrown:\n\nStackTrace:{ex.StackTrace}\n\n{ex.Message}");
}

static void processContent(string content)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("\n\n");
    Console.WriteLine("-INFORMATION-");
    Console.WriteLine("========================================");
    Console.WriteLine($"Total Character Length: {content.Length}");
    Console.WriteLine($"Word Count: {content.wordCount()}");
    Console.WriteLine("========================================");
    Console.WriteLine("5 Largest Words:");
    foreach (var w in content.fiveLargestWords())
    {
        Console.Write($"`{w}` ");
    }
    System.Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("5 Smallest Words:");
    foreach (var w in content.fiveSmallestWords())
    {
        Console.Write($"`{w}` ");
    }
    System.Console.WriteLine();
    Console.WriteLine("========================================");
    Console.WriteLine("Top 10 Frequest Appearing Words:");
    foreach (var w in content.top10frequentlyAppearingWords())
    {
        Console.Write($"`{w}` ");
    }
    System.Console.WriteLine();
    Console.WriteLine("========================================");
    content.allCharacters();
}