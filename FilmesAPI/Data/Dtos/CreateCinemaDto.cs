using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obirgatório")]
        public string Nome { get; set; }
        [Required]
        public int EnderecoId { get; set; }

    }
}
