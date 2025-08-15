using System;

namespace CsharpPlayersGuide.Chapter12_Arrays
{
    public static class TheReplicatorOfDo_To
    {
        public static void Run()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] original = new int[5];

            for(int i=0; i < original.Length; i++)
               
            {
                Console.Write($"Gib Zahl #{i + 1} ein:");
                string? input = Console.ReadLine();
                int value = Convert.ToInt32(input);
                original[i] = value;
            }

            int[] copy = new int[5];
            for (int i=0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            Console.WriteLine("Original:");
            for (int i = 0; i < original.Length; i++)
            {
                Console.WriteLine(original[i]);
            }

            Console.WriteLine("Kopie");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.WriteLine(copy[i]);
            }

        }
    }
}
