using System;

namespace uppgift_4._10
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int XPG = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O per grupp?");
            int OPG = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många O-mönster per rad");
            int OM = int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många rader?");
            int R = int.Parse(Console.ReadLine());

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < OM; j++ )
                {
                    for(int k = 0; k <= XPG; k++)
                    {
                        Console.Write("X");
                    }
                    Console.Write("-");
                    for (int l = 0; l <= OPG; l++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("-");
                }
                for(int m = 0; m <= XPG; m++)
                {
                    Console.Write("X");
                }
                Console.WriteLine("");
            }
        }
    }
}