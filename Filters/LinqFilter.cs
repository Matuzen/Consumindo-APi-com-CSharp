using ScreenSound_04.Models;

namespace ScreenSound_04.Filters;
internal class LinqFilter
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var todosGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosGeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }
}
