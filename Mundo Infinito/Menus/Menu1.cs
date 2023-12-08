
using Mundo_Infinito.Services;

namespace Mundo_Infinito.Menus;

internal class Menu1
{
    private readonly ExibirLivros _exibirLivros;
    public Menu1(ExibirLivros exibirLivros)
    {
        _exibirLivros = exibirLivros;
    }

    public void MenuUm()
    {
        Console.Clear();
        Console.WriteLine("Opção 1: Exibindo livros!");
        _exibirLivros.ListarLivros();
        Console.WriteLine("\nclique qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();

    }
}
