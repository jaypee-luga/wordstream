
using System.Security.Cryptography;
using System.Text;

try
{
    using (var stream = new Booster.CodingTest.Library.WordStream())
    {

        while (true)
        {
            byte[] buffer = new byte[1024];
            int bytesRead;
            bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);

            string content = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            Console.WriteLine(content);

            Console.ReadLine();
        }


    }
}
catch (Exception ex)
{
    Console.WriteLine($"Exception Thrown:\n\nStackTrace:{ex.StackTrace}\n\n{ex.Message}");
}
