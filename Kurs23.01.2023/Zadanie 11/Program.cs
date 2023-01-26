using System.Reflection.Metadata.Ecma335;

namespace Zadanie_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] tablica = new int[10];

            //int liczba;

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    Console.WriteLine("Podaj liczbe nr " + i);
            //    string odpowiedz = Console.ReadLine();
            //    liczba = int.Parse(odpowiedz);
            //    tablica[i] = liczba;
            //}

            //Array.Sort(tablica);

            //foreach(int x in tablica)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] tablica = new int[10];

            //int liczba;

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    Console.WriteLine("Podaj liczbe nr " + i);
            //    string odpowiedz = Console.ReadLine();
            //    liczba = int.Parse(odpowiedz);
            //    tablica[i] = liczba;

                
            //}

            // Array.Reverse(tablica);

            //foreach (int x in tablica)
            //{
            //    Console.WriteLine(x);
            //}


            string tekst = Console.ReadLine();
            for (int i = 1; i < tekst.Length; i++)
            {
                if (i % 2 == 0 && i != 0) continue;
                Console.WriteLine(tekst[i]);
      
            }

        }
    }
}