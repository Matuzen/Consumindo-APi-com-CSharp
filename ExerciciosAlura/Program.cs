using ExerciciosAlura.Models;
using System.Text.Json;

using (HttpClient client = new())
{
    var resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
    var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
    Console.WriteLine(resposta);
    Console.WriteLine(filmes.Count);
}