using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;
internal class LinqOrder
{
    public static void ArtistasOrdenados(List<Musica> musicas)
    {
        // Primeiro ordenamos todas as músicas com base no artista, a partir do resultado da lista ordenada, é selecioado o artista distintos (não repetidos)
        var artistasOrdenados = musicas
            .OrderByDescending(musicas => musicas.Artista)
            .Select(musicas => musicas.Artista)
            .Distinct()
            .ToList();
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($" - {artista}");
        }

    }
}
