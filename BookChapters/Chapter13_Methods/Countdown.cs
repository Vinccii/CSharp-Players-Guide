using System;

namespace CsharpPlayersGuide.Chapter13_Methods
{
    public static class Countdown
    {
        public static void Run()
        {
          
            DoCountdown(10);
        }
        
         static void DoCountdown(int number)
        {
            if (number == 0) return;

            Console.WriteLine(number);
            DoCountdown(number - 1);
        }
    }
}