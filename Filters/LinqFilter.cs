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
            Console.WriteLine(ex.Message);
        }
    }
}
