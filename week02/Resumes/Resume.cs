using System;

public class Resume
{
    public string _nameR;

    public List<JobR> _jobs = new List<JobR>();

    public void Display()
    {
        Console.WriteLine($"Name: {_nameR}");
        Console.WriteLine("Jobs:");

        foreach (JobR job in _jobs)
        {
            job.Display();
        }
    }
}