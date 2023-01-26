namespace Zadania_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LiczbaCałkowita licz = new LiczbaCałkowita();
            licz.WyswietlLiczbe();
            int a = licz.PobierzLiczbe();
        }
    }
    class LiczbaCałkowita
    {
        int a = 14;
        public void WyswietlLiczbe()
        {
            Console.WriteLine("Liczba " + a);
        }

        public int PobierzLiczbe()
        {
            return a;
        }
    }
}