namespace Tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tablica = new int[5];
            tablica[0] = 5;
            tablica[3] = 66;

            Console.WriteLine("Wartość indeksu 0 = " + tablica[0]);
            Console.WriteLine(tablica[3]);

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[1] = i * 10 + 3;
            }
            for(int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Wartośc indeksu " + i + "=" +tablica[i]);
            }


        }
    }
}