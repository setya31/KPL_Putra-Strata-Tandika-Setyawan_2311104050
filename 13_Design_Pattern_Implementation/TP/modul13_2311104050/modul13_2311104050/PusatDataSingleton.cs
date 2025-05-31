using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    // Atribut
    private List<string> DataTersimpan;
    private static PusatDataSingleton instance;

    // Konstruktor private
    private PusatDataSingleton()
    {
        DataTersimpan = new List<string>();
    }

    // Method untuk mendapatkan instance
    public static PusatDataSingleton GetDataSingleton()
    {
        if (instance == null)
        {
            instance = new PusatDataSingleton();
        }
        return instance;
    }

    // Method untuk menambahkan data
    public void AddSebuahData(string input)
    {
        DataTersimpan.Add(input);
    }

    // Method untuk menghapus data berdasarkan index
    public void HapusSebuahData(int index)
    {
        if (index >= 0 && index < DataTersimpan.Count)
        {
            DataTersimpan.RemoveAt(index);
        }
    }

    // Method untuk mencetak semua data
    public void PrintSemuaData()
    {
        foreach (var data in DataTersimpan)
        {
            Console.WriteLine(data);
        }
    }

    // Method untuk mendapatkan semua data
    public int GetSemuaData()
    {
        return DataTersimpan.Count;
    }
}