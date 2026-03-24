using System;

class Program
{
    static void Main(string[] args)
    {
        // List of videos
        List<Video> videos = new List<Video>();

        /////////////////
        // FIRST VIDEO //
        /////////////////
        // (Variables will be reused)
        string title = "Me at the zoo";
        string author = "jawed";
        int length = 19;
        Video video1 = new Video(title, author, length);

        // Comments
        // (Variables will be reused)
        string user = "@SanDiegoZoo";
        string text = "We're so honored that the first ever YouTube video was filmed here!";
        video1.AddComment(user, text);
        
        user = "@RealOne";
        text = "Wow, still in your recommended in 2021? Nice! Yay";
        video1.AddComment(user, text);
        
        user = "@RandomCitizen1";
        text = "I feel like Neil Armstrong just gave me a shoutout ... thank you!  @jawed";
        video1.AddComment(user, text);

        // Add to the list
        videos.Add(video1);

        //////////////////
        // SECOND VIDEO //
        //////////////////
        title = "Spider-Man: Trailer";
        author = "ONE Media España";
        length = 173;
        Video video2 = new Video(title, author, length);

        // Comments
        user = "@TheRandomCitizen";
        text = "I'm so glad to be here";
        video2.AddComment(user, text);
        
        user = "@FakeOne";
        text = "Woah! We'll finally see what happens next!";
        video2.AddComment(user, text);
        
        user = "@RandomCitizen1";
        text = "Let's gooooooo! It seems cool!";
        video2.AddComment(user, text);
        
        user = "@Ultra";
        text = "Why am I seeing an spanish version on my Youtube?";
        video2.AddComment(user, text);

        // Add to the list
        videos.Add(video2);

        /////////////////
        // THIRD VIDEO //
        /////////////////
        title = "Can a Hamster Survive in the Wild?";
        author = "Dr. Plants";
        length = 573;
        Video video3 = new Video(title, author, length);

        // Comments
        user = "@RandomCitizen2";
        text = "Who came here from instagram";
        video3.AddComment(user, text);
        
        user = "@..me";
        text = "Honestly so emotional the way she would go all the way from the container to her cage just to run on her wheel";
        video3.AddComment(user, text);
        
        user = "@TheRandomCitizen";
        text = "My only complaint is that this isn't an hour long. Great video";
        video3.AddComment(user, text);
        
        user = "@me89738";
        text = "Getting a new house can't replace his love with the wheel";
        video3.AddComment(user, text);

        // Add to the list
        videos.Add(video3);

        // Clear the console before displaying the information
        Console.Clear();

        foreach (Video video in videos)
        {
            video.DisplayAll();
            Console.WriteLine("______________________________________________________");
            Console.WriteLine();
        }
    }
}