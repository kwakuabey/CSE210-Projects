using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Traveling Around Ghana", "Kofi Travels", 720);
video1._comments.Add(new Comment("John", "Beautiful places."));
video1._comments.Add(new Comment("Sarah", "I want to visit there."));
video1._comments.Add(new Comment("Mike", "Great video."));
videos.Add(video1);

Video video2 = new Video("Home Workout Routine", "Fitness Zone", 540);
video2._comments.Add(new Comment("Alex", "Very useful workout."));
video2._comments.Add(new Comment("Emma", "I will try this tomorrow."));
video2._comments.Add(new Comment("Chris", "Easy to follow."));
videos.Add(video2);

Video video3 = new Video("Cooking Jollof", "Chef Ama", 900);
video3._comments.Add(new Comment("Linda", "Looks delicious."));
video3._comments.Add(new Comment("Daniel", "I will try this recipe."));
video3._comments.Add(new Comment("Grace", "Easy to understand."));
videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }

            Console.WriteLine();
        }
    }
}