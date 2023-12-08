using Mundo_Infinito.Data;
using Mundo_Infinito.Services;
namespace Mundo_Infinito.Menus;

internal class Menu
{
    public static void OpcaoEscolhida()
    {
        BibliotecaContext contexto = new BibliotecaContext();
        CadastrarAutor cadastrarAutor = new CadastrarAutor(contexto);
        var pesquisarLivro = new PesquisarLivro(contexto);
        var exibirAutores = new ExibirAutores(contexto);
        var exibirLivros = new ExibirLivros(contexto, exibirAutores);
        var detalhesDoLivro = new DetalhesDoLivro(contexto, exibirAutores);
        var servicoEmprestimo = new ServicoEmprestimo(contexto);
        var Menu1 = new Menu1(exibirLivros);
        var Menu2 = new Menu2(exibirAutores);
        var Menu3 = new Menu3(pesquisarLivro, detalhesDoLivro);
        var Menu4 = new Menu4(pesquisarLivro, servicoEmprestimo);
        var menuAvancado = new MenuAvançado();
        
        
        

        Console.Write("Digite sua opção!: ");
        string opcaoEscolhida = Console.ReadLine()!;
        int escolha = int.Parse(opcaoEscolhida);
        switch (escolha) 
        {
            case 1 : Menu1.MenuUm();
                break;
            case 2 : Menu2.MenuDois();
                break;
            case 3 : Menu3.MenuTres();
                break;
            case 4 : Menu4.MenuQuatro();
                break;
            case 5 :
                Console.WriteLine("Finalizando o sistema! Até mais!");
                Environment.Exit(0);
                break;
            case 0: menuAvancado.OpcaoZero();
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;

        }
    }

}
