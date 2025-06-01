using System;
using System.Collections.Generic;

/// <summary>
/// Kelas SayaTubeUser merepresentasikan seorang pengguna yang memiliki koleksi video.
/// </summary>
public class SayaTubeUser
{
    // Atribut privat
    private readonly int _id;
    private readonly List<SayaTubeVideo> _uploadedVideos;

    /// <summary>
    /// Nama pengguna (maks. 100 karakter, tidak null).
    /// </summary>
    public string Username { get; private set; }

    /// <summary>
    /// Konstruktor untuk inisialisasi user baru dengan username dan ID acak.
    /// </summary>
    public SayaTubeUser(string username)
    {
        if (string.IsNullOrWhiteSpace(username) || username.Length > 100)
        {
            throw new ArgumentException("Username tidak boleh kosong dan harus kurang dari 100 karakter.");
        }

        var random = new Random();
        _id = random.Next(10000, 99999);
        Username = username;
        _uploadedVideos = new List<SayaTubeVideo>();
    }

    /// <summary>
    /// Menambahkan video ke dalam daftar video yang diunggah user.
    /// </summary>
    /// <param name="video">Objek video yang akan ditambahkan.</param>
    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null || video.GetPlayCount() >= int.MaxValue)
        {
            throw new ArgumentException("Video tidak valid.");
        }

        _uploadedVideos.Add(video);
    }

    /// <summary>
    /// Menghitung total jumlah play dari seluruh video milik user.
    /// </summary>
    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (var video in _uploadedVideos)
        {
            total += video.GetPlayCount();
        }

        return total;
    }

    /// <summary>
    /// Menampilkan maksimal 8 video pertama yang diunggah user ke konsol.
    /// </summary>
    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {Username}");
        for (int i = 0; i < _uploadedVideos.Count && i < 8; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {_uploadedVideos[i].GetTitle()}");
        }
    }
}
