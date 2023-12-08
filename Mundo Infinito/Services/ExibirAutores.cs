
using Mundo_Infinito.Data;

namespace Mundo_Infinito.Services;

internal class ExibirAutores
{
    private readonly BibliotecaContext _contexto;
    public ExibirAutores(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }
    public void ListarAutores()
    {
        var autores = _contexto.Autores.ToList();

        if (autores.Count == 0)
        {
            Console.WriteLine("Não há autores disponíveis.");
        }
        else
        {
            Console.WriteLine("Lista de Autores Disponíveis:\n");
            foreach (var autor in autores)
            {
                Console.WriteLine($"ID: {autor.AutorID}, Nome: {autor.Nome}");
            }
        }
    }

    public string ObterNomeAutor(int autorID)
    {
        var autor = _contexto.Autores.FirstOrDefault(a => a.AutorID == autorID);
        if (autor != null)
        {
            return autor.Nome;
        }
        else
        { return "Autor não encontrado"; }
    }
}
