﻿namespace Techmed.Domain;

public class Medico : Pessoa{
    public required string CRM {get; set;}
    public string? Especialidade {get; set;}
    public decimal? Salario {get; set;}
    public ICollection<Atendimento>? Atendimentos {get;}
}
