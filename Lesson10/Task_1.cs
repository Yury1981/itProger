using System;

namespace Lesson10
{
    class Program
    {
        static void Main()
        {
            byte[] nums = {5, 7, 8, 3, 5};
            byte[] nums1 = {5, 3, 8, 3, 5};
            byte res = Summa(nums);
            Console.WriteLine("Result: " + res);
            byte res1 = Summa(nums1);
            Console.WriteLine("Result: " + res1);
        }
    public static byte Summa(byte[] digits)
    {
        byte summ = 0;
        foreach(byte el in digits) summ += el;
        return summ;
    }
        
    }
}