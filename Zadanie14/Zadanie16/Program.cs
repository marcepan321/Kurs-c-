using System;
using System.Diagnostics.CodeAnalysis;

namespace Zadanie16
{
    internal class Program 
    { 
        static void Main(string[] args)
        {
            //Prostokąt prostokat= new Prostokąt(8, 5 , 3, 4, 2);
            //prostokat.wys();
            //prostokat.Wyświetl();
            //Kwadrat kwa = new Kwadrat(5, 8, 7, 2);
            //Console.WriteLine();
            //kwa.wys();

          

            List<Kwadrat> objects = new List<Kwadrat>();
            int id = 0;
            int[] LewyGorny = new int[2];
            int[] PrawyDolny = new int[2];
            int bok;
            string kolor;
            
            for(; ; )
            {
                Console.Clear();
                Console.WriteLine("1.Dodawanie Obiektów");
                Console.WriteLine("2.Pokaż obiekty");
                Console.WriteLine("3.Usun obiekt");
                Console.WriteLine("5.wygeneruj kwadrat");
                int wybor = int.Parse(Console.ReadLine());
                
                switch (wybor)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("1.Dodaj Kwadrat");
                        Console.WriteLine("2.Dodaj Prostokąt");
                        Console.WriteLine("3.Dodaj Kolorowy Kwadrat");
                        Console.WriteLine("4. Zapisz obiekty");
                        int wybor2 = int.Parse(Console.ReadLine());
                        switch (wybor2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Podaj wspolrzedne lewy gorny");
                                Console.Write("x:");
                                LewyGorny[0] = int.Parse(Console.ReadLine());
                                Console.Write("y:");
                                LewyGorny[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj wspolrzedne prawy dolny");
                                Console.Write("x:");
                                PrawyDolny[0] = int.Parse(Console.ReadLine());
                                Console.Write("y:");
                                PrawyDolny[1] = int.Parse(Console.ReadLine());
                                objects.Add(new Kwadrat(1,LewyGorny,PrawyDolny,id));
                                id++;
                                break;

                            case 2:
                                Console.Clear();
                                Console.WriteLine("Podaj wspolrzedne lewy gorny");
                                Console.Write("x:");
                                LewyGorny[0] = int.Parse(Console.ReadLine());
                                Console.Write("y:");
                                LewyGorny[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj wspolrzedne prawy dolny");
                                Console.Write("x:");
                                PrawyDolny[0] = int.Parse(Console.ReadLine());
                                Console.Write("y:");
                                PrawyDolny[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj długość boku prostokąta");
                                bok = int.Parse(Console.ReadLine());
                                objects.Add(new Prostokąt(2,LewyGorny, PrawyDolny, id, bok));
                                id++;
                                break;

                            case 3:
                                Console.Clear();
                                Console.WriteLine("Podaj wspolrzedne lewy gorny");
                                Console.Write("x:");
                                LewyGorny[0] = int.Parse(Console.ReadLine());
                                Console.Write("y:");
                                LewyGorny[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj wspolrzedne prawy dolny");
                                Console.Write("x:");
                                PrawyDolny[0] = int.Parse(Console.ReadLine());
                                Console.Write("y:");
                                PrawyDolny[1] = int.Parse(Console.ReadLine());
                                Console.WriteLine("Podaj kolor");
                                kolor = Console.ReadLine();
                                objects.Add(new KolorowyKwadrat(3,LewyGorny, PrawyDolny, id, kolor));
                                id++;
                                break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Twoje obiekt");
                        foreach(var kwadrat in objects)
                        {

                            if(kwadrat.typ == 1) kwadrat.Wyświetl();
                            if(kwadrat.typ == 2) (kwadrat as Prostokąt).Wyświetl();
                            if(kwadrat.typ == 3) (kwadrat as KolorowyKwadrat).Wyświetl();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Lista Obiektów");
                        foreach (var kwadrat in objects)
                        {

                            if (kwadrat.typ == 1) kwadrat.Wyświetl();
                            if (kwadrat.typ == 2) (kwadrat as Prostokąt).Wyświetl();
                            if (kwadrat.typ == 3) (kwadrat as KolorowyKwadrat).Wyświetl();
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                        int wybor3 = int.Parse(Console.ReadLine());
                        objects.Remove(objects.Where(item => item.id == wybor3).ToList()[0]);
                        break;

                    case 5:

                        break;


                }
            }
            
        }
    }
}