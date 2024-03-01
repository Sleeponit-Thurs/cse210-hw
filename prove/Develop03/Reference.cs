public class Reference
{
    private List<List<string>> _versesLibrary = new List<List<string>>()
    {
        new List<string>{"1_Corinthians-10:13 There hath no temptation taken you but such as is common to man but God is faithful who will not suffer you to be tempted above that ye are able but will with the temptation also make a way to escape that ye may be able to bear it"},
        new List<string>{"Joshua-1:9 Have not I commanded thee? Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest"},
        new List<string>{"Mosiah-26:30 Yea and as often as my people repent will I forgive them their trespasses against me."},
        new List<string>{"Mosiah-4:9 Believe in God believe that he is and that he created all things both in heaven and in earth believe that he has all wisdom and all power both in heaven and in earth believe that man doth not comprehend all the things which the Lord can comprehend."},
        new List<string>{"Matthew-16:24 Then said Jesus unto his disciples If any man will come after me let him deny himself and take up his cross and follow me"},
    };
    private List<Word> _formattedVerse = new List<Word>();
    

    public List<Word> GetVerse()
    {   
        Console.WriteLine("Please select a scripture ");
        Console.WriteLine("1: 1_Corinthians-10:13");
        Console.WriteLine("2: Joshua-1:9");
        Console.WriteLine("3: Mosiah-26:30");
        Console.WriteLine("4: Mosiah-4:9");
        Console.WriteLine("5: Matthew-16:24");

        string response = Console.ReadLine();
           while (response != "1" && response != "2" && response != "3" && response != "4" && response != "5")
            {
                Console.WriteLine("Please select a valid option ");
                response = Console.ReadLine();
            }
            int choice = int.Parse(response);
            //Break Verse into individual words
            string[] _selectedVerse = _versesLibrary[choice-1][0].Split(" ");
            
            foreach (string word in _selectedVerse) //loop for each word in verse
            {
                //initiate instance of Word class 
                Word actualWord = new Word();
                actualWord.AssignWord(word);//assigns the word string to the instance of the Word calss
                _formattedVerse.Add(actualWord);//adds to list called _formattedVerse
            }
        return _formattedVerse;
    }
    public void PlayScriptureGame()
    {
        List<int> hiddenWords = new List<int>();
        Random randomWord = new Random();
        int hideWordChoice;

        while (hiddenWords.Count() != _formattedVerse.Count())
        {
            Console.Clear();
            foreach (Word word in _formattedVerse)
            {
                Console.Write(word.FetchWord());

            }
            Console.WriteLine();
            Console.WriteLine("Hit enter to Continue or type Quit to Quit.");
            string response =  Console.ReadLine().ToLower();
            if (response == "quit")
            {
                Environment.Exit(0);
            }
            do{hideWordChoice = randomWord.Next(0,_formattedVerse.Count());}
            while(hiddenWords.Contains(hideWordChoice));
            _formattedVerse[hideWordChoice].HideWord();
            hiddenWords.Add(hideWordChoice);
        };
        if (hiddenWords.Count() == _formattedVerse.Count())
        {
            Console.Clear();
            foreach (Word word in _formattedVerse)
            {
                Console.Write(word.FetchWord());

            }
            Console.WriteLine();
            Console.WriteLine("Hit enter to Continue or type Quit to Quit.");
            string response =  Console.ReadLine().ToLower();
            if (response == "quit")
            {
                Environment.Exit(0);
            }
        }


    }
    

}