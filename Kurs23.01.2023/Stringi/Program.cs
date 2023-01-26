namespace Stringi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "\tAla ma\\ \"kota"\"!\b\b \n\tDruga linia.";

            string test2 = @"Ala
ma
kota";

            Console.WriteLine(test);
            Console.WriteLine(test2);

            string test3 = "String 1 to " + test + " String 2 to " + test2;

            Console.WriteLine(test3);
        }
    }
}