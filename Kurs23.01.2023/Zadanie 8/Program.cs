namespace Zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("podaj liczbe od 0 do 100");
            //string odpowiedz = Console.ReadLine();
            //int liczba = int.Parse(odpowiedz);

            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //    if(i == liczba)
            //    {
            //        Console.WriteLine("znalezionpo liczbe " + liczba);
            //        break;
            //    }

            //}

            //Console.WriteLine("Podaj liczbe od 0 do 100");
            //string odpowiedz2 = Console.ReadLine();
            //int liczb2 = int.Parse(odpowiedz2);

            //int i = 0;

            //while (true)
            //{
            //    if(i== liczb2){
            //        Console.WriteLine(liczb2);
            //        break;
            //    }
            //    Console.WriteLine("Liczba "+i+" nie rowna się "+liczb2);
            //    i++;



            //}

            int liczb3;

            do
            {
                Console.WriteLine("Podaj liczbe od 3 do 8");
                string odpowiedz3 = Console.ReadLine();
                liczb3 = int.Parse(odpowiedz3);
            } while (liczb3 < 3 || liczb3 > 8);

            Console.WriteLine("Poprawna liczba ");

            

        }
    }
}