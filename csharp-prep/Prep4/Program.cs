using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float numberAdd = 1;
        Console.WriteLine("Enter a list of numbers. Type zero to stop.");
        while (numberAdd != 0)
        {
            //Accepts input until 0 is given
            Console.Write("Enter a number: ");
            string numberConvert = Console.ReadLine();
            numberAdd = float.Parse(numberConvert);
            if (numberAdd != 0)
            {
                numbers.Add(numberAdd);
            }
            
        }
        float sum = numbers.Sum();
        float average = sum / numbers.Count;
        float largestNumber = numbers.Max();
        float smallestNumber = numbers.Min();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest number is: {smallestNumber}");
        Console.WriteLine($"Here are the numbers from least to greatest:");
        numbers.Sort();
        foreach (float number in numbers)
        {
            Console.WriteLine(number);
        }
        

    }
}