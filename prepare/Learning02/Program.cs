using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._Company = "Microsoft";
        job1._startYear= 2019;
        job1._endYear=2022;
        // Console.WriteLine(job1._Company);
        // Console.WriteLine(job1._jobTitle);
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle="Project manager";
        job2._Company="Apple";
        job2._startYear=2022;
        job2._endYear = 2023;
        job2.Display();

        Resume resume1 = new Resume();
        resume1._jobs=new List<Job>();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Allison Rose";
        resume1.Display();

    }
}