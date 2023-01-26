namespace LosujKwadrat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int b;
            for (int a = 0; a < 15; a++)
            {
                b = generator.Next(500);

                Console.WriteLine("a = {0}", b);
                if (b == b)
                {
                    Console.WriteLine("Ta sama liczba");
                }
                else
                {
                    Console.WriteLine("Inna");
                }
            }
        }
    }
}