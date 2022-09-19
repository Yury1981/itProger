using System;

namespace Lesson6
{
    class Program
    {
        static void Main()
        {
            short user_input = Convert.ToInt16(Console.ReadLine());
            switch(user_input)
            {
                case 5: Console.WriteLine("Number is 5"); break;
                case 15: Console.WriteLine("Number is 15"); break;
                case 20: Console.WriteLine("Number is 20"); break;
                case 250: Console.WriteLine("Number is 250"); break;
                default: Console.WriteLine("Number is unrecognized!"); break;
            }
        }
    }
}