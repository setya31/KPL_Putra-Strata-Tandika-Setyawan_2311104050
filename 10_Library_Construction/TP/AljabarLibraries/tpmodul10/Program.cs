using AljabarLibraries;

class Program
{
    static void Main()
    {
        double[] akar = Aljabar.AkarPersamaanKuadrat(new double[] { 1, -3, -10 });
        Console.WriteLine($"Akar: {akar[0]}, {akar[1]}");

        double[] hasil = Aljabar.HasilKuadrat(new double[] { 2, -3 });
        Console.WriteLine($"Hasil Kuadrat: {hasil[0]}x^2 + {hasil[1]}x + {hasil[2]}");
    }
}