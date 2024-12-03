using System;
using System.Collections.Generic;

namespace VideoManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("Soccer shoes for gras sintetico", "Miguel Cartolin", 3600);
            Video video2 = new Video("Women's running show", "Malu Tapasco", 2400);
            Video video3 = new Video("Chimpunes for natural gras", "Christian Aquice", 4200);

            video1.AddComment(new Comment("Jose", "Incredible Models!!"));
            video1.AddComment(new Comment("Tomas", "Is there in purple?"));
            video1.AddComment(new Comment("Pedro", "Are those from 2024?"));
            video2.AddComment(new Comment("Maria", "Do you do delivery service?"));
            video2.AddComment(new Comment("Sofia", "Do you have large sizes?"));
            video2.AddComment(new Comment("Andrea", "I really liked the models."));
            video3.AddComment(new Comment("Roberto", "Do you have the latest Messi models?"));
            video3.AddComment(new Comment("Joshua", "Yes or if I want in red."));
            video3.AddComment(new Comment("Ronaldo", "Thanks for showming the new models."));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (var video in videos) 
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Duration: {video.DurationSeconds} s");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
                Console.WriteLine($"Comments:");
                video.ShowComments();
                Console.WriteLine();
            }
        }
    }
}