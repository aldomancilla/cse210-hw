using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("1 Nephi", 19, 23), 
                "And I did read many things unto them which were written in the books of Moses; but that I might more fully persuade them to believe in the Lord their Redeemer I did read unto them that which was written by the prophet Isaiah; for I did liken all scriptures unto us, that it might be for our profit and learning."),
            new Scripture(new Reference("1 Nephi", 3, 7), 
                "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Scripture(new Reference("Mosiah", 2, 17), 
                "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.")
        };

        Random random = new Random();
        int index = random.Next(scriptures.Count);
        Scripture scripture = scriptures[index];

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more random words, or type 'quit' to exit.");

            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            if (input == "")
            {
                int remainingWords = scripture.GetRemainingWordsCount();

                if (remainingWords <= 0)
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine("No more words to hide. You have successfully memorized the scripture!");
                    break;
                }

                int wordsToHide = Math.Min(3, remainingWords);

                scripture.HideRandomWords(wordsToHide);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Finished, Bye Bye!");
    }
}
