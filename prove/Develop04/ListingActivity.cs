public class ListingActivity : ActivityInitiator
{
     private List<string> _listingactivityquotes = new List<string> {"Who are people that you appreciate?",
"What are personal strengths of yours?",
"Who are people that you have helped this week?",
"When have you felt the Holy Ghost this month?",
"Who are some of your personal heroes?"};

private string _activityname = "Listing Activity";
private string _activityDescription = "recognize the things you are grateful for in your life.";


public void RunListingActivity()
{
     Archive activityArchive = new Archive();
     Random random = new Random();
     int index = random.Next(0, 4);

     int duration = RunActivity(_activityname, _activityDescription);

     RunReadyCountdown();
     Console.WriteLine(_listingactivityquotes[index]);
     activityArchive.CompileActivityAnswers(_listingactivityquotes[index]);
     Console.WriteLine("Press enter after each entry");
     
     
     DateTime startTime = DateTime.Now;
     DateTime endTime = startTime.AddSeconds(duration);  
     
     while (startTime < endTime)
     {
          startTime = DateTime.Now;
          string listedItem = Console.ReadLine();
          activityArchive.CompileActivityAnswers(listedItem);
     }
     activityArchive.RecordActivity(duration, _activityname);

}
}

