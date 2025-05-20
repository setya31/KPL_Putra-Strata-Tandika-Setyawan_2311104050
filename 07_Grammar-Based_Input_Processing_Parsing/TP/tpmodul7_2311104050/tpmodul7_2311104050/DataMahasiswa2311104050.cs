using System.Text.Json;

public class Nama
{
    public string depan { get; set; }
    public string belakang { get; set; }
}

public class DataMahasiswa2311104050
{
    public Nama nama { get; set; }
    public string nim { get; set; }
    public string fakultas { get; set; }

    public static void ReadJSON()
    {
        string filePath = "tp7_1_2311104050.json";
        string jsonString = File.ReadAllText(filePath);
        var data = JsonSerializer.Deserialize<DataMahasiswa2311104050>(jsonString);

        Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
    }
}
