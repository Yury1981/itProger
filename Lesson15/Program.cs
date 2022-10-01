using System;

namespace Lesson14
{
    class Program
    {
        static void Main()
        {
            Robot bot = new Robot("Bot", 800, new byte[] {0, 0, 0});
            bot.printValues();
            
            Robot killer = new Robot();
            killer.setValues("Killer", 1000, new byte[] {0, 0, 10});
            killer.printValues();

            Robot bot1 = new Robot("Bot");
            
            // Robot.count = 5;
            Robot.Print();
        }
    }
}