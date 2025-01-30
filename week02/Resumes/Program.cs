using System;

class Program
{
    static void Main(string[] args)
    {
        JobR job1 = new JobR();
        job1._jobTitle = "Regional Webmaster";
        job1._company = "Diveco, S.A";
        job1._startYear = 2014;
        job1._endYear = 2025;

        JobR job2 = new JobR();
        job2._jobTitle = "Webmaster";
        job2._company = "Tag Airlines";
        job2._startYear = 2013;
        job2._endYear = 2012;

        JobR job3 = new JobR();
        job3._jobTitle = "Multimedia Coordinator";
        job3._company = "Daho Wells";
        job3._startYear = 2010;
        job3._endYear = 2013;

        JobR job4 = new JobR();
        job4._jobTitle = "2D Animator";
        job4._company = "Light World Productions";
        job4._startYear = 2008;
        job4._endYear = 2009;

        Resume ResumeR = new Resume();
        ResumeR._nameR = "Aldo Mancilla";

        ResumeR._jobs.Add(job1);
        ResumeR._jobs.Add(job2);
        ResumeR._jobs.Add(job3);
        ResumeR._jobs.Add(job4);

        ResumeR.Display();
    }
}