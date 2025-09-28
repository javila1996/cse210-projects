using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    public class Comment
    {
        public string CommenterName { get; set; }
        public string Text { get; set; }

        public Comment(string commenterName, string text)
        {
            CommenterName = commenterName;
            Text = text;
        }
    }

    public class Video
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int LengthInSeconds { get; set; }
        private List<Comment> comments = new List<Comment>();

        public Video(string title, string author, int lengthInSeconds)
        {
            Title = title;
            Author = author;
            LengthInSeconds = lengthInSeconds;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("Learning C# Basics", "Code Academy", 600);
            video1.AddComment(new Comment("Alice", "This was really helpful, thanks!"));
            video1.AddComment(new Comment("Bob", "Can you make one for advanced topics?"));
            video1.AddComment(new Comment("Charlie", "Clear explanation, loved it."));

            Video video2 = new Video("Top 10 Soccer Goals", "Sports Hub", 420);
            video2.AddComment(new Comment("Diego", "Messi’s goal was insane!"));
            video2.AddComment(new Comment("Maria", "I could watch this all day."));
            video2.AddComment(new Comment("Leo", "Great compilation."));

            Video video3 = new Video("How to Cook Pasta", "Foodie World", 300);
            video3.AddComment(new Comment("Sophie", "Just tried this recipe—amazing!"));
            video3.AddComment(new Comment("Liam", "Can you do a vegan version?"));
            video3.AddComment(new Comment("Emma", "Easy to follow, thank you!"));

            List<Video> videos = new List<Video> { video1, video2, video3 };

            foreach (var video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
                Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");

                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
                }

                Console.WriteLine(new string('-', 40));
            }
        }
    }
}
