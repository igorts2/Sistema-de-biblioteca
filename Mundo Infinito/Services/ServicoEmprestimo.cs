using Mundo_Infinito.Data;
using Mundo_Infinito.Modelos;

namespace Mundo_Infinito.Services;

internal class ServicoEmprestimo
{
    private readonly BibliotecaContext _contexto;

    public ServicoEmprestimo(BibliotecaContext contexto)
    {
        _contexto = contexto;
    }

    public void FazerEmprestimo(int livroID, int usuarioID)
    {
        try
        {
            var livro = _contexto.Livros.Find(livroID);
            var usuario = _contexto.Usuarios.Find(usuarioID);

            if (livro != null && usuario != null && livro.CopiasDisponiveis > 0)
            {
                var emprestimo = new Emprestimo(0, livroID, usuarioID, DateTime.Now, DateTime.Now.AddDays(14));
                _contexto.Emprestimos.Add(emprestimo);
                livro.CopiasDisponiveis--;

                _contexto.SaveChanges();

                Console.WriteLine($"Livro '{livro.Titulo}' emprestado para '{usuario.NomeUsuario}'.");
            }
            else
            {
                Console.WriteLine("Não foi possível fazer o empréstimo. Verifique se o livro e o usuário são válidos.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao fazer o empréstimo: {ex.Message}");
            if (ex.InnerException != null)
            {
                Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
            }
        }
    }

    public void FazerDevolucao(int emprestimoID)
    {
        try
        {
            if (_contexto.RealizarDevolucao(emprestimoID))
            {
                Console.WriteLine($"Devolução registrada para o empréstimo ID {emprestimoID}.");
            }
            else
            {
                Console.WriteLine("Não foi possível fazer a devolução.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao fazer a devolução: {ex.Message}");
        }
    }
}