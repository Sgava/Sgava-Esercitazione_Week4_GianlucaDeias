using Gestione_spese.core.Entities;
using Gestione_Spese.RepositoryEF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Spese.RepositoryEF
{
    internal class Gestione_SpeseContext:DbContext
    {
        public DbSet<Spese> Spese { get; set; }
        public DbSet<Categorie> Categorie { get; set; }

        public Gestione_SpeseContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=GestioneSpese;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Spese>(new SpeseConfiguration());
            modelBuilder.ApplyConfiguration<Categorie>(new CategorieConfiguration());
        }
    }
}
