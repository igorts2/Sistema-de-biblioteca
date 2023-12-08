namespace Mundo_Infinito.Modelos;

internal class Livro
{
    public Livro(int livroID, string titulo, int autorID, int copiasDisponiveis )
    {
        LivroID = livroID;
        Titulo = titulo;
        AutorID = autorID;
        CopiasDisponiveis = copiasDisponiveis;

    }

    public int LivroID { get; set; }
    public string Titulo { get; set; }
    public int AutorID { get; set; }
    public Autor Autor { get; set; }
    public int CopiasDisponiveis { get; set; }
}
