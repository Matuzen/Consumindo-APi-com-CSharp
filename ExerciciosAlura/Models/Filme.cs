using System.Text.Json.Serialization;

namespace ExerciciosAlura.Models;

internal class Filme
{
    [JsonPropertyName("title")]
    public string? Titulo { get; set; }


    [JsonPropertyName("year")]
    public string? Ano { get; set; }
   

    [JsonPropertyName("crew")]
    public string? Equipe { get; set; }


    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    public void MostrarFilmes()
    {
        Console.WriteLine($"Nome: {Titulo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Direção: {Equipe}");
        Console.WriteLine($"Nota IBM: {Nota}");
    }
}
