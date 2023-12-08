using Mundo_Infinito.Services;

namespace Mundo_Infinito.Menus;

internal class Menu2
{
    private readonly ExibirAutores _exibirAutores;
    public Menu2(ExibirAutores exibirAutores)
    {
        _exibirAutores = exibirAutores;
    }

    public void MenuDois()
    {
        Console.Clear();
        Console.WriteLine("Opção 2: Exibindo Autores!");
        _exibirAutores.ListarAutores();
        Console.WriteLine("\nclique qualquer tecla para voltar");
        Console.ReadKey();
        Console.Clear();
       
        
    }
}
