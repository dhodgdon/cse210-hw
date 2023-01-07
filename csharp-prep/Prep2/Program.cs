using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();
        int gradePercentage = int.Parse(valueFromUser);

        string letter = "";
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (!(gradePercentage >= 97 || gradePercentage < 60))
        {
            if ((gradePercentage % 10) >= 7)
            {
                sign = "+";
            }
            else if ((gradePercentage % 10) < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        
        
        Console.WriteLine($"You got a {letter}{sign}.");


        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("You didn't pass the course, but you are better prepared for when you take it again!");
        }
    }
}