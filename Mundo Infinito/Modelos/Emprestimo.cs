namespace Mundo_Infinito.Modelos;

internal class Emprestimo
{
    public Emprestimo(int emprestimoID, int livroID, int usuarioID, DateTime dataEmprestimo, DateTime dataDevolucao)
    {
        EmprestimoID = emprestimoID;
        LivroID = livroID;
        UsuarioID = usuarioID;
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
        Devolvido = false;
    }

    public int EmprestimoID { get; set; }
    public int LivroID { get; set; }
    public int UsuarioID { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }
    public bool Devolvido { get; set; }
}
