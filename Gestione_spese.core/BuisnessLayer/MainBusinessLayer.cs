using Gestione_spese.core.Entities;
using Gestione_spese.core.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_spese.core.BuisnessLayer
{
    public class MainBusinessLayer : IbusinessLayer
    {
        private readonly IRepositoryCategorie categorieRepo;
        private readonly IRepositorySpese speseRepo;

        public MainBusinessLayer(IRepositorySpese spese,IRepositoryCategorie categorie)
        {
            categorieRepo = categorie;
            speseRepo = spese;
        }


        public bool ApprovaNuovaSpesa(int CodiceSpesa)
        {
            Spese spesaDaApprovare = speseRepo.GetById(CodiceSpesa);
            if (spesaDaApprovare == null)
            {
                return false;
            }
           

            return true;
        }

        public bool CancellaSpesa(int CodiceSpesa)
        {
            Spese spesaDaEliminare = speseRepo.GetById(CodiceSpesa);
            if (spesaDaEliminare == null)
            {
                return false;
            }
            speseRepo.Delete(spesaDaEliminare);

            return true;
        }

        public bool InserisciNuovaSpesa(Spese spesa)
        {
                            
                Spese spesaEsistente = speseRepo.GetById(spesa.Id);
                if (spesaEsistente == null)
                {
                return false;
                }
                speseRepo.Add(spesa);

            return true;
            
        }

        public ICollection<Spese> MostraSpeseApprovate()
        {
            List<Spese> speseApprovate = speseRepo.GetAll().Where(s => s.Approvato == true).ToList();
            if (speseApprovate == null)
            {
                return null;
            }
            
            return speseApprovate;

        }

        public ICollection<Spese> MostraSpesePerCategoria()
        {
            throw new NotImplementedException();
        }

        public ICollection<Spese> MostraSpeseUtente(string nomeUtente)
        {
            List<Spese> speseUtente = speseRepo.GetAll().Where(s => s.Utente == nomeUtente).ToList();
            
            if (speseUtente == null)
            {
                return null;
            }
            
            return speseUtente;
        }
    }
}
