
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;


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
            string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(content);

            processWordStream(content);

            Console.ReadLine();
        }


    }
}
catch (Exception ex)
{
    Console.WriteLine($"Exception Thrown:\n\nStackTrace:{ex.StackTrace}\n\n{ex.Message}");
}

static void processWordStream(string str)
{
    Console.WriteLine($"Total Number of Characters: {str.Length}");
    Console.WriteLine($"Total Number of Words{str.Split(' ').Length}");

    Console.WriteLine();


}

static List<string> fiveLargestWords(string str)
{
    return default;
}

static List<string> fiveSmallestWords(string str)
{

}