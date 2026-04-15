using System;
using System.IO;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program2
{
    static void Main(string[] args)
    {
        ReadJSON1();
        Console.WriteLine();
    }

    private static void ReadJSON1()
    {
        string jsonString = File.ReadAllText("jurnal7_2_103022400113.json");
        Watchlist_103022400113 data = JsonSerializer.Deserialize<Watchlist_103022400113>(jsonString);
        Console.WriteLine("Film Yang Di Tonton Kelompok 8");

        int i = 1;
        foreach (var mv in data.movies)
        {
            Console.WriteLine($"ID : {i} {mv.id}");
            Console.WriteLine($"Title :{i} {mv.title}");
            Console.WriteLine($"Year : {i} {mv.year}");
            Console.WriteLine($"Genre :{i} {mv.genre}");
            Console.WriteLine($"Rating : {i} {mv.rating}");
            i++;
        }

    }
}


