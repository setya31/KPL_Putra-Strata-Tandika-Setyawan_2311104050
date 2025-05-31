using MatematikaLibraries;

class Program
{
    static void Main()
    {
        Console.WriteLine($"FPB: {Matematika.FPB(60, 45)}");     // Output: 15
        Console.WriteLine($"KPK: {Matematika.KPK(12, 8)}");       // Output: 24

        int[] fungsiTurunan = { 1, 4, -12, 9 };
        Console.WriteLine("Turunan: " + Matematika.Turunan(fungsiTurunan));
        // Output: 3x2 + 8x -12

        int[] fungsiIntegral = { 4, 6, -12, 9 };
        Console.WriteLine("Integral: " + Matematika.Integral(fungsiIntegral));
        // Output: x4 + 2x3 - 6x2 + 9x + C
    }
}