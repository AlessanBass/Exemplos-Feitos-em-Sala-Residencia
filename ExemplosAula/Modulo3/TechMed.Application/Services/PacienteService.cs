using TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;
using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Application.Services;
public class PacienteService : IPacienteService
{ /* CTRL + . */
    public int Create(NewPacienteInputModel paciente)
    {
        throw new NotImplementedException();
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<PacienteViewModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public PacienteViewModel? GetByCrm(string crm)
    {
        throw new NotImplementedException();
    }

    public PacienteViewModel? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(int id, NewPacienteInputModel paciente)
    {
        throw new NotImplementedException();
    }
}
