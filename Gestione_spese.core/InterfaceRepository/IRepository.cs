using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_spese.core.InterfaceRepository
{
   
        public interface IRepository<T>
        {
            ICollection<T> GetAll();
            bool Add(T entity);
            bool Update(T entity);
            bool Delete(T entity);
        }
    
}
