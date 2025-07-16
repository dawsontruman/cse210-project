using System;

class Program
{
    static void Main(string[] args)
    {
        // Create 3-4 videos, adding 3-4 comments to each video.
        Video video000 = new Video("Jerry", "My Life With an Orange Addiction", 1346);
        Comment video000Comment000 = new Comment("Jacob Truman", "lol u suck");
        video000.AddComment(video000Comment000);
        Comment video000Comment001 = new Comment("Missy", "So relatable, stay strong friend!");
        video000.AddComment(video000Comment001);
        Comment video000Comment002 = new Comment("orangehater555", "So real, oranges are the worst!");
        video000.AddComment(video000Comment002);
        Comment video000comment003 = new Comment("Defender", "@Jacob Truman That's so rude! I'm reporting you. You need to be more sensitive to people's issues.");
        video000.AddComment(video000comment003);

        Video video001 = new Video("Jacob Truman", "nerd emoji", 9);
        Comment video001Comment000 = new Comment("Brainrot Barbie", "lol so funny I've watched this video a hundred times!!!!");
        video001.AddComment(video001Comment000);
        Comment video001Comment001 = new Comment("NerdHater", "Erm, actually, you did it wrong.");
        video001.AddComment(video001Comment001);
        Comment video001Comment002 = new Comment("Your Mom", "Erm, What the sigma? What the sigma?");
        video001.AddComment(video001Comment002);

        Video video002 = new Video("Arthur", "Antlers Kinda Suck", 744);
        Comment video002Comment000 = new Comment("Joe Deer", "You need to practice some self-love brother. My antlers are nothing special but I love them all the same. Looks aren't everything; there's so much more to live for, so don't let your antlers define your value.");
        video002.AddComment(video002Comment000);
        Comment video002Comment001 = new Comment("PointQueen", "I mean, your antlers are kinda dinky tho...");
        video002.AddComment(video002Comment001);
        Comment video002Comment002 = new Comment("Defender", "@PointQueen I literally hate people like this. What do you even get out of writing hurtful things on the internet? Get out of here!");
        video002.AddComment(video002Comment002);

        Video video003 = new Video("Jane Doe", "3 Hours of Rain Sounds", 10800);
        Comment video003Comment000 = new Comment("rainlover", "This video has saved my life on three seperate occasions, no joke.");
        video003.AddComment(video003Comment000);
        Comment video003Comment001 = new Comment("Noise Enjoyer", "This video is an actual public service. I can't sleep without it!");
        video003.AddComment(video003Comment001);
        Comment video003Comment002 = new Comment("SleepyWeepy", "I literally come home from work and cry to this stuff it's so nice.");
        video003.AddComment(video003Comment002);

        // display video information to the console, including all comments
        video000.DisplayVideoInfo();
        Console.WriteLine(); // blank line
        video001.DisplayVideoInfo();
        Console.WriteLine(); // blank line
        video002.DisplayVideoInfo();
        Console.WriteLine(); // blank line
        video003.DisplayVideoInfo();
    }
}