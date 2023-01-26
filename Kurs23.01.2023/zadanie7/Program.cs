namespace zadanie7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start pętli for");



            //for (int i = 1; i <= 10; i++)
            //{

            //    if(i % 2 == 0){
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("Start petli ");

            //int i = 1;

            //while (i <= 20)
            //{
            //    if (i % 3 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //Console.WriteLine("Strat pętli");

            //int i = 1;

            //while (i <= 20)
            //{
            //    i++;
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("Parzyste "+i);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Nieparzyste "+i);
            //    }

            //}


            Console.WriteLine("Strart pętli");

            int i = 100;

            while (i >= 1)
            {
                
                i--;
                if (i % 3==0 && i % 2!=0)
                {
                    Console.WriteLine(i);
                }
                
            }

        }
    }
}