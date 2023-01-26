using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie16
{
    public class Kwadrat : ObjectInterface
    {
        
        public int[] LewyGorny = new int[2];
        public int[] PrawyDolny = new int[2];
        public int id;
        public int typ;

        public int bok
        {
            get
            {
                return PrawyDolny[0] - LewyGorny[0];
            }
        }

        


        

        public Kwadrat(int typ, int[] LewyGorny, int[] PrawyDolny, int id)
        {
            this.LewyGorny[0] = LewyGorny[0];
            this.LewyGorny[1] = LewyGorny[1];
            this.PrawyDolny[0] = PrawyDolny[0];
            this.PrawyDolny[1] = PrawyDolny[1];
            this.id = id;
            this.typ = typ;
        }

        
        public int ObliczPole() => bok * bok;
        public int ObliczObw() => 4 * bok;
        public int PobierzBok() => bok;


        public void Wyświetl()
        {
            Console.WriteLine($"Obiekt o id = {id}");
            //if (typ == 1) Console.WriteLine("Obiekt typu = Kwadrat");
            //else if (typ == 2) Console.
            Console.WriteLine("Wspolrzendne lewy gorny: ");
            Console.WriteLine("x: " + LewyGorny[0]);
            Console.WriteLine("y: " + LewyGorny[1]);
            Console.WriteLine("Wspolrzende prawy dony: ");
            Console.WriteLine("x: " + PrawyDolny[0]);
            Console.WriteLine("y: " + PrawyDolny[1]);
        }

        public void Wyswitel()
        {
            throw new NotImplementedException();
        }
    }
}
