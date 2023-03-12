    using System;
    using System.Collections.Generic;
    using System.IO;

    class Program
    {
        static List<Goal> goals = new List<Goal>();

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Goals:");

                for (int i = 0; i < goals.Count; i++)
                {
                    string status = goals[i].Completed ? "[X]" : "[ ]";
                    if (goals[i] is ChecklistGoal)
                    {
                        status += " Completed " + ((ChecklistGoal)goals[i]).Count + "/" + ((ChecklistGoal)goals[i]).Total + " times";
                    }

                    Console.WriteLine(status + " " + goals[i].Name);
                }

                Console.WriteLine("\n1. Create goal");
                Console.WriteLine("2. Save Goals");
                Console.WriteLine("3. Load Goals");
                Console.WriteLine("4. Record event");
                Console.WriteLine("5. Exit");
                Console.Write("\nEnter choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Invalid choice. Enter again: ");
                }

                Console.Clear();

                if (choice == 1)
                {
                    CreateGoal();
                }
                else if (choice == 2)
                {
                    SaveGoals();
                    Environment.Exit(0);
                }
                else if (choice == 3)
                {
                    LoadGoals();
                }
                else if (choice == 4)
                {
                    RecordEvent();
                }
                else if (choice == 5)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void LoadGoals()
        {
            try
            {
                using (StreamReader file = new StreamReader("goals.txt"))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] fields = line.Split(',');
                        string type = fields[0];
                        string name = fields[1];
                        int value = int.Parse(fields[2]);

                        if (type == "SimpleGoal")
                        {
                            goals.Add(new SimpleGoal(name, value));
                        }
                        else if (type == "EternalGoal")
                        {
                            int count = int.Parse(fields[3]);
                            goals.Add(new EternalGoal(name, value) { Count = count });
                        }
                        else if (type == "ChecklistGoal")
                        {
                            int total = int.Parse(fields[3]);
                            int count = int.Parse(fields[4]);
                            goals.Add(new ChecklistGoal(name, value, total) { Count = count });
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                // If the file does not exist, do nothing.
            }
        }
    static void CreateGoal()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter value: ");
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid value. Enter again: ");
        }

        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("\nEnter goal type: ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 3)
        {
            Console.Write("Invalid choice. Enter again: ");
        }

        Goal goal;
        switch (choice)
        {
            case 1:
                goal = new SimpleGoal(name, value);
                break;
            case 2:
                goal = new EternalGoal(name, value);
                break;
            case 3:
                Console.Write("Enter total count: ");
                int total;
                while (!int.TryParse(Console.ReadLine(), out total))
                {
                    Console.Write("Invalid count. Enter again: ");
                }

                goal = new ChecklistGoal(name, value, total);
                break;
            default:
                throw new InvalidOperationException("Invalid choice.");
        }

        goals.Add(goal);
    }

    static void SaveGoals()
    {
        using (StreamWriter file = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal)
                {
                    file.WriteLine("SimpleGoal,{0},{1}", goal.Name, goal.Value);
                }
                else if (goal is EternalGoal)
                {
                    file.WriteLine("EternalGoal,{0},{1},{2}", goal.Name, goal.Value, ((EternalGoal)goal).Count);
                }
                else if (goal is ChecklistGoal)
                {
                    file.WriteLine("ChecklistGoal,{0},{1},{2},{3}", goal.Name, goal.Value, ((ChecklistGoal)goal).Total, ((ChecklistGoal)goal).Count);
                }
            }
        }

        Console.WriteLine("Goals saved.");
    }

    static void RecordEvent()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Goal goal = goals.Find(g => g.Name == name);
        if (goal == null)
        {
            Console.WriteLine("Goal not found.");
            return;
        }

        if (goal is SimpleGoal || goal is EternalGoal)
        {
            goal.Completed = true;
        }
        else if (goal is ChecklistGoal)
        {
            Console.Write("Enter count: ");
            int count;
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.Write("Invalid count. Enter again: ");
            }

            ((ChecklistGoal)goal).Count += count;
        }

        Console.WriteLine("Event recorded.");
    }
    }