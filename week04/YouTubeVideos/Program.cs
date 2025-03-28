using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare a list of video
        List<Video> videos = new List<Video>();

        //Create video object and its comments

        //VIDEO-1
        Video video1 = new Video("How to Make the Perfect Cup of Coffee", "CoffeeMaster101", 120);
        Comment comment1V1 = new Comment("BrewLover22", "This tutorial was super helpful! Now my coffee tastes amazing!");
        video1.AddComment(comment1V1); // first added


        Comment comment2V1 = new Comment("CaffeineQueen", "Finally, a video that shows the right coffee-to-water ratio. Thanks!");
        video1.AddComment(comment2V1); // 2 comment added


        Comment comment3V1 = new Comment("MorningJoe", "I tried it this morning. Works like a charm!");
        video1.AddComment(comment3V1); //3 comment added

        Comment comment4V1 = new Comment("WakeUpTime", "I love that you included tips on grinding the beans properly.");
        video1.AddComment(comment4V1);

        videos.Add(video1);

        //VIDEO-2
        Video video2 = new Video("Top 10 Healthy Snacks for Work", "SnackTimeGuru", 150);
        Comment comment1V2 = new Comment("SnackAddict", "I'm definitely trying the almond butter on whole grain toast! Looks so good!");
        video2.AddComment(comment1V2);

        Comment comment2V2 = new Comment("VeggieLover", "Great suggestions, but I'd love to see some vegan snack options.");
        video2.AddComment(comment2V2);

        Comment comment3V2 = new Comment("FitnessFreak", "Perfect timing! I needed some new snack ideas for the office.");
        video2.AddComment(comment3V2);

        videos.Add(video2);

        //VIDEO-3
        Video video3 = new Video("Unboxing the New Smartwatch", "TechReviewerPro", 200);
        Comment comment1V3 = new Comment("GadgetGeek", "Great video! How's the battery life on this smartwatch?");
        video3.AddComment(comment1V3);

        Comment comment2V3 = new Comment("SmartwatchFan", "Looks sleek! Can't wait for the review on its health tracking features.");
        video3.AddComment(comment2V3);

        Comment comment3V3 = new Comment("TechExplorer", "Nice unboxing! Is it compatible with both Android and iOS?.");
        video3.AddComment(comment3V3);

        videos.Add(video3);

        //VIDEO-4
        Video video4 = new Video("DIY Home Workout Routine", "FitLifeCoach", 180);
        Comment comment1V4 = new Comment("StrengthBuilder", "This routine is perfect for beginners. Just what I needed!");
        video4.AddComment(comment1V4);

        Comment comment2V4 = new Comment("YogaMaster", "I love how you incorporate stretching in the workout. Very balanced!");
        video4.AddComment(comment2V4);

        Comment comment3V4 = new Comment("HomeGymHero", "Easy to follow, but would love to see a more advanced version for next time.");
        video4.AddComment(comment3V4);

        videos.Add(video4);

        Console.WriteLine();
        Console.WriteLine("Display All video with its comments");
        foreach (Video video in videos)
        {
            Console.WriteLine("=====================================\n");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments ({video.GetNberOfComments()})");
            video.DisplayComments();
        }
    }
}