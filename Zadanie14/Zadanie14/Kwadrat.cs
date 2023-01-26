using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    public class Kwadrat
    {
        private int LGRX;
        private int LGRY;
        private int PDRX;
        private int PDRY;
        private int bok;

        public Kwadrat(int LGRX, int LGRY, int PDRX, int PDRY)
        {
            this.LGRX = LGRX;
            this.LGRY = LGRY;
            this.PDRX = PDRX;
            this.PDRY = PDRY;
            this.bok = LGRX - PDRX;
        }

        public void wys()
        {
            Console.WriteLine(LGRX);
            Console.WriteLine(LGRY);
            Console.WriteLine(PDRX);
            Console.WriteLine(PDRY);
      }
        public int ObliczPole() => bok * bok;
        public int ObliczObw() => 4 * bok;
        public int PobierzBok() => bok;


    }
}
