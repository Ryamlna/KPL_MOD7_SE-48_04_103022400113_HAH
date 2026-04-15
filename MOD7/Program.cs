using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        ReadJSON1();
        Console.WriteLine();
    }

    private static void ReadJSON1()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103022400113.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400113>(jsonString);
        Console.WriteLine($"Title : {data.title}");
        Console.WriteLine($"Director : {data.director}");
        Console.WriteLine($"Year : {data.year}");
        Console.WriteLine($"Genre : {data.genre}");
        Console.WriteLine($"Rating : {data.rating}");
        Console.WriteLine($"Duration : {data.durationMinutes}");
        Console.WriteLine($"Watched : {data.isWatched}");

    }
}