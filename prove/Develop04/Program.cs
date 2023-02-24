// To exceed requirements, I included a more meaningful 
// animation for the breathing using an expanding circle.

using System;

class Program
{
    static void Main(string[] args)
    {
        string _selection;

        do
        {
            Console.Clear();
            Console.Write("Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4. Quit\nSelect a choice from the menu: ");
            
            _selection = Console.ReadLine();
            Console.Clear();

            if (_selection == "1")
            {
                BreathingActivity b1 = new BreathingActivity();
                b1.StartMessage();
                b1.GetReady();
                b1.Breathe();
                b1.EndMessage();
            }
            else if (_selection == "2")
            {
                ReflectingActivity r1 = new ReflectingActivity();
                r1.StartMessage();
                r1.GetReady();
                r1.Prompt();
                r1.DisplayQuestions();
                r1.EndMessage();
            }
            else if (_selection == "3")
            {
                ListingActivity l1 = new ListingActivity();
                l1.StartMessage();
                l1.GetReady();
                l1.Prompt();
                l1.Responses();
                l1.EndMessage();
            }
            else if (_selection == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        } while (_selection != "4");
    }
}