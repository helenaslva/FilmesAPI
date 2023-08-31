﻿
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{

    private static List<Filme> filmes = new List<Filme>();
    private static int Id = 0;

    [HttpPost]
    public IActionResult AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = Id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperaFilmePorId), new {id = filme.Id}, filme);
        
    }

    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery]int skip = 0, [FromQuery]int take = 10)
    {
        return filmes.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if(filme == null) return NotFound();
        return Ok(filme);
    }
}
