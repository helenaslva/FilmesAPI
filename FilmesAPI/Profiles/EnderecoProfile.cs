using AutoMapper;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class EnderecoProfile: Profile //extende da classe profile do automapper
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();

        }
    }
}
