using System;

class Program
{
    static void Main(string[] args)
    {
        string selector = "start";
        bool done;

        Reference r1 = new Reference("John","3","16");
        Reference r2 = new Reference("Proverbs","3","5","6");
        Scripture scripture1 = new Scripture(r2.CompileReference(), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");


        do
        {


            Console.Clear();


            Console.Write(r2.CompileReference() + " ");


            scripture1.DisplayScripture();
            done = scripture1.IsCompletelyHidden();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press 1 to hide words, press 2 to show words, or type 'quit' to finish:");
            selector = Console.ReadLine();
            if (selector == "1")
            {
                scripture1.HideWords();
            }
            else if (selector == "2")
            {
                scripture1.ShowWords();
            }

            // if (done == true)
            // {
            //     break;
            // }
            

        } while (selector != "quit" && done == false || selector == "2");
        



    }
}