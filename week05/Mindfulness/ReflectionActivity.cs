using System;
using System.Collections.Generic;

class ReflectionActivity : MindfulnessActivity
{
    private List<string> _prompts = new List<string>
    {
        "\nThink of a time when you stood up for someone else.",
        "\nThink of a time when you did something really difficult.",
        "\nThink of a time when you helped someone in need.",
        "\nThink of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "\nWhy was this experience meaningful to you?",
        "\nHave you ever done anything like this before?",
        "\nHow did you get started?",
        "\nHow did you feel when it was complete?",
        "\nWhat did you learn from this experience?",
        "\nWhat could you learn from this experience that applies to other situations?",
        "\nWhat did you learn about yourself through this experience?",
        "\nHow can you keep this experience in mind in the future?"
    };

    protected override string GetDescription() => "\nThis activity helps you reflect on times when you've shown strength and resilience.";

    protected override void RunActivity()
    {
        Random rand = new Random();
        HashSet<string> usedQuestions = new HashSet<string>();

        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
        ShowSpinner(7);

        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            if (usedQuestions.Count == _questions.Count)
                usedQuestions.Clear();

            string question;
            do { question = _questions[rand.Next(_questions.Count)]; } 
            while (usedQuestions.Contains(question));
            
            usedQuestions.Add(question);
            Console.WriteLine(question);
            ShowSpinner(7);
            elapsedTime += 7;
        }
    }
}
