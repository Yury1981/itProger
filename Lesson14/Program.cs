using System;

namespace Lesson14
{
    class Program
    {
        static void Main()
        {
            Robot bot = new Robot();
            bot.setValues("Bot", 800, new byte[] {0, 0, 0});
            // bot.name = "Bot";
            // bot.weight = 800;
            // bot.coordinates = new byte[] {0, 0, 0};
            bot.printValues();
            // Console.WriteLine(bot.name + " weight: " + bot.weight);

            Robot killer = new Robot();
            killer.setValues("Killer", 1000, new byte[] {0, 0, 10});
            // killer.name = "Killer";
            // killer.weight = 1000;
            // killer.coordinates = new byte[] {0, 0, 10};
            killer.printValues();
            // Console.WriteLine(killer.name + " weight: " + killer.weight);
        }
    }
}