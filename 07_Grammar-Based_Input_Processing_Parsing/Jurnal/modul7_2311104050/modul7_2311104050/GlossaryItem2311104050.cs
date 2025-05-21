using System.Text.Json;

public class GlossaryItem2311104050
{
    public Glossary glossary { get; set; }

    public static void ReadJSON()
    {
        try
        {
            var json = File.ReadAllText("jurnal7_3_2311104050.json");
            var data = JsonSerializer.Deserialize<GlossaryItem2311104050>(json);

            // Akses properti dengan cara yang benar
            if (data?.glossary?.GlossDiv?.GlossList?.GlossEntry != null)
            {
                GlossEntry entry = data.glossary.GlossDiv.GlossList.GlossEntry;
                Console.WriteLine($"GlossTerm: {entry.GlossTerm}");
                Console.WriteLine($"Acronym: {entry.Acronym}");
                Console.WriteLine($"Abbrev: {entry.Abbrev}");
                Console.WriteLine($"Definition: {entry.GlossDef?.para}");
            }
            else
            {
                Console.WriteLine("Data tidak lengkap atau tidak sesuai struktur");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

public class Glossary
{
    public GlossDiv GlossDiv { get; set; }
    public string title { get; set; }
}

public class GlossDiv
{
    public string title { get; set; }
    public GlossList GlossList { get; set; }
}

public class GlossList
{
    public GlossEntry GlossEntry { get; set; }
}

public class GlossEntry
{
    public string ID { get; set; }
    public string SortAs { get; set; }
    public string GlossTerm { get; set; }
    public string Acronym { get; set; }
    public string Abbrev { get; set; }
    public string GlossSee { get; set; }
    public GlossDef GlossDef { get; set; }
}

public class GlossDef
{
    public string para { get; set; }
    public List<string> GlossSeeAlso { get; set; }
}