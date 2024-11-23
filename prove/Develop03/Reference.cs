using System;

public class Reference
{
    private string Book { get; set; }
    private int Chapter { get; set; }
    private string Verse { get; set; }

    
    public Reference(string book, int chapter, string verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
    }

    
    public Reference(string book, int chapter, string verseStart, string verseEnd)
    {
        Book = book;
        Chapter = chapter;
        Verse = $"{verseStart}-{verseEnd}";
    }

    public string GetReferenceText()
    {
        return $"{Book} {Chapter}:{Verse}";
    }
}
