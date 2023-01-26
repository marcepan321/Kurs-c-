namespace Klasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt zmiennaPunkt = new Punkt();

            zmiennaPunkt.y = 100;
            zmiennaPunkt.x = 200;

            

            Punkt zmiennaPunkt2 = new Punkt();
            zmiennaPunkt2.y = 1000;
            zmiennaPunkt2.x = 2000;


            zmiennaPunkt.WyświetlWspółrzedne();
            zmiennaPunkt2.WyświetlWspółrzedne();

            var test = zmiennaPunkt2.PobierzY();
            Console.WriteLine(test);
        }
    
    }
}