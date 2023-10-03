using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class ReadCinemaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ReadEnderecoDto Endereco { get; set;} //vai chamar o endereco ao listar os cinemas ou o cinema
        public ICollection<ReadSessaoDto> Sessoes { get; set; } //vai chamar a lista de sessoes do respectivo cinema ao listar os cinemas ou o cinema
    }
}
