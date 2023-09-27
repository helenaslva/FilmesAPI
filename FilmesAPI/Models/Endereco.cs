using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Endereco
    {
        [Key]
        [Required]

        public int Id { get; set; }

        [Required]  
        public string Logradouro { get; set; } 
        public string Bairro { get; set; }  
        public int Numero { get; set; }
        public string Cep { get; set; }

        public virtual Cinema Cinema { get; set; }// um cinema não existe sem endereco, então não precisa do Id


    }
}
