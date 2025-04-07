using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment = new MathAssignment("Samuel Bennett", "Multiplication", "7.3", "8-19");
        string homeworkList = mathAssignment.GetHomeworkList();
        string summary2 = mathAssignment.GetSummary();
        Console.WriteLine(summary2);
        Console.WriteLine(homeworkList);

        WritingAssignment writingAssignment = new WritingAssignment("Samuel Bennett", "Multiplication", "The Causes of World War II by Mary Waters");
        string title = writingAssignment.GetWritingInformation();
        string summary3 = writingAssignment.GetSummary();
        Console.WriteLine(summary3);
        Console.WriteLine(title);

    }
}