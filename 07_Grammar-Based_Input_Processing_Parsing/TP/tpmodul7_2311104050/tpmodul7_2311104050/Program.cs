using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa2311104050.ReadJSON();
        Console.WriteLine();
        KuliahMahasiswa2311104050.ReadJSON();
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}