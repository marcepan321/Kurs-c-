using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasy
{
    internal class Punkt
    {
        public int x;
        public int y;

        public void WyświetlWspółrzedne()
        {
            Console.WriteLine("Współrzędna x = " + x);
            Console.WriteLine("Współrzędna y = " + y);
        }

        public int PobierzX()
        {
            return x;
        }

        public int PobierzY() => y;
        
    }
}
