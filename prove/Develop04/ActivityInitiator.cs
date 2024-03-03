public class ActivityInitiator
/// This will be the operator for the activities, it will get a time from the user, determine the activity type,
/// and pull proper quotes and prompts to dislpay from the respective classes.
/// it will then pass the data retrieved to be archived in the archive class
{
    private List<string> _readyAnimation = new List<string>{
        "Ready? 3...",
        "Ready? 2..",
        "Ready? 1.",
        "Ready? 0"
    };
    private List<string> _spinnerAnimation = new List<string>{
        "|",
        "/",
        "-",
        "\\",
        "|",
    };
  
    
    public int RunActivity(string activityName, string ActivityDescription)
    {
        Console.WriteLine($"Welcome to the {activityName}!");
        Console.WriteLine($"This program will help you {ActivityDescription}");
        Console.WriteLine("How long woud you like your session in seconds? ");
        string choiceGrab;
        choiceGrab = Console.ReadLine();
        while (true)
        {
            //Checks for valid input
            
            if ((float.TryParse(choiceGrab, out float number)))
            {
                int sessionTime = int.Parse(choiceGrab);
                return sessionTime;
            }
         else
            {
               Console.WriteLine("Invalid input. Please enter your time in seconds.");
            }
        }
    }
    public void RunReadyCountdown()
    {
        int waitTimeInSeconds = 4;
        while (waitTimeInSeconds != 0)
        {
            foreach (string item in _readyAnimation)
            {
            Console.WriteLine(item);
            Thread.Sleep(1000);
            waitTimeInSeconds -= 1;
            Console.Clear();
            }
        }

    }
    public void RunSpinnerAnimation()
{
    foreach (string item in _spinnerAnimation)
    {
        Console.Write(item);
        Thread.Sleep(750);
        Console.Write("\b \b");
    }
}
public void Goodbye()
{
    Console.WriteLine($"Goodbye! Good job today!");
}

   
}