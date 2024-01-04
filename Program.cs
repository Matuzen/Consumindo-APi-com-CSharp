using ScreenSound_04.Models;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[19989].ExibirDetalhesDaMusica();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Algo deu errado:" + ex.Message);
    }
}