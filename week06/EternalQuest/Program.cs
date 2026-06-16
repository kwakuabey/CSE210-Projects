using System;

/*
EXCEEDING REQUIREMENTS:
I added a Level System to increase the gamification aspect of the program.
The user advances one level for every 1000 points earned.
The current level is displayed whenever the score is shown.
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        int choice = 0;

        while (choice != 6)
        {
            manager.DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("\nGoal Types:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");

                    int type = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Description: ");
                    string description = Console.ReadLine();

                    Console.Write("Points: ");
                    int points = int.Parse(Console.ReadLine());

                    if (type == 1)
                    {
                        manager.AddGoal(
                            new SimpleGoal(name, description, points));
                    }
                    else if (type == 2)
                    {
                        manager.AddGoal(
                            new EternalGoal(name, description, points));
                    }
                    else if (type == 3)
                    {
                        Console.Write("Target count: ");
                        int target = int.Parse(Console.ReadLine());

                        Console.Write("Bonus: ");
                        int bonus = int.Parse(Console.ReadLine());

                        manager.AddGoal(
                            new ChecklistGoal(
                                name,
                                description,
                                points,
                                target,
                                bonus));
                    }

                    break;

                case 2:
                    manager.ListGoals();
                    break;

                case 3:
                    Console.Write("Filename: ");
                    manager.Save(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Filename: ");
                    manager.Load(Console.ReadLine());
                    break;

                case 5:
                    manager.ListGoals();

                    Console.Write("Which goal did you accomplish? ");
                    int index = int.Parse(Console.ReadLine()) - 1;

                    manager.RecordGoal(index);
                    break;
            }
        }
    }
}