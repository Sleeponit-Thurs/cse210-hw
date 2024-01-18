using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string UserName = Console.ReadLine();
            return UserName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int FavoriteNumber = Console.Read();
            return FavoriteNumber;
        }
        static float SquareNumber(float value)
        {
            float numberSquared = value * value;
            return numberSquared;
        }
        static void displayResult(string name, float number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
        DisplayWelcome();
        string userName = PromptUserName();
        float favNumber = PromptUserNumber();
        float favNumberSquared = SquareNumber(favNumber);
        displayResult(userName, favNumberSquared);


    }
}