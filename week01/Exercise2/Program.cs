using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string gradepercentage = Console.ReadLine();
        int percentage = int.Parse(gradepercentage);

        string grade = "";

        if (percentage >= 90)
        {
            grade = "A";
        } 
        else if (percentage >= 80)
        {
            grade = "B";
        } 
        else if (percentage >= 70)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is: {grade}");

        if (percentage >= 70)
        {
            Console.WriteLine("You Pased!");
        }
        else
        {
            Console.WriteLine("Better Luck Next Time!");
        }

    }
}