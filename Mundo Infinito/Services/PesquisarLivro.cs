using Mundo_Infinito.Data;
using System;
using System.Linq;
namespace Mundo_Infinito.Services;


internal class PesquisarLivro
{
    private BibliotecaContext _contexto;

    public PesquisarLivro(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }
    public void BuscarLivro()
    {
        Console.WriteLine("\nDigite o titulo do livro: ");
        string buscarTitulo = Console.ReadLine();
        
        var consulta = _contexto.Livros
            .Where(livro => livro.Titulo.StartsWith(buscarTitulo))
            .Select(livro => new { livro.LivroID, livro.Titulo})
            .ToList();

        if (consulta.Count == 0)
        {
            Console.WriteLine("Nenhum livro encontrado!");
        }

        Console.WriteLine("\nResultado da pesquisa: \n");
        foreach (var livro in consulta)
        {
            Console.WriteLine($"ID: {livro.LivroID} : {livro.Titulo} ");
        }
    }
}
