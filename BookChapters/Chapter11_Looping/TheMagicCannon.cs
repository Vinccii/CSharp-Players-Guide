using System;

namespace CsharpPlayersGuide.Chapter11_Looping
{
    public static class TheMagicCannon
    {
        public static void Run()
        {
            
            for (int i = 1; i <= 100; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Combined blast activated!!");                  
                }

                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fire gem activated!");                  
                }

                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Electric gem activated!");
                }

                else
                    Console.WriteLine("Normal");
              
            }
        }
    }
}
