using System;

class Program
{       
         static void Main(string[] args)
    {
        Video video1 = new Video("Rugby World Cup SA Highlights", "SuperSport", 600);
        video1.AddComment(new Comment("Thabo M.", "What a thrilling game! Proud to be South African."));
        video1.AddComment(new Comment("Ayanda Nkosi", "Kolisi is a legend!"));
        video1.AddComment(new Comment("Jabu Z.", "Amazing teamwork, wow!"));

        Video video2 = new Video("Best Braai Tips for Summer", "SA Outdoor Cooking", 450);
        video2.AddComment(new Comment("Palesa M.", "Going to try that marinade recipe this weekend!"));
        video2.AddComment(new Comment("Sipho K.", "Braai culture is unmatched 🔥"));
        video2.AddComment(new Comment("Mpho D.", "Loved the spice recommendations!"));

        Video video3 = new Video("Drone Tour of Johannesburg", "SA Sky Views", 900);
        video3.AddComment(new Comment("Lerato P.", "Wow, Joburg looks stunning from above!"));
        video3.AddComment(new Comment("Tshepo M.", "Can't wait to visit the Maboneng Precinct again!"));
        video3.AddComment(new Comment("Nandi C.", "SA is beautiful 😍"));

        Video[] videos = { video1, video2, video3 }; 

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}