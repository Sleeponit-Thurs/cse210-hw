using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        while (true){
        Console.WriteLine("Welcome to the Mindfulness program. Please select an activity ");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Time spent in each activity reports");
        string choiceGrab = Console.ReadLine();
            //Checks for valid input
        if ((float.TryParse(choiceGrab, out float number)) && (number == 1 || number == 2 || number == 3 || number == 4))
            {
                choice = int.Parse(choiceGrab);
                break;
            }
        else
            {
               Console.WriteLine("Invalid input. Please chose an option on the menu.");
            }
        }

        if (choice == 1){
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.RunBreathingActivity();
            breathingActivity.Goodbye();
        }
        
        else if (choice == 2){
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.RunReflectionActivity();
            reflectionActivity.Goodbye();
        }
        else if (choice == 3){
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.RunListingActivity();
            listingActivity.Goodbye();
        }
        else if (choice == 4){
            Console.WriteLine("Which activity do you want to see your time spent in?");
            int choice2;
            while (true)   
            {
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            string choiceGrab = Console.ReadLine();
                //Checks for valid input
            if ((float.TryParse(choiceGrab, out float number)) && (number == 1 || number == 2 || number == 3 || number == 4))
                {
                    choice2 = int.Parse(choiceGrab);
                    break;
                }
            else
                {
                Console.WriteLine("Invalid input. Please chose an option on the menu.");
                }
            }
            if (choice2 == 1){
                BreathingActivity listingActivity = new BreathingActivity();
                string name = "Breathing Activity";
                Archive archive = new Archive();
                archive.timeSpentReport(name);
                
            }
            
            else if (choice2 == 2){
                ReflectionActivity listingActivity = new ReflectionActivity();
                string name = "Reflection Activity";
                Archive archive = new Archive();
                archive.timeSpentReport(name);
                
            }
            else if (choice2 == 3){
                ListingActivity listingActivity = new ListingActivity();
                string name = "Listing Activity";
                Archive archive = new Archive();
                archive.timeSpentReport(name);
                
            }

        
            }
        
    }
}
