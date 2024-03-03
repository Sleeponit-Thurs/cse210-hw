public class Archive : ActivityInitiator
/// This class is the format for the info we want to log about the user and the program usage.
/// It will read and write to a log file and display that info back to the user.
{
    private List<string> _inputs = new List<string>();

    public void CompileActivityAnswers(string input)
    {
        _inputs.Add(input);
    }
    public void RecordActivity(int duration, string activityName)
    {  
        //the followigng records the date, prompt and user answers for the activity
        using (StreamWriter writer = new StreamWriter($"{activityName}.txt", true))
        writer.WriteLine(DateTime.Now.ToString("MM/dd/yyyy"));
        using (StreamWriter writer = new StreamWriter($"{activityName}.txt", true))
        writer.WriteLine($"{activityName}");
        using (StreamWriter writer = new StreamWriter($"{activityName}.txt", true))
        foreach (string item in _inputs)
        {
            writer.WriteLine(item);
        }
        using (StreamWriter writer = new StreamWriter($"{activityName}.txt", true))
        writer.WriteLine("************************************************");
        //The following reads the top line of the file and returns the number of seconds passed,
        //it then adds the current amount of time spent to the total
        string firstFileLine = File.ReadLines($"{activityName}.txt").Skip(1).Take(1).First();
        string timeInSecondsString = String.Join("", firstFileLine.Where(char.IsDigit));
        int timeInSeconds = int.Parse(timeInSecondsString);
        int newTime = timeInSeconds + duration;
        timeSpentChanger(newTime.ToString(), $"{activityName}.txt");

    }
    public void timeSpentChanger(string newTimeinSeconds, string fileName)
{
     string[] arrLine = File.ReadAllLines(fileName);
     arrLine[1] = newTimeinSeconds;
     File.WriteAllLines(fileName, arrLine);
}
    public void timeSpentReport(string name)
    {
        string[] arrLine = File.ReadAllLines($"{name}.txt");
        string time = arrLine[1];
        Console.WriteLine($"You have spent {time} seconds in the {name}! Good Job!");


    }
}