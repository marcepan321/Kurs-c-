using static System.Net.Mime.MediaTypeNames;

namespace Dzien4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresPliku = "C:\\Users\\PLC\\Desktop\\test.txt.txt";



            StreamReader streamReader = new StreamReader(adresPliku);

            string line = streamReader.ReadLine();
            Console.WriteLine(line);
            line= streamReader.ReadLine();
            Console.WriteLine(line);
            streamReader.Close();
            Console.ReadLine();
        }
    }
}