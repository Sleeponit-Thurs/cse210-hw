using System;

class Program
{
    static void Main(string[] args)
    {
        ///This Program will take a grade input in a value from 0-100 and output a letter grade A-F
        string GradeInput;
        int GradeNumber;
        string GradeLetter;
        while (true)
        {
            Console.WriteLine("What is your grade from 0-100?");
            GradeInput = Console.ReadLine();
            if (int.TryParse(GradeInput, out GradeNumber) && (GradeNumber > 0) && (GradeNumber < 100))
            {
                break;
            }
            else
            {
                Console.WriteLine("Please give a valid Input");
            }
                
            
        }
        GradeNumber = int.Parse(GradeInput);
        GradeLetter = "A";
        if (GradeNumber < 90)
            GradeLetter = "B";
        if (GradeNumber < 80)
            GradeLetter = "C";
        if (GradeNumber < 70)
            GradeLetter = "D";
        if (GradeNumber < 60)
            GradeLetter = "F";
        
        Console.WriteLine($"{GradeLetter} is your grade.");
            
        
    }
}