namespace zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine();
            //Console.WriteLine("Podaj liczbę: ");
            //string wartość = Console.ReadLine();
            //double x = Convert.ToInt32(wartość);

            //switch (x)
            //{
            //    case 1:
            //    case 4:
            //    case 8:
            //        Console.WriteLine("Ta liczba to 1,4 lub 8");
            //        break;
            //    case 2:
            //    case 3:
            //    case 7:
            //        Console.WriteLine("Ta liczba to 2,3 lub 7");
            //        break;
            //    default:
            //        Console.WriteLine("To jest inna liczba");
            //        break;

                    Console.WriteLine();
            Console.WriteLine("Podaj pierwszą liczbę: ");
            string wartość = Console.ReadLine();
            double x = Convert.ToInt32(wartość);
            Console.WriteLine("Podaj drugą liczbę: ");
            string wartość2 = Console.ReadLine();
            double y = Convert.ToInt32(wartość2);
            Wybor wybor;
            Console.WriteLine("0-dodawanie, 1-odejmowanie, 2-mnożenie, 3-dzielenie, 4-potęgowanie");
            wybor = (Wybor)Convert.ToInt32(Console.ReadLine());
            
            switch (wybor)
            {
                case Wybor.Dodawanie:
                    Console.WriteLine(x + y);
                    break;
                case Wybor.Odejmowanie:
                    Console.WriteLine(x - y);
                    break;
                case Wybor.Mnożenie:
                    Console.WriteLine(x * y);
                    break;
                case Wybor.Dzielenie:
                    if(y!=0)
                    Console.WriteLine(x / y);
                    break;
                case Wybor.Potęgowanie:
                    Console.WriteLine(Math.Pow(x, y));
                    break;
                default:
                    Console.WriteLine("Bład");
                    break;
            }

              
       

            
        }
        enum Wybor
        {
            Dodawanie = 0,
            Odejmowanie = 1,
            Mnożenie = 2,
            Dzielenie = 3,
            Potęgowanie =4
        }
    }
}