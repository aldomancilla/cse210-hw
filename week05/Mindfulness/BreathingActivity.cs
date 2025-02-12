using System;

class BreathingActivity : MindfulnessActivity
{
    protected override string GetDescription() => "\nThis activity will help you relax by guiding your breathing. Focus on your breath and relax your mind.";

     protected override void RunActivity()
    {
        int elapsedTime = 0;
        while (elapsedTime < Duration)
        {
            Console.WriteLine("\nBreathe in... ");
            ShowSpinner(8);
            Console.WriteLine("Breathe out... ");
            ShowSpinner(8);
            elapsedTime += 10;
        }
    }
}
