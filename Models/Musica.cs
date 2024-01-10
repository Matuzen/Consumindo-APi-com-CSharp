﻿using System.Text.Json.Serialization;

namespace ScreenSound_04.Models;
internal class Musica
{
    private string[] Tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade 
    {
        get 
        {
            return Tonalidades[Key];
        }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista {Artista}");
        Console.WriteLine($"Nome {Nome}");
        Console.WriteLine($"Duração {Duracao /1000}");
        Console.WriteLine($"Gênero {Genero}");
        Console.WriteLine($"Nota {Tonalidade}");
    }
}
