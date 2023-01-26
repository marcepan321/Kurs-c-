namespace Zadanie14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kwadrat = new Kwadrat(1, 2, 3, 4);
            KolorowyKwadrat kolorowykwadrat = new KolorowyKwadrat("czerwony", 20, 15, 15, 20);
            Console.WriteLine(kolorowykwadrat.ObliczPole());
            Console.WriteLine(kolorowykwadrat.ObliczObw());
            Console.WriteLine(kolorowykwadrat.PobierzBok());
            Console.WriteLine(kolorowykwadrat.KolorKwadratu());


        }

    }

    public class KolorowyKwadrat : Kwadrat
    {
        private string Kolor;

        public KolorowyKwadrat(string kolor, int LGRX, int LGRY, int PDRX, int PDRY) : base(LGRX, LGRY, PDRX, PDRY)
        {
            Kolor = kolor;
        }
        
        public string KolorKwadratu() => Kolor;

    }
}