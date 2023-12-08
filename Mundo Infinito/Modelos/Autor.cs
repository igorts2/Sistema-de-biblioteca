using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Mundo_Infinito.Modelos;

[Table("autores")]
internal class Autor
{
    public Autor(string nome, string biografia, int autorID) 
    {
        AutorID = autorID;
        Nome = nome;
        Biografia = biografia;

    }

    public int AutorID { get; set; }
    public string Nome { get; set; }
    public string Biografia { get; set; }

    
}
