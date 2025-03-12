using System;

class Program
{
    static void Main(string[] args)
    {
        //jobs list
        Job job2 = new Job();
        job2._jobTitle = "Web Developer";
        job2._company = "Coalition Technologies";
        job2._startYear = 2025;
        job2._endYear = 2030;

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Kolarel SA";
        job1._startYear = 2021;
        job1._endYear = 2025;

        Resume resume = new Resume();
        resume._name = "Kouame Alexandre Paul";

        resume._jobs.Add(job2);
        resume._jobs.Add(job1);

        resume.Display();
    }
}