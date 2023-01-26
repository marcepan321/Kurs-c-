using System.Reflection.Emit;

namespace Zadanie_12._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Prostokat cos = new Prostokat(4,0,4,0);
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            cos.ObliczObwod();
            cos.PrzesunProstokat(x,y);
            cos.ObliczObwod();
            cos.RozciagnijProstokat(x, y);
            cos.ObliczObwod();
            cos.ObliczPole();
        }
    }
    class Prostokat
    {
        public int PX;
        public int LX;
        public int GY;
        public int DY;

        public Prostokat(int px,int lx,int gy,int dy)
        {
            PX = px;
            LX = lx;
            GY = gy;
            DY = dy;
      
           
            
        }
        public void ObliczPole()
        {
            int a = PX - LX;
            int b = GY-DY;
            int obw = a * b;
            Console.WriteLine(obw);

        }
        public void ObliczObwod()
        {
            int a = PX - LX;
            int b = GY - DY;
            int obw = a * 2 + 2 * b;

            Console.WriteLine(obw);
        }
        public void PrzesunProstokat(int x,int y)
        {
            PX = PX + x;
            LX = LX+x;
            GY = GY + y;
            DY = DY + y;
        }
        public void RozciagnijProstokat(int x, int y)
        {
            PX = PX + x;
            LX = LX - x;
            GY = GY + y;
            DY = DY - y;
        }
    }
}