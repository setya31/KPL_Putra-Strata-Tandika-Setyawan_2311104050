using System;

/// <summary>
/// Mewakili video YouTube dengan kemampuan pelacakan jumlah putar.
/// </summary>
public class SayaTubeVideo
{
    private readonly int _id;
    private readonly string _judul;
    private int _jumlahPutar;

    /// <summary>
    /// Menginisialisasi instance baru dari kelas SayaTubeVideo.
    /// </summary>
    /// <param name="judul">Judul video (maksimal 100 karakter, tidak boleh null atau kosong).</param>
    /// <exception cref="ArgumentException">Dilempar ketika judul tidak valid.</exception>
    public SayaTubeVideo(string judul)
    {
        // Pra-kondisi: judul tidak boleh null/kosong dan harus ≤ 100 karakter
        if (string.IsNullOrEmpty(judul))
        {
            throw new ArgumentException("Judul video tidak boleh null atau kosong.", nameof(judul));
        }

        if (judul.Length > 100)
        {
            throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter.", nameof(judul));
        }

        var acak = new Random();
        _id = acak.Next(10000, 99999);
        _judul = judul;
        _jumlahPutar = 0;
    }

    /// <summary>
    /// Menambah jumlah putar dengan jumlah tertentu.
    /// </summary>
    /// <param name="jumlah">Jumlah penambahan (maksimal 10.000.000 per panggilan).</param>
    /// <exception cref="ArgumentOutOfRangeException">Dilempar ketika jumlah melebihi batas.</exception>
    public void TambahJumlahPutar(int jumlah)
    {
        // Pra-kondisi: jumlah harus ≤ 10.000.000
        if (jumlah > 10000000)
        {
            throw new ArgumentOutOfRangeException(nameof(jumlah),
                "Jumlah penambahan tidak boleh lebih dari 10.000.000 per panggilan.");
        }

        try
        {
            checked
            {
                _jumlahPutar += jumlah;
            }
        }
        catch (OverflowException ex)
        {
            Console.WriteLine($"Terjadi overflow pada jumlah putar: {ex.Message}");
            // Alternatif: bisa diatur ke nilai maksimum int
        }
    }

    /// <summary>
    /// Menampilkan detail video ke konsol.
    /// </summary>
    public void CetakDetailVideo()
    {
        Console.WriteLine($"Detail Video:");
        Console.WriteLine($"- ID: {_id}");
        Console.WriteLine($"- Judul: {_judul}");
        Console.WriteLine($"- Jumlah Putar: {_jumlahPutar:N0}");
    }
}