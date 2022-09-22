using System;

namespace Lesson12
{
    class Program
    {
        static void Main()
        {
            // try
            // {
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine(num);
            // }
            // catch(FormatException)
            // {
            //     Console.WriteLine("Vveli ne tot format!");
            // }

            try{
            int a, b, res;
            Console.Write("Vvedite 1-e chislo: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Vvedite 2-e chislo: ");
            b = Convert.ToInt32(Console.ReadLine());
            res = a / b;
            Console.WriteLine(res);
            }
            catch(DivideByZeroException){
                Console.WriteLine("Delenie na 0!");
            }
            catch(FormatException){
                Console.WriteLine("Vveli ne tot format!");
            }
            finally{
                
            }
            
        }
    }
}