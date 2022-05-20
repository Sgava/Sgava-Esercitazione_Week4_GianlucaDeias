using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_spese.core.Entities
{
    public class Categorie
    {
        public int Id { get; set; }
        public string Categoria { get; set; }

        //navigation property

        public ICollection<Spese> Spese { get; set; }
    }
}
