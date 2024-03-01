public class Menu
{
    public string _option1 = "Memorize a scripture";
    public string _option2 = "Quit";
    

    public int DisplayMenu()
    {
        
        string choiceGrab;
        while (true)
        {
            Console.WriteLine($"1: {_option1}");
            Console.WriteLine($"2: {_option2}");
            Console.WriteLine("Welcome to the Scripture Memorization program. Please select an option ");
            choiceGrab = Console.ReadLine();
            //Checks for valid input
            if (float.TryParse(choiceGrab, out float number) && (number == 1 || number == 2))
            {
                if (number == 2)
                {
                    Environment.Exit(0);
                }

                int choice = int.Parse(choiceGrab);
                return choice;
            }
         else
            {
               Console.WriteLine("Invalid input. Please chose an option on the menu.");
            }
        }
    }
    
}