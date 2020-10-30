using System.ComponentModel.DataAnnotations;
namespace TreinoMVC.DTO
{
    public class ContatoDTO
    {
        public int Id {get; set;}

        [Required(ErrorMessage = "Nome do contato é obrigatório!")]
        public string Nome {get; set;}
        
        [Required(ErrorMessage = "Nome da categoria é obrigatório!")]       
        public int CategoriaID {get; set;}
        public string Email { get; set; }
        public string Telefone { get; set; }


        
    }
}