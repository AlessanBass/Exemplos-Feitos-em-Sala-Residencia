using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

public class AtendimentoService : IAtendimentoService
{
     private readonly ITechMedContext _context; 
    public AtendimentoService(ITechMedContext context)
    {
        _context = context;
    }
    public int Create(NewAtendimentoInputModel atendimento)
    {
        return _context.AtendimentosCollection.Create(new Atendimento{
        PacienteId = atendimento.PacienteId,
        MedicoId = atendimento.MedicoId
        });

    }

    public List<AtendimentoViewModel> GetAll()
    {
        var atendimentos = _context.AtendimentosCollection.GetAll().Select(m => new AtendimentoViewModel{
        MedicoId = m.MedicoId,
        PacienteId = m.PacienteId
        }).ToList();

        return atendimentos;
    }
}
