namespace Zadanie13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt punkt = new Punkt();
        }

    }
    class Punkt
    {
        public int liczba;
        public Punkt()
        {
            this.liczba = -1;
        }

        public Punkt(int liczba)
        {
            this.liczba = liczba;
        }
    }

    class Punkt2
    {
        public double pole1;
        public char pole2;


        public Punkt2(double pole1, char pole2)
        {
            this.pole1 = pole1;
            this.pole2 = pole2;
        }

        public Punkt2(char pole2, double pole1) : this(pole1,pole2)
        {

        }

        public Punkt2(char pole2) : this(0, pole2) { }

        public Punkt2(double pole1) : this(pole1, '0') { }
    }
}