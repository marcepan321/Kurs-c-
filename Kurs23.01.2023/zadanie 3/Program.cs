namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Podaj liczbę: ");
            string wartość = Console.ReadLine();
            double x = Convert.ToInt32(wartość);
            Console.WriteLine("Dzisiaj mleko jest w cenie: {0:C}", x);

            Console.WriteLine();
            Console.WriteLine("Podaj tekst: ");
            string tekst = Console.ReadLine();
            Console.WriteLine(tekst.ToUpper());

            Console.WriteLine();
            Console.WriteLine("Podaj tekst: ");
            string tekst2 = Console.ReadLine();
            Console.WriteLine(tekst2.Replace("a", "z"));

            Console.WriteLine();
            Console.WriteLine("Podaj tekst: ");
            string tekst3 = Console.ReadLine();
            Console.WriteLine(tekst3.Replace("b", ""));

            Console.WriteLine();
            Console.WriteLine("Podaj tekst: ");
            string tekst4 = Console.ReadLine();
            Console.WriteLine(tekst4.Replace(" ","\t").Replace("a", "\n"));
        }
    }
}