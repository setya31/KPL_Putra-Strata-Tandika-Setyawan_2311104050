using System;

/// <summary>
/// Kelas Program merupakan entry point dari aplikasi.
/// </summary>
public class Program
{
    /// <summary>
    /// Metode utama (Main) yang dijalankan saat program dieksekusi.
    /// </summary>
    public static void Main()
    {
        // Membuat instance user
        var user = new SayaTubeUser("Putra Strata Tandika Setyawan");

        // Menambahkan 10 video ke dalam user dengan judul berbeda
        for (int i = 1; i <= 10; i++)
        {
            var video = new SayaTubeVideo($"Review Film {i} oleh Putra Strata Tandika Setyawan");
            video.IncreasePlayCount(100);
            user.AddVideo(video);
        }

        // Menampilkan judul video dan total play count
        user.PrintAllVideoPlaycount();
        Console.WriteLine($"Total play count: {user.GetTotalVideoPlayCount()}");
    }
}