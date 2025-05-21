using System;
using System.Text.Json;
using System.Collections.Generic;
using System.IO;

public class DataMahasiswa2311104050
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public static void ReadJSON()
    {
        try
        {
            // Pastikan file ada sebelum membaca
            if (!File.Exists("jurnal7_1_2311104050.json"))
            {
                Console.WriteLine("File JSON tidak ditemukan!");
                return;
            }

            var json = File.ReadAllText("jurnal7_1_2311104050.json");

            // Tambahkan options untuk handle case-insensitive dan lainnya
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                AllowTrailingCommas = true,
                ReadCommentHandling = JsonCommentHandling.Skip
            };

            var data = JsonSerializer.Deserialize<DataMahasiswa2311104050>(json, options);

            // Null check untuk data dan propertinya
            if (data == null)
            {
                Console.WriteLine("Data tidak valid atau struktur JSON tidak sesuai");
                return;
            }

            Console.WriteLine($"Name: {data.firstName ?? "N/A"} {data.lastName ?? "N/A"}");
            Console.WriteLine($"Gender: {data.gender ?? "N/A"}");
            Console.WriteLine($"Age: {data.age}");

            // Null check untuk address
            if (data.address != null)
            {
                Console.WriteLine($"Address: {data.address.streetAddress ?? "N/A"}, " +
                                $"{data.address.city ?? "N/A"}, " +
                                $"{data.address.state ?? "N/A"}");
            }
            else
            {
                Console.WriteLine("Address: N/A");
            }

            // Null check untuk courses
            Console.WriteLine("Courses:");
            if (data.courses != null)
            {
                foreach (var c in data.courses)
                {
                    if (c != null)
                    {
                        Console.WriteLine($"- {c.code ?? "N/A"}: {c.name ?? "N/A"}");
                    }
                }
            }
            else
            {
                Console.WriteLine("- No courses available");
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

public class Address
{
    public string streetAddress { get; set; }
    public string city { get; set; }
    public string state { get; set; }
}

public class Course
{
    public string code { get; set; }
    public string name { get; set; }
}