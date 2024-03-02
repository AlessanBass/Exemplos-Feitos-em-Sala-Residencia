namespace TechMed.Application.Services.Interfaces;
using TechMed.Application.InputModels;
using TechMed.Application.ViewModels;

public interface IAtendimentoService
{
    public List<AtendimentoViewModel> GetAll();
    public int Create(NewAtendimentoInputModel atendimento);

}
