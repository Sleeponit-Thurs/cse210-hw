public class ReflectionActivity : ActivityInitiator
{
    private List<string> _reflectionactivityquotes = new List<string> {"Think of a time when you stood up for someone else.",
"Think of a time when you did something really difficult.",
"Think of a time when you helped someone in need.",
"Think of a time when you did something truly selfless."};

private List<string> _reflectionactivityquotes2 = new List<string>{
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?",
};

private string _activityname = "Reflection Activity";
private string _activityDescription = "ponder on your personal strenghts and experiences to remind yourself you matter.";


public void RunReflectionActivity()
{
     Archive activityArchive = new Archive();
     Random random = new Random();
     int index = random.Next(0, 4);

     int duration = RunActivity(_activityname, _activityDescription);

     RunReadyCountdown();
     Console.WriteLine(_reflectionactivityquotes[index]);
     activityArchive.CompileActivityAnswers(_reflectionactivityquotes[index]);
     
     
     
     DateTime startTime = DateTime.Now;
     DateTime endTime = startTime.AddSeconds(duration);  
     
     while (startTime < endTime)
     {
          RunSpinnerAnimation();
          RunSpinnerAnimation();
          Console.WriteLine();
          Random random2 = new Random();
          int index2 = random.Next(0, 4);
          Console.WriteLine(_reflectionactivityquotes2[index2]);
          activityArchive.CompileActivityAnswers(_reflectionactivityquotes2[index2]);
          startTime = DateTime.Now;
          
     }
     activityArchive.RecordActivity(duration, _activityname);

}
}