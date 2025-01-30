using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Journal Project.");

        public class Person
        {
            public string _givenName = "";
            public string _familyName = "";

            public Person()
            {
            }

            public void ShowEasterName()
            {
                Console.WriteLine($"{_familyName}, {_givenName}");
            }

            public void ShowWesternName()
            {
                Console.WriteLine($"{_givenName}, {_familyName}");
            }

            
        }
    }
}