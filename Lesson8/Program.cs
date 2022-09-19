using System;

namespace Lesson8
{
    class Program
    {
        static void Main()
        {
            // byte[] nums = new byte[5];
            // nums[0] = 250;
            // nums[1] = 50;
            // nums[2] = 20;
            // nums[3] = 100;
            // nums[4] = 25;
            // Console.WriteLine("El: " + nums[0]);

            // string[] words = new string[] {"John", "Bob", "Alex"};
            // words[1] = "Josh";
            // for (int i = 0; i < nums.Length; i++) Console.WriteLine("El: " + nums[i]);
            // for (int i = 0; i < words.Length; i++) Console.WriteLine("El: " + words[i]);

            // short[] numbers = new short[10];
            // Random random = new Random();
            // short summa = 0;
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     numbers[i] = Convert.ToInt16(random.Next(-15, 15));
            //     Console.WriteLine("El: " + numbers[i]);
            //     summa += numbers[i];
            // }
            // Console.WriteLine("Summa: " + summa);

            // char[,] symbols = new char[2,3]; 
            // symbols[0, 0] = 'H';
            // Console.WriteLine(symbols[0, 0]);

            int[,] nums = 
            {
                {4, 6, 7},
                {5, 7, 3},
                {3, 3, 2}
            };

            nums[1, 2] = 56;
            for (int m = 0; m < nums.GetLength(0); m++)
            {
                for (int n = 0; n < nums.GetLength(1); n++)
                    Console.Write(nums[m, n] + ", ");
            Console.WriteLine();
            }



        }
    }
}
