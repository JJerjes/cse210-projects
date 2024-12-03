using System;
using System.Collections.Generic;

namespace VideoManagement
{
    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int DurationSeconds { get; set; }
        public List<Comment> Comments { get; set; }
        public Video (string title, string author, int duration)
        {
            Title = title;
            Author = author;
            DurationSeconds = duration;
            Comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return Comments.Count;
        }

        public void ShowComments()
        {
            foreach (var comment in Comments)
            {
                Console.WriteLine($"- {comment.Author}: {comment.Text}");
            }
        }
    }
}
