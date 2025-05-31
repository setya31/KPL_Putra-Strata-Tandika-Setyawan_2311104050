using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat dua variabel dengan instance yang sama
        PusatDataSingleton data1 = PusatDataSingleton.GetDataSingleton();
        PusatDataSingleton data2 = PusatDataSingleton.GetDataSingleton();

        // Menambahkan data ke data1
        data1.AddSebuahData("Anggota 1: Setya");
        data1.AddSebuahData("Anggota 2: Shapik");
        data1.AddSebuahData("Asisten: Ramdan");

        // Mencetak data dari data2 (harus sama dengan data1)
        Console.WriteLine("Data sebelum penghapusan:");
        data2.PrintSemuaData();

        // Menghapus data asisten dari data2
        data2.HapusSebuahData(2);

        // Mencetak data dari data1 (asisten harus sudah terhapus)
        Console.WriteLine("\nData setelah penghapusan:");
        data1.PrintSemuaData();

        // Mengecek jumlah data
        Console.WriteLine($"\nJumlah data di data1: {data1.GetSemuaData()}");
        Console.WriteLine($"Jumlah data di data2: {data2.GetSemuaData()}");
    }
}