using System;

class Program
{
    static void Main(string[] args)
    {
        //Create 2 Job object: job1 and job2
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Create Resume object resume1
        Resume resume1 = new Resume();
        resume1._name = "Allison Rose";

        //Add job to Allison's resume
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();
    }
}