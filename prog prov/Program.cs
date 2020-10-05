using System;

namespace prog_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            int rättsvar = 4;
            string spelargissning = "";
            int gissning = 0;

            while (gissning != 4)
            {
                Console.WriteLine("Du ska sänka fiende skäppet, gissa en siffra mellan 1-10!");
                spelargissning = Console.ReadLine();


                try
                {
                    gissning = Int32.Parse(spelargissning);

                }
                catch
                {
                    Console.WriteLine("Du skrev inte en siffra mellan 1-10");

                }


                if (gissning >= 1 && gissning <= 10)
                {
                    if (gissning == rättsvar - +2 || gissning == rättsvar + -1)
                    { Console.WriteLine("Near Miss!"); }
                    else
                    {
                        Console.WriteLine("Miss!");
                    }


                }
                else
                {

                    Console.WriteLine("Du skrev inte en siffra mellan 1-10");
                }

            }

            Console.WriteLine("Du träffade!!!");




            Console.ReadLine();
        }
    }
}
