using Gestione_spese.core.Entities;
using Gestione_spese.core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Spese.RepositoryEF.Repository
{
    internal class RepositoryCategorie : IRepositoryCategorie
    {
        public bool Add(Categorie entity)
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                ctx.Categorie.Add(entity);
                ctx.SaveChanges();
            }
            return true;
        }

        public bool Delete(Categorie entity)
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                ctx.Categorie.Remove(entity);
                ctx.SaveChanges();
            }
            return true;
        }

        public ICollection<Categorie> GetAll()
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                return ctx.Categorie.ToList();
            }
        }

        public Categorie GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Categorie entity)
        {
            throw new NotImplementedException();
        }
    }
}
