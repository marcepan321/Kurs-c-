using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie14
{
    public class Kwadrat
    {
        public int LGRX;
        public int LGRY;
        public int PDRX;
        public int PDRY;

        public Kwadrat(int LGRX, int LGRY, int PDRX, int PDRY)
        {
            this.LGRX = LGRX;
            this.LGRY = LGRY;
            this.PDRX = PDRX;
            this.PDRY = PDRY;
        }
        
        public void wys()
        {
            Console.WriteLine(LGRX);
            Console.WriteLine(LGRY);
            Console.WriteLine(PDRX);
            Console.WriteLine(PDRY);
        }
        
    }
}
