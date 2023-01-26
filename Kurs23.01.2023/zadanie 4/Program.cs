namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.WriteLine("Podaj swój wiek: ");
            //string wartość = Console.ReadLine();
            //int x = Convert.ToInt32(wartość);
            ////Console.WriteLine(x >= 18 ? "Pelnoletni" : "nie pelnoletni");
            //if (x >= 18)
            //{
            //    Console.WriteLine("Jesteś pełnoletni");
            //}else
            //{
            //    Console.WriteLine("Nie jesteś pełnoletni");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Podaj pierwszą liczbę: ");
            //string wartość = Console.ReadLine();
            //int x = Convert.ToInt32(wartość);
            //Console.WriteLine("Podaj drugą liczbę: ");
            //string wartość2 = Console.ReadLine();
            //int y = Convert.ToInt32(wartość2);
            //if (x > y)
            //{
            //    Console.WriteLine("Pierwsza liczba jest większa od drugiej");
            //}
            //else if (y > x)
            //{
            //    Console.WriteLine("Druga liczba jest większa od drugiej");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Obie liczby są takie same");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Podaj pierwszą liczbę; ");
            //string wartość = Console.ReadLine();
            //int a = Convert.ToInt32(wartość);
            //Console.WriteLine("Podaj drugą liczbę: ");
            //string wartość2 = Console.ReadLine();
            //int b = Convert.ToInt32(wartość2);
            //Console.WriteLine("Podaj trzecią liczbę: ");
            //string wartość3 = Console.ReadLine();
            //int c = Convert.ToInt32(wartość3);
            //double delta = Math.Pow(b, 2) - 4 * a * c;
            //if (delta > 0)
            //{
            //    Console.WriteLine("Są dwa rozwiązania");
            //}else if (delta < 0)
            //{
            //    Console.WriteLine("Nie ma rozwiązań");
            //}else
            //{
            //    Console.WriteLine("Jest jedno rozwiązanie");
            //}









            Console.WriteLine();
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string wartość = Console.ReadLine();
            double x = Convert.ToInt32(wartość);
            Console.WriteLine("Podaj drugą liczbę: ");
            string wartość2 = Console.ReadLine();
            double y = Convert.ToInt32(wartość2);
            int wybor;
            Console.WriteLine("0-dodawanie, 1-odejmowanie, 2-mnożenie, 3-dzielenie");
            wybor = Convert.ToInt32(Console.ReadLine());
            if (wybor == 0)
            {
                Console.WriteLine(x + y);
            }else if (wybor == 1)
            {
                Console.WriteLine(x - y);
            }else if (wybor == 2)
            {
                Console.WriteLine(x * y);
            }else
            {
                if (y == 0)
                {
                    Console.WriteLine("Nie można dzielić przez zero");
                }
                else
                Console.WriteLine(x / y);
            }
        }
        }
}