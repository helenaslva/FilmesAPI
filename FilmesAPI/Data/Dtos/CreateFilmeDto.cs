﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
 
        [Required(ErrorMessage = "O título do filme é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O gênero do filme é obrigatório")]
        public string Genero { get; set; }
        [Required]
        [Range(70, 600, ErrorMessage = "O filme deve ter duração mínima de 60 min e máx de 600 min")]
        public int Duracao { get; set; }
    }
}

