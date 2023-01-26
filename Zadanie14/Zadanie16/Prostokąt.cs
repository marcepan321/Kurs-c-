using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie16
{
    internal class Prostokąt : Kwadrat
    {
        public int bokPros { get; set; }


         
        public Prostokąt(int typ, int[] LewyGorny, int[] PrawyDolny, int id, int bokPros): base (typ, LewyGorny, PrawyDolny, id)
        {
            this.bokPros = bokPros;
        }
        
        public new void Wyświetl()
        {
            base.Wyświetl();
            Console.WriteLine("Bok prostokąta = " + bokPros);
        }
    }
}
