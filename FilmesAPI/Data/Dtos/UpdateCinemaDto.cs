using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo de nome é obirgatório")]
        public string Nome { get; set; }
    }
}
