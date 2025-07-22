using System;

class Program
{
    static void Main(string[] args)
    {
        bool whileLoop = true;
        while (whileLoop)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Listing Activity");
            Console.WriteLine("  3. Start Reflecting Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            // 1. Breathing Activity
            if (userChoice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            // 2. Listing Activity
            else if (userChoice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
            // 3. Reflecting Activity
            else if (userChoice == "3")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            // 4. Quit
            else if (userChoice == "4")
            {
                whileLoop = false;
            }
            else
            {
                continue;
            }
        }
    }
}