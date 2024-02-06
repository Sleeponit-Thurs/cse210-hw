public class JournalManager
{
    /// This class provides Writing and reading capabilities for the program
    
    public void SaveJournal(List<string> completeEntry, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename + ".txt"))
        {
            foreach (string item in completeEntry)
            {
                outputFile.WriteLine(item);
            }
        }
    }

    public void ReadJournal()
    {
        Console.WriteLine("What is the name of the file you want to read? (Do not include the .txt extension)");
        string filename = Console.ReadLine();
        string[] entry = System.IO.File.ReadAllLines(filename + ".txt");
        Console.Clear();
        foreach (string line in entry)
        {
            Console.WriteLine(line);
        }

    }

    
}