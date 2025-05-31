using System;

/// <summary>
/// Program utama untuk demonstrasi kelas SayaTubeVideo
/// </summary>
public class Program
{
    /// <summary>
    /// Entry point aplikasi
    /// </summary>
    /// <param name="args">Argumen command line</param>
    public static void Main(string[] args)
    {
        TampilkanHeaderProgram();

        try
        {
            JalankanDemoVideo();
        }
        catch (Exception ex)
        {
            TanganiError(ex);
        }
        finally
        {
            TampilkanPesanAkhir();
        }
    }

    private static void TampilkanHeaderProgram()
    {
        Console.WriteLine("==== Program Demonstrasi SayaTubeVideo ====");
        Console.WriteLine();
    }

    private static void JalankanDemoVideo()
    {
        var video = BuatVideoContoh();

        Console.Write("Ingin menampilkan simulasi overflow? (y/n): ");
        var input = Console.ReadLine()?.ToLower();

        if (input == "y")
        {
            JalankanSimulasiOverflow(video);
        }
        else
        {
            JalankanDemoNormal(video);
        }
    }

    private static SayaTubeVideo BuatVideoContoh()
    {
        const string judulVideo = "Tutorial Design By Contract - Putra Strata Tandika Setyawan-2311104050";
        return new SayaTubeVideo(judulVideo);
    }

    private static void JalankanSimulasiOverflow(SayaTubeVideo video)
    {
        Console.WriteLine("\n=== Simulasi Overflow ===");

        try
        {
            for (int i = 0; i < 100000; i++)
            {
                video.IncreasePlayCount(1000000);
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Terjadi overflow: {ex.Message}");
        }
    }

    private static void JalankanDemoNormal(SayaTubeVideo video)
    {
        try
        {
            video.IncreasePlayCount(5000);
            video.PrintVideoDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saat menambah play count: {ex.Message}");
        }
    }

    private static void TanganiError(Exception ex)
    {
        Console.WriteLine($"Error yang tidak terduga: {ex.Message}");
        Console.WriteLine($"Stack Trace: {ex.StackTrace}");
    }

    private static void TampilkanPesanAkhir()
    {
        Console.WriteLine("\nProgram selesai dijalankan.");
    }
}