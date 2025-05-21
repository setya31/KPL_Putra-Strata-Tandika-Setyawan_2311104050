using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

public class TeamMembers2311104050
{
    public List<Member> members { get; set; }

    public static void ReadJSON()
    {
        try
        {
            // Pastikan file ada sebelum membaca
            if (!File.Exists("jurnal7_2_2311104050.json"))
            {
                Console.WriteLine("File JSON tidak ditemukan!");
                return;
            }

            var json = File.ReadAllText("jurnal7_2_2311104050.json");

            // Tambahkan options untuk handle case-insensitive dan lainnya
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true,
                ReadCommentHandling = JsonCommentHandling.Skip
            };

            var data = JsonSerializer.Deserialize<TeamMembers2311104050>(json, options);

            // Null check untuk data dan members
            if (data?.members == null)
            {
                Console.WriteLine("Data tidak valid atau struktur JSON tidak sesuai");
                return;
            }

            Console.WriteLine("Team member list:");
            foreach (var m in data.members)
            {
                // Null check untuk setiap member dan propertinya
                Console.WriteLine($"{m.nim ?? "N/A"} {m.firstName ?? "N/A"} {m.lastName ?? "N/A"} ({m.age} {m.gender ?? "N/A"})");
            }
        }
        catch (JsonException jsonEx)
        {
            Console.WriteLine($"Error parsing JSON: {jsonEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

public class Member
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public string nim { get; set; }
    public int age { get; set; }
}