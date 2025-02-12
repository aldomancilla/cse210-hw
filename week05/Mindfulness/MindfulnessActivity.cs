using System;
using System.Threading;

abstract class MindfulnessActivity
{
    private int _duration;
    protected int Duration => _duration; 

    public void Start()
    {
        Console.Clear();
        DisplayStartingMessage();
        RunActivity();
        DisplayEndingMessage();
    }

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {GetType().Name.Replace("Activity", "")} Activity.\n");
        Console.WriteLine(GetDescription());
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"\nYou completed the {GetType().Name.Replace("Activity", "")} for {Duration} seconds.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write($"\r{spinner[i % 4]} ");
            Thread.Sleep(250);
        }
        Console.Write("\r \r");
    }

    protected abstract string GetDescription();
    protected abstract void RunActivity();
}
