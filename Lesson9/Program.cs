using System;
using System.Collections.Generic;

namespace Lesson9
{
    class Program
    {
        static void Main()
        {
            // short[] nums = {5, 6, 7, 8, 5, 3, 4};
            // foreach(short el in nums) Console.WriteLine("El: " + el);

            // short[,] nums = {{5, 6, 7}, {8, 5, 3}, {54, 7, 20}};
            // foreach(short el in nums) Console.WriteLine("El: " + el);

            List<int> numbers = new List<int>() {4, 6, 7};
            numbers.Add(40);
            numbers.Add(100);
            numbers.Add(5);
            numbers.Remove(100);
            numbers.Sort();
            numbers.Reverse();
            
            foreach(int el in numbers) Console.WriteLine("El: " + el);
        }
    }
}