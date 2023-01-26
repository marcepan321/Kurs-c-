namespace Zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] tablica = new int[10];

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    tablica[i] = i + 101;
            //    Console.WriteLine("Wartość tablicy " + tablica[i]);
            //}


            //int[] tablica = new int[10];

            //for (int i = 0; i < tablica.Length; i++)
            //{
            //    tablica[i] = (i + 1) * 10;
            //    Console.WriteLine("Wartość tablicy "+tablica[i]);
            //}

            //bool[] tablica = new bool[20];

            //for (int i = 0; i <tablica.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        tablica[i] = true;
            //    }
            //    else
            //    {
            //        tablica[i] = false;

            //    }
            //    Console.WriteLine(tablica[i]);
            //}

            int[] tablica = new int[100];

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = i % 10;
                Console.WriteLine(tablica[i]);
            }

        }
    }
}