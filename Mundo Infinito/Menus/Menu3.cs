using Mundo_Infinito.Modelos;
using Mundo_Infinito.Services;

namespace Mundo_Infinito.Menus;

internal class Menu3
{
    private readonly PesquisarLivro _pesquisarLivro;
    private readonly DetalhesDoLivro _detalhesDoLivro;
    public Menu3(PesquisarLivro pesquisarLivro, DetalhesDoLivro detalhesDoLivro)
    {
        _pesquisarLivro = pesquisarLivro;
        _detalhesDoLivro = detalhesDoLivro;
    }

    public void MenuTres()
    {
        Console.Clear();
        Console.WriteLine("Opção 3: Pesquisar Livro!");
        _pesquisarLivro.BuscarLivro();
        _detalhesDoLivro.DetalharLivro();
        Console.WriteLine("\nclique qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();

    }
}
