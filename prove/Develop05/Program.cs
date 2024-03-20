using System;

class Program
{
    static void Main(string[] args)
    {
        
        while (true)
        {
            Profile profile = new Profile();
            GoalArchive archive =  new GoalArchive();
            Console.WriteLine($"Welcome to your Eternal Quest {profile.GetUsername()}! {profile.GetLevelTitle()}");
            Console.WriteLine("Choose an option below. (Goals created this session are saved when you quit)");
            Console.WriteLine("");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. Display your Goals");
            Console.WriteLine("3. Pass off a goal");
            Console.WriteLine("4. Quit");
            string choice = "null";
            Console.WriteLine("");
            choice = Console.ReadLine();
            while (true)///checks if input is 1 2 or 3
                if (choice !="1" && choice !="2" && choice !="3" && choice !="4")
                {
                    Console.WriteLine("Please choose a valid option.");
                    choice = Console.ReadLine();
                }
                else
                {
                    break;
                }
            if (choice == "1")
            {
                Console.WriteLine("What kind of goal would you like to create?");
                Console.WriteLine();
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                choice = Console.ReadLine();
                while (true)///checks if input is 1 or 2
                    if (choice !="1" && choice !="2")
                    {
                        Console.WriteLine("Please choose a valid option.");
                        choice = Console.ReadLine();
                        
                    }
                    else
                    {
                        break;
                    }
                if (choice == "1")
                {
                    Console.WriteLine("Pick a premade goal or make your own!");
                    Console.WriteLine("1. Go on a 30 min walk.");
                    Console.WriteLine("2. Do your homework");
                    Console.WriteLine("3. Go to bed at a reasonable hour");
                    Console.WriteLine("4. Custom Goal ");
                    choice = Console.ReadLine();
                    while (true)///checks if input is 1 2 or 3
                        if (choice !="1" && choice !="2" && choice !="3" & choice !="4")
                        {
                        Console.WriteLine("Please choose a valid option.");
                        choice = Console.ReadLine();
                        }
                        else
                        {
                        break;
                        }
                    if (choice == "1")
                        {
                            SimpleGoal goal = new SimpleGoal("Go on a 30 min walk");
                            archive.AddGoal(goal);
                            choice = "null";
                            
                        }
                    if (choice == "2")
                        {
                            SimpleGoal goal = new SimpleGoal("Do your homework");
                            archive.AddGoal(goal);
                            choice = "null";
                            
                        }
                    if (choice == "3")
                        {
                            SimpleGoal goal = new SimpleGoal("Go to bed at a reasonable hour");
                            archive.AddGoal(goal);
                            choice = "null";
                            
                        }
                    if (choice == "4")
                        {
                            Console.WriteLine("What will you call this goal? ");
                            string name = Console.ReadLine();
                            Console.WriteLine("How many points should this goal be worth? ");
                            string points = Console.ReadLine();
                            Console.WriteLine("Is this a checklist goal? yes/no");
                            string reply = Console.ReadLine();
                            if (reply == "no")
                            {
                                SimpleGoal goal = new SimpleGoal(name, int.Parse(points));
                                archive.AddGoal(goal);
                                choice = "null";
                            }
                            if (reply == "yes")
                            {
                                Console.WriteLine("How many days are required to complete the goal? ");
                                string days = Console.ReadLine();
                                int bonus = int.Parse(days) * 7;
                                SimpleGoal goal = new SimpleGoal(name, int.Parse(points), int.Parse(days), bonus);
                                archive.AddGoal(goal);
                                choice = "null";
                            }
                            
                        }
                }
                if (choice == "2")
                {
                    Console.WriteLine("Pick a premade goal or make your own!");
                    Console.WriteLine("1. Go to the temple this week");
                    Console.WriteLine("2. Do a 30 min scripture study");
                    Console.WriteLine("3. Go serve someone in need");
                    Console.WriteLine("4. Custom Goal");
                    choice = Console.ReadLine();
                    while (true)///checks if input is 1 2 or 3
                        if (choice !="1" && choice !="2" && choice !="3" & choice !="4")
                        {
                            Console.WriteLine("Please choose a valid option.");
                            choice = Console.ReadLine();
                        }
                        else
                        {
                            break;
                        }
                    if (choice == "1")
                        {
                            EternalGoal goal = new EternalGoal("Go to the temple this week");
                            archive.AddGoal(goal);
                            choice = "null";
                            
                        }
                    if (choice == "2")
                        {
                            EternalGoal goal = new EternalGoal("Do a 30 min scripture study");
                            archive.AddGoal(goal);
                            choice = "null";
                            
                        }
                    if (choice == "3")
                        {
                            EternalGoal goal = new EternalGoal("Go serve someone in need");
                            archive.AddGoal(goal);
                            choice = "null";
                            
                        }
                    if (choice == "4")
                        {
                            Console.WriteLine("What will you call this goal? ");
                            string name = Console.ReadLine();
                            Console.WriteLine("How many points should this goal be worth? ");
                            string points = Console.ReadLine();
                            Console.WriteLine("Is this a checklist goal? yes/no");
                            string reply = Console.ReadLine();
                            if (reply == "no")
                            {
                                SimpleGoal goal = new SimpleGoal(name, int.Parse(points));
                                archive.AddGoal(goal);
                                choice = "null";
                            }
                            if (reply == "yes")
                            {
                                Console.WriteLine("How many days are required to complete the goal? ");
                                string days = Console.ReadLine();
                                int bonus = int.Parse(days) * 7;
                                EternalGoal goal = new EternalGoal(name, int.Parse(points), int.Parse(days), bonus);
                                archive.AddGoal(goal);
                                choice = "null";
                            }
                            
                        }

                }
                
                
            }
            if (choice == "2")
            {
                archive.ReadGoals();

            }
            if (choice == "3")
            {
                profile.AddExp(archive.CompleteGoal());
            }
            if (choice == "4")
            {
                Environment.Exit(1);
            }
            archive.WriteNewGoals();
            profile.SaveProgress();
        }
    }
}