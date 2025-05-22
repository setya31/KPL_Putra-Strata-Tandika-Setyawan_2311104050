using System;

class Program
{
    static void Main(string[] args)
    {
        CovidConfig config = new CovidConfig();
        string configFilePath = "covid_config.json";
        config.LoadConfig(configFilePath);

        Console.WriteLine($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}");
        double suhu = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman?");
        int hariDeman = Convert.ToInt32(Console.ReadLine());

        bool isSuhuValid = (config.satuan_suhu == "celcius" && suhu >= 36.5 && suhu <= 37.5) ||
                           (config.satuan_suhu == "fahrenheit" && suhu >= 97.7 && suhu <= 99.5);
        bool isHariValid = hariDeman < config.batas_hari_deman;

        if (isSuhuValid && isHariValid)
        {
            Console.WriteLine(config.pesan_diterima);
        }
        else
        {
            Console.WriteLine(config.pesan_ditolak);
        }

        // Contoh penggunaan method UbahSatuan
        config.UbahSatuan();
        Console.WriteLine($"Satuan suhu telah diubah menjadi: {config.satuan_suhu}");
    }
}