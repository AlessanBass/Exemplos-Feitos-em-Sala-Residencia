using Microsoft.EntityFrameworkCore;
using Techmed.Domain;

namespace Techmed.Infrastructure;

public class Connection
{
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Exame> Exames { get; set; }

}
