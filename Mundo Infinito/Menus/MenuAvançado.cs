using Mundo_Infinito.Data;
using Mundo_Infinito.Services;
using System.Net.Http.Headers;

namespace Mundo_Infinito.Menus;

internal class MenuAvançado
{
    
    public void OpcaoZero()
    {
        BibliotecaContext contexto = new BibliotecaContext();
        ExibirAutores exibirAutores = new ExibirAutores(contexto);
        CadastrarAutor cadastrarAutor = new CadastrarAutor(contexto);
        CadastrarLivro cadastrarLivro = new CadastrarLivro(contexto, exibirAutores);
        CadastrarUsuario cadastrarUsuario = new CadastrarUsuario(contexto);
        Console.Clear();
        Console.WriteLine("\nOpções avançadas");
        Console.WriteLine("Para registrar um autor digite: 1");
        Console.WriteLine("Para registrar um livro digite: 2");
        Console.WriteLine("para registrar um usuario digite: 3");
        Console.WriteLine("para voltar ao menu digite: 4");
        Console.Write("\nOpção: ");
        string Escolha = Console.ReadLine()!;
        int EscolhaNun = int.Parse(Escolha);
        switch (EscolhaNun) 
        {
            case 1 : cadastrarAutor.AdicionarNovoAutor();
                break;
            case 2 : cadastrarLivro.AdicionarNovoLivro();
                break;
            case 3 : cadastrarUsuario.AdicionarNovoUsuario();
                break;
            
        }
    }
}
