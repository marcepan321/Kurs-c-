namespace Pętle_komunkacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba;

            do
            {
                Console.WriteLine("Podaj liczbe od 0 do10");
                string odpowiedz = Console.ReadLine();
                liczba = int.Parse(odpowiedz);
            } while(liczba < 0 || liczba > 10);
        }
    }
}