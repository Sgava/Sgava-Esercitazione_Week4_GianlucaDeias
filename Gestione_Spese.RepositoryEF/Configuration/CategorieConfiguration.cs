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
    internal class CategorieConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Categorie");
            builder.HasKey(c => c.Id);
            builder.Property(c=>c.Categoria).IsRequired();
            
            // relazione Categoria - spesa 1:n

            builder.HasMany(c=>c.Spese).WithOne(s=>s.Categoria).HasForeignKey(s=>s.CategoriaId);
        }
    }
}
