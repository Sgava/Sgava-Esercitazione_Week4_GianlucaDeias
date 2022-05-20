using Gestione_spese.core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Spese.RepositoryEF.Configuration
{
    internal class SpeseConfiguration : IEntityTypeConfiguration<Spese>
    {
        public void Configure(EntityTypeBuilder<Spese> builder)
        {
            builder.ToTable("Spese");
            builder.HasKey(s => s.Id);
            builder.Property(s => s.DataSpesa).IsRequired();
            builder.Property(s => s.Descrizione).IsRequired();
            builder.Property(s => s.Utente).IsRequired();
            builder.Property(s=>s.Importo).IsRequired();
            builder.Property(s => s.Approvato).IsRequired();

            //relazione Spese - Categorie n:1

            builder.HasOne(s => s.Categoria).WithMany(c => c.Spese).HasForeignKey(s => s.CategoriaId).HasConstraintName("fk_Spesa_Categoria");
        }
    }
}
