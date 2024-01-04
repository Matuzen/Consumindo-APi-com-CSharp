using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;
internal class LinqFilter
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        try 
        {
            var retornaMusicas = musicas.Select(genero => genero.Genero).Distinct().ToList();
            foreach (var item in retornaMusicas)
            {
                Console.WriteLine($"{item}");
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Algo deu erroadp" + ex.Message);
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        try
        {
            // Filtrar todas as músicas onde o gênero seja igual ao gênero que recebeu como parâmetro
            // Da nossa lista de musicas, eu quero todas as musica onde o genero é igual musica.genero
            var filtrarArtistas = musicas
                .Where(musica => musica.Genero!
                .Contains(genero))
                .Select(musica => musica.Artista)
                .Distinct()
                .OrderBy(genero => genero, StringComparer.OrdinalIgnoreCase)
                .ToList();
            Console.WriteLine($"Exibindo os artistas por gênero - {genero}");
            foreach (var artista in filtrarArtistas)
            {
                Console.WriteLine($"-{artista}");
            }
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Algo deu errado" + ex.Message);
        }
    }
    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeArtista)
    {
        try
        {
            // Sempre que você quiser pegar o subconjunto de uma lista, use o Where
            var musicasFiltradas = musicas.Where(musica => musica.Artista!
            .Equals(nomeArtista))
            .ToList();
            Console.WriteLine(nomeArtista);
            foreach (var musica in musicasFiltradas)
            { 
                Console.WriteLine($"-{musica.Nome}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Algo deu errado" + ex.Message);
        }
    }
}
