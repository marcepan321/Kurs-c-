namespace Dzien2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            int j = 10;
            bool warunek = true;
            //while
            while (warunek)
            {
                Console.WriteLine("While: " + j);
                j -=3;
                warunek = j > 0;
            }

            int k = 5;

            //do-while

            do
            {
                Console.WriteLine("Do-While: " + k);
                k = k + 1;
            } while (k < 15);
        }
    }
}