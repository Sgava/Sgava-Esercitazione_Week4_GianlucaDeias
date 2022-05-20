using Gestione_spese.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_spese.core.BuisnessLayer
{
    public interface IbusinessLayer
    {
        bool InserisciNuovaSpesa(Spese spesa);
        bool ApprovaNuovaSpesa(int CodiceSpesa);
        bool CancellaSpesa(int CodiceSpesa);
        ICollection<Spese> MostraSpeseApprovate();
        ICollection<Spese> MostraSpeseUtente(string nomeUtente);
        ICollection<Spese> MostraSpesePerCategoria();



    }
}
