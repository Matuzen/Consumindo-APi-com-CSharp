using System.Text.Json;

namespace ScreenSound_04.Models;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPrefereidas { get; set; }

    public MusicasPreferidas(string musica)
    {
        Nome = musica;
        ListaDeMusicasPrefereidas = new List<Musica>();
    }

    public void AdicionarMusicasPreferidas(Musica musica)
    {
        ListaDeMusicasPrefereidas.Add(musica);
    }

    public void ExibirMusicas()
    {
        Console.WriteLine($"Musicas preferidas do {Nome}");
        foreach (var item in ListaDeMusicasPrefereidas)
        {
            Console.WriteLine($" {item.Artista} de {item.Nome}" );
        }
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasPrefereidas
        });
        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }

}
