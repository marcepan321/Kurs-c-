namespace Dzień_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            foreach(var a in args)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("koniec");
            Console.ReadLine();
        }
    }
}