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

        string jsonString2 = File.ReadAllText("jurnal7_2_103022400134.json");
        var data2 = JsonSerializer.Deserialize<Watchlist_103022400134>(jsonString2);

        Console.WriteLine($"watchListName: {data2.watchListName}");
        int i = 1;
        foreach (var film in data2.movies)
        {
            Console.WriteLine($"Film {i} ");
            Console.WriteLine();
            i++;
        }

        Console.WriteLine($"Title: {data.title}");
        Console.WriteLine($"Director: {data.director}");
        Console.WriteLine($"Year: {data.year}");
        Console.WriteLine($"Rating: {data.rating}");
        Console.WriteLine($"Duration: {data.durationMinutes} minutes");
        Console.WriteLine($"Watched: {data.isWatched}");
    }
}
