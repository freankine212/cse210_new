using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videosList = new List<Video>();

        //video 1
        Video video1 = new Video("Lets go down to Panama", "John Johnson", 1200);
        
        Comment video1Comment1 = new Comment("Juan", "I love that you are showing Panama! I have always loved seeing new places!");
        Comment video1Comment2 = new Comment("Bill", "Look at that huge bird in that tree! Is that an eagle?");
        Comment video1Comment3 = new Comment("Olga", "MY FAMILY ONCE WENT THROUGH THE CANAL. HELLO FROM RUSSIA.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);
        


        //video 2
        Video video2 = new Video("Craig plays 'Through the fire and flames'", "Craig Jepperson", 441);
        
        Comment video2Comment1 = new Comment("metallover326362", "Bro, you killed it. Keep it up and play some Windrose for me some day.");
        Comment video2Comment2 = new Comment("Jim", "My dad loves this song.");
        Comment video2Comment3 = new Comment("Hank", "I dunno what this music is but it sure is good I tell you hwat.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);
        


        //video 3
        Video video3 = new Video("Watch me fail at cooking", "Swizzlewannabe", 360);


        Comment video3Comment1 = new Comment("cookmaster12", "Ouch man. Thats rough.");
        Comment video3Comment2 = new Comment("Julia C.", "I love this channel! They always make such good food even though it looks terrible! They should be on that one Netflix show.");
        Comment video3Comment3 = new Comment("Bill", "All you need to cook meat is good ol' S&P. Salt and Pepper. Yep!.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        //video 4
        Video video4 = new Video("Why are we even here (BIG MYSTERY)", "Jehosephat Brothers", 300);
        
        
        Comment video4Comment1 = new Comment("Gabriel", "Why are you guys even doing this? This is dumb lol");
        Comment video4Comment2 = new Comment("BillyMaysLover", "That was a good explanation into why the world is the way it is.");
        Comment video4Comment3 = new Comment("Gachaman", "I knew this was going to be some kind of ad for a new product. Why are all the good YouTubers so boring now.");

        video4.ListComment(video4Comment1);
        video4.ListComment(video4Comment2);
        video4.ListComment(video4Comment3);

        videosList.Add(video4);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }  
    } 
}