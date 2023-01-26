using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie16
{
    public class KolorowyKwadrat : Kwadrat
    {
        private string Kolor;

        public KolorowyKwadrat(int typ, int[] LewyGorny, int[] PrawyDolny, int id, string kolor) : base(typ, LewyGorny, PrawyDolny, id)
        {
            Kolor = kolor;
        }

        public string KolorKwadratu() => Kolor;


        public new void Wyświetl()
        {
            base.Wyświetl();
            Console.WriteLine("Kolor kwadratu = " + Kolor);
        }

    }
}
