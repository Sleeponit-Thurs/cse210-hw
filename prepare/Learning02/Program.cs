using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2021";

        Job job2 = new Job();
        job2._jobTitle = "McDonald's Fry Cook";
        job2._company = "McDonalds";
        job2._startYear = "2022";
        job2._endYear = "Current";

        Resume resume = new Resume();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._name = "Quandale Dingle";

        resume.Display();
    }
}