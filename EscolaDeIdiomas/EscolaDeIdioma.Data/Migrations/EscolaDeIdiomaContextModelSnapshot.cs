﻿// <auto-generated />
using System;
using EscolaDeIdioma.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EscolaDeIdioma.Data.Migrations
{
    [DbContext(typeof(EscolaDeIdiomaContext))]
    partial class EscolaDeIdiomaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EscolaDeIdiomas.Domain.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ativo");

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<DateTime>("dataNascimento");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.HasKey("id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("EscolaDeIdiomas.Domain.Professor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("cpf")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.Property<DateTime>("dataNascimento");

                    b.Property<string>("email")
                        .IsRequired();

                    b.Property<string>("nome")
                        .IsRequired();

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.HasKey("id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("EscolaDeIdiomas.Domain.Turma", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("idioma");

                    b.Property<string>("nivel")
                        .IsRequired();

                    b.Property<string>("periodo")
                        .IsRequired();

                    b.Property<DateTime>("periodo_conclusao");

                    b.Property<int>("sala");

                    b.Property<string>("turma")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Turmas");
                });
#pragma warning restore 612, 618
        }
    }
}
