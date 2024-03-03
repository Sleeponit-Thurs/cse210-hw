public class BreathingActivity : ActivityInitiator
{
private string _activityname = "Breathing Activity";
private string _activityDescription = "slow your breathing and calm your mind.";



public void RunBreathingActivity()
{
     Archive activityArchive = new Archive();


     int duration = RunActivity(_activityname, _activityDescription);

     RunReadyCountdown();
     
     
    
     DateTime startTime = DateTime.Now;
     DateTime endTime = startTime.AddSeconds(duration);  
     
     while (startTime < endTime)
     {

        Console.Write("Breathe in...");
        RunSpinnerAnimation();
        Console.WriteLine();
        Console.WriteLine("Breath out...");
        RunSpinnerAnimation();
        Console.WriteLine();
        startTime = DateTime.Now;
     }
     activityArchive.RecordActivity(duration, _activityname);
}

}