using System.IO;

// should i add a way to remove goals??
class Program
{
    static void Main(string[] args)
    {
        int _selection = 0;
        User grunt = new User();
        Console.Clear();
            
        
            while (_selection != 7)
            {
                Console.WriteLine($"You have {grunt.GetPoints()} points.\n");

                Console.Write("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Delete Goal(s)\n  7. Quit\nSelect a choice from the menu: ");
                
                try
                {
                    _selection = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Not a valid input. Please try again.");
                    continue;
                }

                Console.Clear();
                
                switch (_selection)
                {
                    case 1:
                        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal\nWhich type of goal would you like to create? ");
                        int goalType = int.Parse(Console.ReadLine());
                        Console.WriteLine("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.WriteLine("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.WriteLine("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());     

                        switch (goalType)
                        {
                            case 1:
                                SimpleGoal sg = new SimpleGoal(name, description, false, points);
                                grunt.AddGoal(sg);
                                break;
                            case 2:
                                EternalGoal eg = new EternalGoal(name, description, false, points);
                                grunt.AddGoal(eg);
                                break;
                            case 3:
                                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                                int eventsToComplete = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                                int bonus = int.Parse(Console.ReadLine());
                                ChecklistGoal cg = new ChecklistGoal(name, description, false, points, bonus, eventsToComplete);
                                grunt.AddGoal(cg);
                                break;
                        } 
                        break;

                    case 2:
                        grunt.DisplayGoals();
                        break;
                    
                    case 3:
                        grunt.Save();
                        break;
                    
                    case 4:
                        grunt.Load();
                        break;

                    case 5:
                        grunt.AddPoints();
                        break;

                    case 6:
                        grunt.DeleteGoal();
                        break;

                    case 7:
                        break;  

                    case '_':
                        Console.WriteLine("'{_selection}' was not a valid input.");
                        break;              
                }
            }
        //     {

        //     }
        //     else if (_selection == "3")
        //     {

        //     }
        //     else if (_selection == "4")
        //     {

        //     }
        //     else if (_selection == "5")
        //     {

        //     }           
        //     else if (_selection == "6")
        //     {
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid option. Please try again.");
        //         Thread.Sleep(1000);
        //     }
        // } while (_selection != "6");
    }
}
