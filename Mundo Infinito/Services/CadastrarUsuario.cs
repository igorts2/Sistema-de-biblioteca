using Mundo_Infinito.Data;
using Mundo_Infinito.Modelos;

namespace Mundo_Infinito.Services;

internal class CadastrarUsuario
{
    private readonly BibliotecaContext _contexto;
    public CadastrarUsuario(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }
    public void AdicionarNovoUsuario()
    {
        Console.Clear();
        Console.WriteLine("Cadastrar Usuario!");
        Console.WriteLine("\nDigite o Nome do usuario:");
        string nomeUsuario = Console.ReadLine()!;

        int numeroIdentificacao;

        do
        {
            Console.WriteLine("\nDigite seu numero de Identificação com 6 Digitos:");
            string identificacao = Console.ReadLine()!;

            if (identificacao.Length == 6 && int.TryParse(identificacao, out numeroIdentificacao))
            {
                break;
            }
            else
            {
                Console.WriteLine("Número de identificação inválido. Digite um número com 6 dígitos.");
            }

        } while (true);


        Random random = new Random();
        int usuarioID = random.Next(1000, 9999);

        Usuario novoUsuario = new Usuario(usuarioID, nomeUsuario, numeroIdentificacao);
        _contexto.AdicionarUsuario(novoUsuario);
        Console.WriteLine($"\nUsuario: {nomeUsuario}" +
            $" \nN.Identificação: {numeroIdentificacao}" +
            $"\nID: {usuarioID}" +
            $"\nAdicionado com sucesso!");


    }
}
