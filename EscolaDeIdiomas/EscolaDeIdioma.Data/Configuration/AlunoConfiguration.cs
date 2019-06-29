using EscolaDeIdiomas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdioma.Data.Configuration
{
    class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Alunos");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.DataNascimento)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.HasOne(x => x.Turma)
                .WithMany(x => x.Alunos)
                .HasForeignKey(x => x.Id_turma);


            
        }
    }
}
