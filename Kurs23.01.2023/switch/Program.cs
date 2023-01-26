namespace switche;
internal class Program

{
    static void Main(string[] args)

 
    {
       



        Console.WriteLine("Podaj wartość (tak/może/nie)?");
        string wybór = Console.ReadLine();

        switch (wybór.ToLower().Trim())
        {
            case "tak":
            case "może":
                Console.WriteLine("Świetnie");
                break;
            case "nie":
                Console.WriteLine("Niedobrze");
                break;
            default:
                Console.WriteLine("Niezana wartość");
                break;
        }
    }




} 


