using System;

namespace CsharpPlayersGuide.Chapter11_Looping
{
    public static class ThePrototype
    {
        public static void Run()
        {
            int pilotInput;
            do
            {
                Console.WriteLine("Hello Pilot, please enter a Number between 0 and 100.");
                pilotInput = Convert.ToInt32(Console.ReadLine());
            }
            while (pilotInput < 0 || pilotInput > 100);
            Console.Clear();

            Console.WriteLine("Hello Hunter, please guess a Number.");
            {
                while (true)
                {
                    int hunterInput = Convert.ToInt32(Console.ReadLine());

                    if (hunterInput < pilotInput)
                        Console.WriteLine($"{hunterInput} is too low.");
                    else if (hunterInput > pilotInput)
                        Console.WriteLine($"{hunterInput} is too high.");
                    else
                    {
                        Console.WriteLine("You guessed the right number!");
                        break;
                    }
                    Console.WriteLine("What is your next guess?");
                }
            }

        }
    }
        
}
