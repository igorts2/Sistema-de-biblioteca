using Mundo_Infinito.Modelos;
using Mundo_Infinito.Data;
namespace Mundo_Infinito.Services;

internal class CadastrarAutor
{
    private readonly BibliotecaContext _contexto;
    public CadastrarAutor(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }
    public void AdicionarNovoAutor()
    {
        Console.WriteLine("Cadastro de Autor!");
        Console.WriteLine("\nDigite o nome do autor: ");
        string nome = Console.ReadLine()!;
       
        Console.WriteLine("\nDigite a biografia do autor: ");
        string biografia = Console.ReadLine()!;

        Random random = new Random();
        int autorID = random.Next(1000, 9999);

        Autor novoAutor = new Autor(nome, biografia, autorID);
        _contexto.AdicionarAutor(novoAutor);
        Console.WriteLine($"\nAutor: {nome} adicionado com sucesso! o seu ID é {autorID}\n" +
            $"\n{biografia}");
    }
    
}
