using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Jase Erickson", "Mathematics");
        assignment1.GetSummary();

        MathAssignment assignment2 = new MathAssignment("Quandale Dingle", "Pizza", "9.2", "14-78");
        assignment2.GetSummary();
        assignment2.GetHomeworkList();

        WritingAssignment assignment3 = new WritingAssignment("Joe Mama", "Video Games", "Kirby's Fantastic Adventure");
        assignment3.GetSummary();
        assignment3.GetWritingInformation();

    }
}