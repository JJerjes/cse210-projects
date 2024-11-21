using System;
public class Entry
{
    public string Ask { get; set; }
    public string Answer { get; set; }
    public DateTime Date { get; set; }

    public Entry(string ask, string answer)
    {
        Ask = ask;
        Answer = answer;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nAsk: {Ask}\nAnswer: {Answer}\n";
    }
}