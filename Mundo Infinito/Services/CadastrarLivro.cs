using Mundo_Infinito.Data;
using Mundo_Infinito.Modelos;

namespace Mundo_Infinito.Services;

internal class CadastrarLivro
{
    private readonly BibliotecaContext _contexto;
    private readonly ExibirAutores _exibirAutores;
    public CadastrarLivro(BibliotecaContext contexto, ExibirAutores exibirAutores)
    {
        _contexto = contexto;
        _exibirAutores = exibirAutores;
    }
    public void AdicionarNovoLivro()
    {
        Console.WriteLine("Cadastro de Livros!");
        Console.WriteLine("\nDigite o Titulo do livro: ");
        string titulo = Console.ReadLine()!;

        Console.WriteLine("\nID do autor!");
        _exibirAutores.ListarAutores();
        
        int autorID;
        while (true)
        {
            Console.WriteLine("\nDigite o ID do autor do livro: ");
            if (int.TryParse(Console.ReadLine(), out autorID))
            {
                if (_contexto.AutorExiste(autorID)) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ID do autor não existe! Digite novamente!");
                }
            }
            else
            {
                Console.WriteLine("ID do autor não existe! Digite novamente!");
            }
        }
        Console.WriteLine("Quantas copias disponiveis?: ");
        string inputCopias = Console.ReadLine()!;
        int copiasDisponiveis = int.Parse(inputCopias);

        Random random = new Random();
        int livroID = random.Next(1000, 10000);

        Livro novoLivro = new Livro(livroID, titulo, autorID, copiasDisponiveis);

        _contexto.AdicionarLivro(novoLivro);
        Console.WriteLine($"\nLivro adicionado com sucesso!" +
            $"\nTitulo: {titulo}" +
            $"\nID do Autor: {autorID}" +
            $"\nID do livro: {livroID}" +
            $"\nNumero de cópias: {copiasDisponiveis}");

    }

}
