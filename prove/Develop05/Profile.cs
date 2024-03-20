class Profile
{
    ///This will read and write to a text file concerning the user's name and Level
    private string _userName;
    private int _totalExperiencePoints;
    private int _gainedExperiencePoints;
    private List<string> _titleList = new List<string>() {"Level 1: Novice",
"Level 2: Apprentice",
"Level 3: Journeyman",
"Level 4: Adept",
"Level 5: Champion",
"Level 6: Hero",
"Level 7: Legend",
"Level 8: Master",
"Level 9: Grandmaster",
"Level 10: Ascendant"};
private string _title;

public string GetLevelTitle()
{
    ///read file and get exp
    string[] arrLine = File.ReadAllLines("profile.txt");
    int exp = int.Parse(arrLine[2]);
    int expChecker = 1000;
    int title = 0;
    while(expChecker < exp)
    {
        expChecker += 1000;
        title += 1;
    }
    _title = _titleList[title];
    return _title;
}
public string GetUsername()
{
    string[] arrLine = File.ReadAllLines("profile.txt");
    _userName = arrLine[0];
    if (_userName == "VOID")
    {
        Console.WriteLine("Looks like This is our first time setup! What is your name?" );
        _userName = Console.ReadLine();
        string response;
            do 
            {
                Console.WriteLine($"Your name is {_userName}? yes/no");
                response = Console.ReadLine();
            }
            while (response != "yes");
    }
    return _userName;
    
}
public void AddExp(int expGained)
{
    _gainedExperiencePoints += expGained;
}
public void SaveProgress()
{
    Console.WriteLine($"You gained {_gainedExperiencePoints} experience points this session.");
    string nameBeforeEXP = GetLevelTitle();///This checks the title before the exp is gained
    
    string[] arrLine = File.ReadAllLines("profile.txt");
    arrLine[0] = _userName;
    arrLine[1] = _title;
    _totalExperiencePoints = int.Parse(arrLine[2]);
    _totalExperiencePoints += _gainedExperiencePoints;
    arrLine[2] = _totalExperiencePoints.ToString(); /// updates value of total exp as the GetLevelTitle() calls upon the text file itself
    /// Records to profile.txt in the following format
    /// Username, title, total exp
    File.WriteAllLines("profile.txt", arrLine);

    string nameAfterEXP = GetLevelTitle();
    _title = nameAfterEXP;
    if (nameAfterEXP != nameBeforeEXP)
    {
        Console.WriteLine($"You Leveled up! Congrats! you are now a {_title}! Great job!");
    }
}

}