using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
         while (true)
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to the Mindfulness Program");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Listing Activity");
            Console.WriteLine("3. Start Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();
            Activity activity = null;

            switch (input)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    Thread.Sleep(2000);
                    continue;
            }

            activity.DisplayStartingMessage();
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            
            if (int.TryParse(Console.ReadLine(), out int duration))
            {
                activity.SetDuration(duration);
                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            else
            {
                Console.WriteLine("Invalid duration.");
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}