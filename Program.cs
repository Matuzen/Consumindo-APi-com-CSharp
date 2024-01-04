using ScreenSound_04.Filters;
using ScreenSound_04.Models;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarGeneros(musicas);
        LinqOrder.ArtistasOrdenados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Algo deu errado:" + ex.Message);
    }
}