using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (var word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        int remainingWords = GetRemainingWordsCount();

        if (remainingWords == 0)
            return;

        numberToHide = Math.Min(numberToHide, remainingWords);

        while (wordsHidden < numberToHide)
        {
            int index = random.Next(_words.Count);
            Word word = _words[index];

            if (!word.IsHidden())
            {
                word.Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";

        foreach (var word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public int GetRemainingWordsCount()
    {
        int count = 0;
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }
}
