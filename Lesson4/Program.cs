using System;

namespace Lesson4
{
    class Program
    {
        static void Main()
        {
            // float user_input;
            // Console.Write("Введите число с точкой: ");
            // user_input = Convert.ToDouble(Console.ReadLine());
            // float user_input = float.Parse(Console.ReadLine());
            // float result;
            // result = user_input + 10f;
            // result = user_input - 15f;
            // result = user_input * 2f;
            // result = user_input / 5f;
            // result = user_input % 2f;
            // int a = 5, b = 6;
            // int res = a + b;
            // result = result + 5f;
            // result += 5f;
            // result *= 2f;
            // result++;
            // Console.WriteLine("Переменная: " + result);
            // System.Console.WriteLine(Math.PI);
            // System.Console.WriteLine(Math.E);
            // System.Console.WriteLine(Math.Abs(-20));
            // Console.WriteLine(Math.Ceiling(4.11f));
            // Console.WriteLine(Math.Floor(4.99f));
            // Console.WriteLine(Math.Round(4.51f));
            // Console.WriteLine(Math.Min(5, 0));
            // Console.WriteLine(Math.Max(5, 0));
            // Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);
        }
    }
}
