using System;

namespace AllAsignment
{
    public class MathAsignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAsignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Section {_textbookSection} problems_{_problems}";
        }
    }
}