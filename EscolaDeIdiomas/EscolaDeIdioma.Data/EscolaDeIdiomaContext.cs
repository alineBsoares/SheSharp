using EscolaDeIdioma.Data.Configuration;
using EscolaDeIdiomas.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdioma.Data
{
    public class EscolaDeIdiomaContext:DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Professor> Professores { get; set; }

        public DbSet<Turma> Turmas { get; set; }

        public EscolaDeIdiomaContext(DbContextOptions<EscolaDeIdiomaContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
            modelBuilder.ApplyConfiguration(new TurmaConfiguration());
        }
    }
}
