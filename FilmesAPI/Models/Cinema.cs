using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obirgatório")]
        public string Nome { get; set; }

        public int EnderecoId { get; set; } // o cinema não exixtse sem endereco, então precia do Id de um endereco existente 
        public virtual Endereco Endereco { get; set; }


    }
}
