using Gestione_spese.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_spese.core.InterfaceRepository
{
    public interface IRepositorySpese:IRepository<Spese>
    {
        Spese GetById(int id);
    }
}
