public class Entry
{
/// <summary>
/// This provides the basic structure of an entry.
/// </summary>
    private string _date;
    private string _prompt;
    private string _entry;
    private List<string> _prompts = new List<string> 
        { "What was the most impactful thing that happened to you today?",
        "If you could improve on thing about yourself... What would it be? (Be kind).",
        "How did you see the hand of God in your life today?",
        "How did you bless someone else today?",
        "What action meant the most to you today?"};


    public void CreateEntry()
    {
        ///grab relevant values
        DateTime time = DateTime.Now;
        _date = time.ToShortDateString();
        Random random = new();
        int promptChoice = random.Next(0,5);
        _prompt = _prompts[promptChoice];
        ///display for user
        Console.WriteLine(_date);
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
        
        List<string> completeEntry = new List<string>{_date,_prompt,_entry};

        ///now saving happens
        Console.WriteLine("What would you like to name the file?");
        string filename = Console.ReadLine();
        JournalManager manager = new();
        manager.SaveJournal(completeEntry,filename);

    }
}
