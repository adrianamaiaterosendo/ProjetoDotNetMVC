using System.ComponentModel.DataAnnotations;

namespace TreinoMVC.DTO
{
    public class CategoriaDTO
    {

    [Required]
     public int Id {get; set;}
    [Required(ErrorMessage = "Nome de categoria é obrigatório")]
    [StringLength(100, ErrorMessage="Nome de categoria muito grande, tente menor!")]
    [MinLength(2, ErrorMessage="Nome de categoria muito pequeno, tente maior!")]
     public string Nome {get; set;}
    }

        
    
}