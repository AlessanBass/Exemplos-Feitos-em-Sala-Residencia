using System;
using System.Linq;
using TechMed_EFCore.Models;

class Program
{
    static void Main()
    {

        var context = new TechMedContext();

        context.Exames.RemoveRange(context.Exames);
        context.Atendimentos.RemoveRange(context.Atendimentos);
        context.Medicos.RemoveRange(context.Medicos);
        context.Pacientes.RemoveRange(context.Pacientes);

        context.SaveChanges();

        Console.WriteLine("Lendo todos os pacientes no banco de dados");
        foreach (var paciente in context.Pacientes.OrderBy(p => p.Nome))
        {
            Console.WriteLine($"Id: {paciente.Id} - Nome: {paciente.Nome} - CPF: {paciente.CPF}");
        }

        Console.WriteLine("Criando um médico no banco de dados");
        var novoMedico = new Medico
        {
            Nome = "Dr. Dexter",
            CPF = "123.456.789-00",
            CRM = "123456",
            Especialidade = "Clínico Geral",
            Salario = 10000
        };
        context.Medicos.Add(novoMedico);
        context.SaveChanges();

        Console.WriteLine("Criando um paciente no banco de dados");
        var novoPaciente = new Paciente
        {
            Nome = "Valber",
            CPF = "101.202.303-00",
            Endereco = "Rua A, 0",
            Telefone = "1234-5678"
        };
        context.Pacientes.Add(novoPaciente);
        context.SaveChanges();

        Console.WriteLine("Criando um atendimento no banco de dados");
        var novoAtendimento = new Atendimento
        {
            DataHora = DateTime.Now,
            Medico = novoMedico,
            Paciente = novoPaciente
            // Se necessário, você pode adicionar exames aqui
        };
        context.Atendimentos.Add(novoAtendimento);
        context.SaveChanges();

        Console.WriteLine("Atualizando o nome de um paciente no banco de dados");
        var pacienteParaAtualizar = context.Pacientes.FirstOrDefault(p => p.CPF == "101.202.303-00");
        if (pacienteParaAtualizar != null)
        {
            pacienteParaAtualizar.Nome = "João";
            context.Pacientes.Update(pacienteParaAtualizar);
            context.SaveChanges();
        }

        Console.WriteLine("Removendo o primeiro médico no banco de dados");
        var primeiroMedico = context.Medicos.FirstOrDefault();
        if (primeiroMedico != null)
        {
            context.Medicos.Remove(primeiroMedico);
            context.SaveChanges();
        }



        Console.WriteLine("Finalizando o programa");
    }
}
