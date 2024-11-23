using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWord()
    {
        Random rand = new Random();
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();  
        if (visibleWords.Any())
        {
            var randomWord = visibleWords[rand.Next(visibleWords.Count)];
            randomWord.Hide();
        }
    }

    public string GetDisplayText()
    {
        return string.Join(" ", Words.Select(w => w.GetDisplayText())) + " - " + Reference.GetReferenceText();  
    }

    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);  
    }
}
