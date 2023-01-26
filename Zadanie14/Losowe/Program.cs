using System.Reflection.Emit;

namespace Losowe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random generator = new Random();
            int b;
            for (int a = 0;a <25; a++)
            {
                b = generator.Next(200);

                    Console.WriteLine("a = {0}", b);
            }
        }
    }
}