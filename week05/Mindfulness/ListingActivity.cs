using System;
using System.Collections.Generic;

class ListingActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "\nWho are people that you appreciate?",
        "\nWhat are personal strengths of yours?",
        "\nWho are people that you have helped this week?",
        "\nWho are some of your personal heroes?",
        "\nWho are some of your personal heroes?"
    };

    protected override string GetDescription() => "\nThis activity encourages you to list as many positive things as you can.";

    protected override void RunActivity()
    {
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        ShowSpinner(3);

        List<string> responses = new List<string>();
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.Write("Enter a response: ");
            responses.Add(Console.ReadLine());
            elapsedTime += 5;
        }
        Console.WriteLine($"You listed {responses.Count} items!");
    }
}
