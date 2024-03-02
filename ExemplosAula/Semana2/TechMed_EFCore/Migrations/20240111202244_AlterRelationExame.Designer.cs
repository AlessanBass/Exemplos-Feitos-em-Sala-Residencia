﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TechMed_EFCore.Models;

#nullable disable

namespace TechMed_EFCore.Migrations
{
    [DbContext(typeof(TechMedContext))]
    [Migration("20240111202244_AlterRelationExame")]
    partial class AlterRelationExame
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AtendimentoExame", b =>
                {
                    b.Property<int>("AtendimentosId")
                        .HasColumnType("int");

                    b.Property<int>("ExamesId")
                        .HasColumnType("int");

                    b.HasKey("AtendimentosId", "ExamesId");

                    b.HasIndex("ExamesId");

                    b.ToTable("AtendimentoExame");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Atendimentos", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Exames", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CRM")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Especialidade")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Salario")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Medicos", (string)null);
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endereco")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Pacientes", (string)null);
                });

            modelBuilder.Entity("AtendimentoExame", b =>
                {
                    b.HasOne("TechMed_EFCore.Models.Atendimento", null)
                        .WithMany()
                        .HasForeignKey("AtendimentosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechMed_EFCore.Models.Exame", null)
                        .WithMany()
                        .HasForeignKey("ExamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Atendimento", b =>
                {
                    b.HasOne("TechMed_EFCore.Models.Medico", "Medico")
                        .WithMany("Atendimentos")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TechMed_EFCore.Models.Paciente", "Paciente")
                        .WithMany("Atendimentos")
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Medico", b =>
                {
                    b.Navigation("Atendimentos");
                });

            modelBuilder.Entity("TechMed_EFCore.Models.Paciente", b =>
                {
                    b.Navigation("Atendimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
