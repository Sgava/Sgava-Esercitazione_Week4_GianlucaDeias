namespace Gestione_spese.core.Entities
{
    public class Spese
    {
        public int Id { get; set; }
        public DateTime DataSpesa { get; set; }        
        public string Descrizione { get; set; }
        public string Utente { get; set; }
        public decimal Importo { get; set; }
        public bool Approvato { get; set; }
        public int CategoriaId { get; set; }

        //navigation property

       public Categorie Categoria { get; set; }



    }
}