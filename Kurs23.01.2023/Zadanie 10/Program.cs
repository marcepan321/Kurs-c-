namespace Zadanie_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool[,] tablica = new bool[5, 8];
            //for(int i = 0; i < tablica.GetLength(0); i++)
            //{
            //    for(int j = 0; j < tablica.GetLength(1); j++)
            //    {
            //        //if(i%2 == 0 && j%2 == 0)
            //        //{
            //        //    tablica[i, j] = true;
            //        //}
            //        //else
            //        //{
            //        //    tablica[i, j] = false;
            //        //}

            //        tablica[i, j] = i % 2 == 0 && j % 2 == 0;

            //        Console.WriteLine("element o współrzędnych [" + i + ", " + j + "] = " + tablica[i, j]);
            //    }
            //}

            int[,,] tablica2 = new int[,,]
            {
                {
                    {1, 2, 3, 4, 5, 6, 7, 8, 9 }
                },
                {
                    {10, 20, 30, 40, 50, 60, 70, 80, 90 }
                }
            }

            tablica[i, j] = i % 2 == 0 && j % 2 == 0;

            Console.WriteLine("element o współrzędnych [" + i + ", " + j + "] = " + tablica[i, j]);

        }
    }
}