using System;

namespace Lesson5
{
    class Program
    {
        static void Main()
        {
            // int a = 5;
            // bool isHasCar = false;
            // // string word = "hello";
            // // bool isHappy = true;
            // // if (word == "hello") ;
            // // if (isHappy) ; // = if (isHappy == true) ;
            // // if (!isHappy) ; // = if (isHappy == false) ;

            // if (a > 7) Console.WriteLine("Number > 7");
            // else if (a < 5) Console.WriteLine("Number < 5");
            // else if (a == 4) Console.WriteLine("Number is 4");
            // else if ((a == 5 || isHasCar) && a > 2)
            // {
            //     Console.WriteLine("Number is 5");
            //     // if (isHasCar)
            //     Console.WriteLine("User has car!");
            // }
            // else Console.WriteLine("Number is unreccognized!");
            Console.Write("Enter name: ");
            string role = Console.ReadLine();
            if (role == "Admin")
            {
                Console.Write("Enter user name: ");
                string user_name = Console.ReadLine();
                Console.Write("Enter {0} age: ", user_name);
                short age = Convert.ToInt16(Console.ReadLine());
                if (age < 0 || age > 99)
                {
                    Console.Write("Enter {0} age: ", user_name);
                    age = Convert.ToInt16(Console.ReadLine());
                }
                if (age < 0 || age > 99)
                {
                    Console.WriteLine("Error");
                    age = 0;
                }
                else Console.Write("User's age is " + age);
            }
            else Console.Write("You are not admin!");
        }
    }
}