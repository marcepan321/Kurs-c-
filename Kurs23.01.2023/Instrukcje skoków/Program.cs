namespace Instrukcje_skoków
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbe");
            string odpowiedz = Console.ReadLine();
            int liczba = int.Parse(odpowiedz);

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == liczba)
                {
                    Console.WriteLine("znaleziono liczbe " + liczba);
                    break;
                }
            }


        }
    }
}