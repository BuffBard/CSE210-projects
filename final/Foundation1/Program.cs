class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [
          new Video("MetroMin","How to Destroy a City 101",204),
          new Video("Aztech","Breaking Open an RTX 4090",12),
          new Video("WellEnough","How to be Okay with Being You",80000)
        ];
        videos[0].MakeComment("Grenade Wizard","Try G for Grenade");
        videos[0].MakeComment("Godzilla","Go for Tokyo Next!");
        videos[0].MakeComment("GregtheRockPusher","Watch for falling rocks!");
        videos[1].MakeComment("BloatedGoat3897","11 second in he finds bitcoin!");
        videos[1].MakeComment("Commander at Home","That is not how computers work...");
        videos[1].MakeComment("JimmyWithFuzzyDice","Dice Dice Dice Dice Dice Dice Dice Dice");
        videos[2].MakeComment("DotnetEnthusiest","You could be more with Dotnet.");
        videos[2].MakeComment("aBlacksmith","Forge a new future!");
        videos[2].MakeComment("asciiwithouttheasking","fjnwoqirhgvnqaeriughi greg");

        Console.WriteLine(videos);
        foreach(Video video in videos)
        {
            video.Display();
        }
}
}