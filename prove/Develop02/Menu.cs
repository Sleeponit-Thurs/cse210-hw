public class Menu
{
    public string _option1 = "Create Entry";
    public string _option2 = "Display Entries";

    public string _option3 = "Quit";
    

    public int DisplayMenu()
    {
        
        string choiceGrab;
        while (true)
        {
            Console.WriteLine($"1: {_option1}");
            Console.WriteLine($"2: {_option2}");
            Console.WriteLine($"3: {_option3}");
            Console.WriteLine("Welcome to the Journal program. Please select an option ");
            choiceGrab = Console.ReadLine();
            //Checks for valid input
            if (float.TryParse(choiceGrab, out float number) && (number == 1 || number == 2 || number == 3))
            {
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