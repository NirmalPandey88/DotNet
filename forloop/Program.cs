//for loops


//Simple pattern programs which prints a pattern of symbols
using System;


namespace forloop{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" ^");
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("|");
                for (int j = 1; j <= i; j++)
                {
                    if (i <= 5)
                    {
                        Console.Write("* ");
                    }

                }
                Console.Write(@"\");
                Console.WriteLine();
            }


            for (int i = 1; i <= 5; i++)
            {
                Console.Write("|");
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write(@"\");
                Console.WriteLine();
            }
            for (int i = 5; i >= 1; i--)
            {
                if (i >= 3)
                {
                    Console.WriteLine("|");
                }
                else
                {
                    Console.WriteLine("||");
                }

            }
        }
    }
}
