using Mundo_Infinito.Data;
using Mundo_Infinito.Modelos;
using System.Threading.Channels;

namespace Mundo_Infinito.Services;

internal class DetalhesDoLivro
{
    private readonly BibliotecaContext _contexto;
    private readonly ExibirAutores _exibirAutores;

    public DetalhesDoLivro(BibliotecaContext contexto, ExibirAutores exibirAutores)
    {
        _contexto = contexto;
        _exibirAutores = exibirAutores;
    }

    public void DetalharLivro()
    {
        Console.WriteLine("\nDigite o ID do livro:");
        if (int.TryParse(Console.ReadLine(), out int livroID))
        {
            Livro livro = _contexto.Livros.FirstOrDefault(l => l.LivroID == livroID);

            if (livro != null)
            {

                Console.Clear();
                string nomeAutor = _exibirAutores.ObterNomeAutor(livro.AutorID);
                Console.WriteLine($"\nDetalhes do Livro:\n");
                Console.WriteLine($"ID: {livro.LivroID}\n" +
                    $"Titulo: {livro.Titulo}\n" +
                    $"Autor: {nomeAutor}\n" +
                    $"Cópias disponíveis: {livro.CopiasDisponiveis}");
            }
            else
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }
        else
        {
            Console.WriteLine("ID inválido. Digite um número inteiro válido.");
        }
    }
}
