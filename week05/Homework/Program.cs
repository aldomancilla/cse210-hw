using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Smith", "Divitions");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Chalie Brown", "Fractions", "5.1", "6-12");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Ricardo Fayet", "Marketing", "How to Market a Book");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}