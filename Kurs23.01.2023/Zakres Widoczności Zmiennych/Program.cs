namespace Zakres_Widoczności_Zmiennych
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            if (a == 1)
            {
                int b = 2;

                Console.WriteLine(b);
                Console.WriteLine(a);
            }
            Console.WriteLine(b);
            Console.WriteLine(a);
        }
    }
}