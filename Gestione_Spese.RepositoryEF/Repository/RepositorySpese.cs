using Gestione_spese.core.Entities;
using Gestione_spese.core.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Spese.RepositoryEF.Repository
{
    public class RepositorySpese : IRepositorySpese
    {
        public bool Add(Spese entity)
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                ctx.Spese.Add(entity);
                ctx.SaveChanges();
            }
            return true;

        }

        public bool Delete(Spese entity)
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                ctx.Spese.Remove(entity);
                ctx.SaveChanges();
            }
            return true;
        }

        public ICollection<Spese> GetAll()
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                return ctx.Spese.ToList();
            }
        }

        public Spese GetById(int id)
        {
            return GetAll().FirstOrDefault(s => s.Id == id);
        }

        public bool Update(Spese entity)
        {
            using (var ctx = new Gestione_SpeseContext())
            {
                ctx.Spese.Update(entity);
                ctx.SaveChanges();
            }
            return true;
        }
    }
}
