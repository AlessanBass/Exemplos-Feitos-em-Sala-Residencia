using Microsoft.AspNetCore.Mvc;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;
using TechMed.Application.InputModels;

namespace TechMed.WebAPI.Controllers;

[ApiController]
[Route("/api/v0.1/")]
public class AtendimentoController : ControllerBase
{
   private readonly IAtendimentoCollection _atendimentos;
   public List<Atendimento> Atendimentos => _atendimentos.GetAll().ToList();
   public AtendimentoController(ITechMedContext context) => _atendimentos = context.AtendimentosCollection;
   [HttpGet("atendimentos")]
   public IActionResult Get()
   {
      return Ok(Atendimentos);

   }

   [HttpPost("/atendimento")]
   public IActionResult Post([FromBody] NewAtendimentoInputModel novoAtendimento)
   {
     
    // Chame o método Create no seu serviço, passando os inteiros como parâmetros.
    //int novoAtendimentoId = _atendimentos.Create(novoAtendimento);

    // Retorne um código 201 Created com a localização do novo recurso criado.
    return Created($"/api/v0.1/atendimentos/", null);
   }

}
