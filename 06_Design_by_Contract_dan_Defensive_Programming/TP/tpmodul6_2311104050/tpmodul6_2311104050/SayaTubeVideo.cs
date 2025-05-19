using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        // Prekondisi: title tidak null dan maksimal 100 karakter
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // Prekondisi: maksimal 10 juta per pemanggilan
        if (count > 10000000)
            throw new ArgumentOutOfRangeException("Penambahan play count maksimal 10 juta.");

        try
        {
            checked
            {
                this.playCount += count;
            }
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Terjadi overflow: " + e.Message);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}
