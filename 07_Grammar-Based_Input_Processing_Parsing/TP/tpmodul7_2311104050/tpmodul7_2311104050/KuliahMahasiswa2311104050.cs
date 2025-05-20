using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class KuliahMahasiswa2311104050
{
    public List<MataKuliah> mata_kuliah { get; set; }

    public class MataKuliah
    {
        public string kode { get; set; }
        public string nama { get; set; }
    }

    public static void ReadJSON()
    {
        string filePath = "tp7_2_2311104050.json";
        string jsonString = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<KuliahMahasiswa2311104050>(jsonString);

        Console.WriteLine("Daftar mata kuliah yang diambil:");
        int i = 1;
        foreach (var mk in data.mata_kuliah)
        {
            Console.WriteLine($"MK {i} {mk.kode} - {mk.nama}");
            i++;
        }
    }
}
