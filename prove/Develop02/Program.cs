using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        int userChoice;
        while (true)
        {
            userChoice = menu.DisplayMenu();
            if (userChoice == 1)
            {
                Entry entry = new();
                entry.CreateEntry();
            }
            if (userChoice == 2)
            {
                JournalManager manager =  new();
                manager.ReadJournal();
            }
            if (userChoice == 4)
            {
                Environment.Exit(0);
            }

        }

    }
}