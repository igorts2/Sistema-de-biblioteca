using Mundo_Infinito.Services;

namespace Mundo_Infinito.Menus;

internal class Menu4
{
    private readonly PesquisarLivro _pesquisarLivro;
    private readonly ServicoEmprestimo _servicoEmprestimo;

    public Menu4(PesquisarLivro pesquisarLivro, ServicoEmprestimo servicoEmprestimo)
    {
        _pesquisarLivro = pesquisarLivro;
        _servicoEmprestimo = servicoEmprestimo;
    }

    public void MenuQuatro()
    {
        Console.Clear();
        Console.WriteLine("Opção 4: Empréstimos e devoluções!");
        Console.WriteLine("\nDigite 1: para empréstimo." +
            "\nDigite 2: para devolução.");

        string escolha = Console.ReadLine();
        int escolhaNum;

        if (int.TryParse(escolha, out escolhaNum))
        {
            switch (escolhaNum)
            {
                case 1:
                    RealizarEmprestimo();
                    break;
                case 2:
                    RealizarDevolucao();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida. Digite um número.");
        }
    }

    private void RealizarEmprestimo()
    {
        Console.Clear();
        Console.WriteLine("Empréstimo de livro.");
        _pesquisarLivro.BuscarLivro();

        Console.WriteLine("\nDigite o ID do livro para empréstimo:");
        if (int.TryParse(Console.ReadLine(), out int livroID))
        {
            Console.WriteLine("\nDigite o ID do usuário para empréstimo:");
            if (int.TryParse(Console.ReadLine(), out int usuarioID))
            {
                _servicoEmprestimo.FazerEmprestimo(livroID, usuarioID);
            }
            else
            {
                Console.WriteLine("ID do usuário inválido. Digite um número inteiro válido.");
            }
        }
        else
        {
            Console.WriteLine("ID do livro inválido. Digite um número inteiro válido.");
        }
    }

    private void RealizarDevolucao()
    {
        Console.Clear();
        Console.WriteLine("Devolução de livro.");

        Console.WriteLine("\nDigite o ID do empréstimo para devolução:");
        if (int.TryParse(Console.ReadLine(), out int emprestimoID))
        {
            _servicoEmprestimo.FazerDevolucao(emprestimoID);
        }
        else
        {
            Console.WriteLine("ID do empréstimo inválido. Digite um número inteiro válido.");
        }
    }
}
