namespace Mundo_Infinito.Modelos;

internal class Usuario
{
    public Usuario(int usuarioID, string nomeUsuario, int numeroIdentificacao) 
    {
        UsuarioID = usuarioID;
        NomeUsuario = nomeUsuario;
        NumeroIdentificacao = numeroIdentificacao;
    }

    public int UsuarioID { get; set; }
    public string NomeUsuario { get; set; }
    public int NumeroIdentificacao { get; set; }


}
