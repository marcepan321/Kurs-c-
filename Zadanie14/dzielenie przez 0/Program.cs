
namespace dzielenie_przez_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {


                int liczba1 = 10;
                int liczba2 = 0;
                int.Parse("aaa");
                //throw new Exception("Mój wyjątek");

                int liczba3 = liczba1 / liczba2;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }

            Console.WriteLine("Koniec programu");
        }
    }
}