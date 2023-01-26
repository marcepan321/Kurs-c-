namespace Zadanie14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kwadrat kwadrat = new Kwadrat(1, 2, 3, 4);
            KolorowyKwadrat kolorowykwadrat = new KolorowyKwadrat("czerwony", 20, 15, 60,5);
            Console.WriteLine("Kwadrat");
            kwadrat.wys();
            Console.WriteLine("Kolory kwa");
            kolorowykwadrat.wys();
            
        }

    }

    public class KolorowyKwadrat : Kwadrat
    {
        public string Kolor;
        
        public KolorowyKwadrat(string kolor,int LGRX, int LGRY, int PDRX, int PDRY):base( LGRX,  LGRY,  PDRX, PDRY)
        {
            Kolor = kolor;
        }
        public void wys()
        {
            base.wys();
            Console.WriteLine(Kolor);
        }
        
    }
}