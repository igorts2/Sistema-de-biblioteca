using Microsoft.EntityFrameworkCore;
using Mundo_Infinito.Modelos;
using Mundo_Infinito.Services;

namespace Mundo_Infinito.Data;

internal class BibliotecaContext : DbContext
{
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Emprestimo> Emprestimos { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("Server=localhost;Database=biblioteca;User=root;Password=ij159753;", new MySqlServerVersion("8.0.34"));
    }
    public void AdicionarAutor(Autor novoAutor)
    {
        Autores.Add(novoAutor);
        SaveChanges();
    }
    public void AdicionarLivro(Livro novoLivro)
    {
        Livros.Add(novoLivro);
        SaveChanges();
    }
    public void AdicionarUsuario(Usuario novoUsuario)
    {
        Usuarios.Add(novoUsuario);
        SaveChanges();
    }
    public bool AutorExiste(int autorId)
    {
        return Autores.Any(a => a.AutorID == autorId); 
    }
    public bool RealizarEmprestimo(int livroID, int usuarioID)
    {
        var livro = Livros.Find(livroID);
        var usuario = Usuarios.Find(usuarioID);

        if (livro != null && usuario != null && livro.CopiasDisponiveis > 0)
        {
            var emprestimo = new Emprestimo(0, livroID, usuarioID, DateTime.Now, DateTime.Now.AddDays(14));
            Emprestimos.Add(emprestimo);
            livro.CopiasDisponiveis--;

            SaveChanges();
            return true;
        }
        return false;

    }
    public bool RealizarDevolucao(int emprestimoID)
    {
        var emprestimo = Emprestimos.Find(emprestimoID);

        if (emprestimo != null && !emprestimo.Devolvido)
        {
            emprestimo.Devolvido = true;
            emprestimo.DataDevolucao = DateTime.Now;

            var livro = Livros.Find(emprestimo.LivroID);
            livro.CopiasDisponiveis++;

            SaveChanges();
            return true;
        }

        return false;
    }
}
