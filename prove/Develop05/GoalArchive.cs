class GoalArchive
{
    /// This class will read and write the goals to a text file that can be read from and written to.
    private List<Goal> goals = new List<Goal>();
    public void WriteNewGoals()
    {
        foreach (Goal goal in goals)
        {
            using (StreamWriter writer = new StreamWriter($"GoalArchive.txt", true))
                writer.WriteLine(goal.ToString());
        }
    }
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void ReadGoals()
    {
        Console.WriteLine("Press enter to continue ");
        string[] lines = File.ReadAllLines("GoalArchive.txt");
        
            foreach (string line in lines)
            {
                if (line != "")
                {
                string[] goal = line.Split(',');
                Console.WriteLine($"Goal: {goal[0]}, Points: {goal[1]}, Completions remaining: {goal[2]}");
                Console.ReadLine();
                }
            }
    }

    public int CompleteGoal() //in txt file 0 index is name 1 index is points and 2 number of completions left and 3 is bonus boints for finishing a checklist goal
    {
        List<string[]> goals = new List<string[]>();
        Console.WriteLine("Press enter to continue ");
        string[] lines = File.ReadAllLines("GoalArchive.txt");
            foreach (string line in lines)
            {
                
                string[] values = line.Split(',');
                string[] goal = new string[4];
                goal[0] = values[0];
                goal[1] = values[1];
                goal[2] = values[2];
                goal[3] = values[3];
                goals.Add(goal);              
            }
        if (goals.Count == 0)
        {
            return 0;
        }
        Console.WriteLine("Which goal would you like to finish?");
        Console.WriteLine("Enter 2 to go forward. 1 to go back in the list. Type 3 on a goal you want to complete. Press 4 to cancel");
        int index = 0;
        while (true)
        {
            bool startOfList = false;
            bool endOfList = false;
            Console.WriteLine($"Goal: {goals[index][0]}, Points: {goals[index][1]} Completions remaining: {goals[index][2]}");
            string response = Console.ReadLine();
            if (response == "2")
            {
                try
                {
                    string test = goals[index+1][0];
                }
                catch
                {
                    Console.WriteLine("This is the end of the list");
                    Console.WriteLine();
                    endOfList = true;
                    continue;
                }
                if (endOfList == false) 
                {
                    index += 1;
                }
            }
            if (response == "1")
            {
                try
                {
                    string test = goals[index-1][0];
                }
                catch
                {
                    Console.WriteLine("This is the start of the list");
                    Console.WriteLine();
                    startOfList = true;
                    continue;
                }
                if (startOfList == false) 
                {
                    index -= 1;
                }
            }
            if (response == "3")
            {
                int remainingChecks = int.Parse(goals[index][2]);
                remainingChecks -= 1;

                  if (remainingChecks == 0)
                  {
                    List<string> goalComplete = new List<string>(lines);
                    goalComplete.RemoveAt(index);
                    File.WriteAllLines("GoalArchive.txt", goalComplete);
                    if (int.Parse(goals[index][3]) != 0)
                    {  
                        Console.WriteLine($"Great work on the checklist goal! You got {goals[index][3]} bonus points!");
                        Thread.Sleep(3000);
                        Console.Clear();
                    
                    }
                    return int.Parse(goals[index][1]+int.Parse(goals[index][3]));
                  }
                  else
                  {
                    goals[index][2] = remainingChecks.ToString();
                    List<string> goalComplete = new List<string>(lines);
                    goalComplete[index] = goals[index][0] + "," + goals[index][1] + "," + goals[index][2]+ "," + goals[index][3];
                    File.WriteAllLines("GoalArchive.txt", goalComplete);
                    Console.Clear();
                    return int.Parse(goals[index][1]);
                    
                  }
                  
            }
            if (response == "4")
            {   
                return 0;
            }
            Console.Clear();
        }

    }

}