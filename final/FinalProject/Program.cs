// Things left to code: file saving and loading.

using System;

class Program
{
    static void Main(string[] args)
    {
        int selector = 0;
        Menu m1 = new Menu();
        m1.DisplayWelcome();

        while (selector != 4)
        {
            selector = m1.DisplayStartMenu();


            switch (selector)
                {
                    case 1:
                        m1.DisplayWorkoutMenu();
                        break;
                    case 2:
                        m1.DisplayRoutineMenu();
                        break;
                    case 3: 
                        m1.DisplayExerciseMenu();
                        break;
                    case 4:
                        break;
                }
        }
        
    }
}