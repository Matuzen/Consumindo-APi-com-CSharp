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
        //LinqOrder.ArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Maroon 5");

        var minhasMusicasPreferidas = new MusicasPreferidas("Matheus");
        minhasMusicasPreferidas.AdicionarMusicasPreferidas(musicas[1]);
        minhasMusicasPreferidas.AdicionarMusicasPreferidas(musicas[64]);
        minhasMusicasPreferidas.AdicionarMusicasPreferidas(musicas[646]);
        minhasMusicasPreferidas.AdicionarMusicasPreferidas(musicas[295]);
        minhasMusicasPreferidas.AdicionarMusicasPreferidas(musicas[300]);
        
        minhasMusicasPreferidas.ExibirMusicas();

        minhasMusicasPreferidas.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Algo deu errado:" + ex.Message);
    }
}