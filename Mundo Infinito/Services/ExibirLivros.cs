

using Mundo_Infinito.Data;

namespace Mundo_Infinito.Services;

internal class ExibirLivros
{
    private readonly BibliotecaContext _contexto;
    private readonly ExibirAutores _exibirAutores;
    public ExibirLivros(BibliotecaContext contexto, ExibirAutores exibirAutores)
    {
        _contexto = contexto;
        _exibirAutores = exibirAutores;
    }
    public void ListarLivros()
    {
        var livros = _contexto.Livros.ToList();
        if (livros.Count == 0 ) 
        {
            Console.WriteLine("Não há livros disponiveis.");
        }
        else
        {
            Console.WriteLine("Lista de Livros disponíveis:\n");
            foreach ( var livro in livros )
            {
                string nomeAutor = _exibirAutores.ObterNomeAutor(livro.AutorID);
                Console.WriteLine($"\nTitulo: {livro.Titulo}" +
                    $"\nAutor: {nomeAutor}" +
                    $"\nCópias disponíveis: {livro.CopiasDisponiveis}");
            }
        }
    }
}
