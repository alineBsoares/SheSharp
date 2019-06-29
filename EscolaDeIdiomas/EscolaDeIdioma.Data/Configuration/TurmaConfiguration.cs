using EscolaDeIdiomas.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EscolaDeIdioma.Data.Configuration
{
    class TurmaConfiguration : IEntityTypeConfiguration<Turma>
    {
        public void Configure(EntityTypeBuilder<Turma> builder)
        {
            builder.ToTable("Turmas");

            builder.HasKey(x => x.Id);


            builder.Property(x => x.Periodo)
                .IsRequired();

            builder.Property(x => x.Sala)
                .IsRequired();

            builder.Property(x => x.Nivel)
                .IsRequired();

            builder.Property(x => x.Periodo_conclusao)
                .IsRequired();

            builder.HasOne(x => x.Professor)
                .WithMany(x => x.Turmas)
                .HasForeignKey(x => x.Id_professor);

        }
    }
}
