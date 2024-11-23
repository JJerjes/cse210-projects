using System;

public class Word
{
    private string Text { get; set; }
    public bool IsHidden { get; private set; } 

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public void Hide()
    {
        IsHidden = true;
    }

    public void Reveal()
    {
        IsHidden = false;
    }

    public string GetDisplayText()
    {
        return IsHidden ? new string('_', Text.Length) : Text;
    }
}
