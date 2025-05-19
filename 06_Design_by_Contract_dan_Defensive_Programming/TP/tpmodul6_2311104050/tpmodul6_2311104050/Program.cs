using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("==== Program SayaTubeVideo ====\n");

        SayaTubeVideo video = null;

        try
        {
            video = new SayaTubeVideo("Tutorial Design By Contract – Putra Strata Tandika Setyawan-2311104050");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error saat membuat video: " + e.Message);
            return;
        }

        Console.Write("Ingin menampilkan simulasi overflow? (y/n): ");
        string input = Console.ReadLine().ToLower();

        if (input == "y")
        {
            Console.WriteLine("\n=== Simulasi Overflow ===");
            for (int i = 0; i < 100000; i++)
            {
                video.IncreasePlayCount(1000000); 
            }
        }
        else
        {
            try
            {
                video.IncreasePlayCount(5000);
                video.PrintVideoDetails();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saat menambah play count: " + e.Message);
            }
        }

        Console.WriteLine("\nProgram selesai.");
    }
}
