using System;

/// <summary>
/// Kelas SayaTubeVideo merepresentasikan video dengan ID, judul, dan jumlah play.
/// </summary>
public class SayaTubeVideo
{
    // Atribut privat
    private readonly int _id;
    private readonly string _title;
    private int _playCount;

    /// <summary>
    /// Konstruktor untuk menginisialisasi video dengan judul dan ID acak.
    /// </summary>
    /// <param name="title">Judul video (maks. 200 karakter, tidak null).</param>
    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrWhiteSpace(title) || title.Length > 200)
        {
            throw new ArgumentException("Judul tidak boleh null/kosong dan harus kurang dari 200 karakter.");
        }

        var random = new Random();
        _id = random.Next(10000, 99999);
        _title = title;
        _playCount = 0;
    }

    /// <summary>
    /// Menambahkan jumlah play pada video.
    /// </summary>
    /// <param name="count">Jumlah play yang ingin ditambahkan (maks. 25 juta).</param>
    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000)
        {
            throw new ArgumentException("Jumlah play tidak valid.");
        }

        checked
        {
            _playCount += count;
        }
    }

    /// <summary>
    /// Menampilkan detail video ke konsol.
    /// </summary>
    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Play Count: {_playCount}");
    }

    /// <summary>
    /// Mengambil jumlah play dari video.
    /// </summary>
    public int GetPlayCount() => _playCount;

    /// <summary>
    /// Mengambil judul video.
    /// </summary>
    public string GetTitle() => _title;
}