using EscolaDeIdiomas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdioma.Data.Configuration
{
    class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professores");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder.Property(x => x.Nome)
                .IsRequired();

            builder.Property(x => x.DataNascimento)
                .IsRequired();

            builder.Property(x => x.Email)
                .IsRequired();

            builder.Property(x => x.Telefone)
                .IsRequired()
                .HasMaxLength(11);

            

            
        }
    }
}
