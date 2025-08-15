using System;

namespace CsharpPlayersGuide.Chapter12_Arrays
{
    ´public static class The_Laws_of_Freach
    {
        public static void Run()
        {
            // code for computing an array’s minimum value
           /* int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue; // Start higher than anything in the array.
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] < currentSmallest)
                    currentSmallest = array[index];
            }
            Console.WriteLine(currentSmallest);*/

           foreach (int value in array)
            {
                if (value < currentMinimum)
                    currentMinimum = value;
            }
                Console.WriteLine(currentSmallest);
           
            // code for computing an array's average value
            /*int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            for (int index = 0; index < array.Length; index++)
                total += array[index];
            float average = (float)total / array.Length;
            Console.WriteLine(average);*/

            
            int total = 0;

            foreach (int value in array)
                total += value;
            float average = (float)total / Array.MaxLength;
            Console.WriteLine(average);
            
        }
    }
}
