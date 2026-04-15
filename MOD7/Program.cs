using System.IO;
using System.Text.Json;
using MOD7;

class program
{
    static void Main(string[] args)
    {
        ReadJSON();
    }

    static void ReadJSON()
    {
        string jsonString = File.ReadAllText("jurnal7_1_103022400134.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400134>(jsonString);


        Console.WriteLine($"Title: {data.title}");
        Console.WriteLine($"Director: {data.director}");
        Console.WriteLine($"Year: {data.year}");
        Console.WriteLine($"Rating: {data.rating}");
        Console.WriteLine($"Duration: {data.durationMinutes} minutes");
        Console.WriteLine($"Watched: {data.isWatched}");
    }
}
