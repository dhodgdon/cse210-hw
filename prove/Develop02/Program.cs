// To exceed the requirements for this assignment, I saved the time of the 
// journal entry as well and included it in each displayed journal entry.

using System;

class Program
{
    static void Main(string[] args)
    {
        string selector = "";
        Console.WriteLine("Welcome to the Journal Program!");

        Journal myJournal = new Journal();


        do
        {
            string _menu = "Please select one of the following choices: \n1. Write \n2. Display \n3. Load \n4. Save \n5. Quit \nWhat would you like to do? ";
            Console.Write(_menu);
            selector = Console.ReadLine();
        


            // Generate random prompt from list and record user answer.
            if (selector == "1")
            {
                PromptGenerator prompt = new PromptGenerator();
                string prompt1 = prompt.GeneratePrompt();
                Console.Write($"{prompt1} \n> ");

                Entry entry = new Entry();
                entry._prompt = prompt1;
                entry._entry = Console.ReadLine();

                myJournal._journals.Add(entry);
            }

            // Display user entries in compiled journal format
            else if (selector == "2")
            {
                myJournal.DisplayEntries();
            }

            // Load entries from a file.
            else if (selector == "3")
            {
                Console.WriteLine("What is the filename?");
                string loadFileName = Console.ReadLine();
                myJournal = myJournal.LoadFromFile(loadFileName);
            }

            // Save entries to a file.
            else if (selector == "4")
            {
                Console.WriteLine("What is the filename?");
                string saveFileName = Console.ReadLine();
                myJournal.SaveToFile(saveFileName);
            }

            // In case the user enters something that is not an option...
            else
            {
                Console.WriteLine("That is not an option.");
            }


        } while (selector != "5");
    }
}