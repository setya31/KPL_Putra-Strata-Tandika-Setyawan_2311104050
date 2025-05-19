class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Putra Strata Tandika Setyawan");
        for (int i = 1; i <= 10; i++)
        {
            var video = new SayaTubeVideo($"Review Film {i} oleh Putra Strata Tandika Setyawan");
            video.IncreasePlayCount(100);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total play count: {user.GetTotalVideoPlayCount()}");
    }
}