namespace TreinoMVC.Models
{
    public class Contato
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public Categoria Categoria {get; set;}
        public string Email { get; set; }
        public string Telefone { get; set; }

        public string Usuario {get; set;}


        

    }
}