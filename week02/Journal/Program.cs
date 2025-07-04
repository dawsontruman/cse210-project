using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        // instantiate the prompt generator
        PromptGenerator prompts = new PromptGenerator();
        // start a new journal
        Journal journal = new Journal();

        while (true)
        {
            // display list of options
            Console.WriteLine("Journal Program");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry.");
            Console.WriteLine("2. Display current journal.");
            Console.WriteLine("3. Load a journal.");
            Console.WriteLine("4. Save current journal.");
            Console.WriteLine("5. Quit");

            // take user selection
            Console.Write("Enter a number for your selection: ");
            string input0 = Console.ReadLine();
            int selection = 0;
            try
            {
                selection = int.Parse(input0);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please only enter the number of an option in the list.\n");
                continue;
            }

            // 1. Write a new entry.
            if (selection == 1)
            {
                // take current system date
                DateTime currentTime = DateTime.Now;
                string date = currentTime.ToShortDateString();

                // get a random prompt and write to user
                string newPrompt = prompts.GetRandomPrompt();
                Console.WriteLine($"{newPrompt}");

                // user enters text for a journal entry
                string newText = Console.ReadLine();

                // generate full entry with date, prompt, and text; then append to current journal
                Entry newEntry = new Entry(date,newPrompt,newText);
                journal.AddEntry(newEntry);
            }

            // 2. Display current journal.
            if (selection == 2)
            {
                journal.DisplayAll();
            }

            // 3. Load a journal.
            if (selection == 3)
            {

            }

            // 4. Save the current journal.
            if (selection == 4)
            {
                // prompt user for file name
                Console.Write("Enter a name for this journal: ");
                string newFileName = Console.ReadLine();

                // save the journal using the file name given by the user
                journal.SaveToFile(newFileName);
            }

            // 5. Quit
            else if (selection == 5)
            {
                break;
            }
        }
    }
}