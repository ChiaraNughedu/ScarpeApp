
using System.ComponentModel.DataAnnotations;

namespace ScarpeApp.Models
{
    public class Articolo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il nome è obbligatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Il prezzo è obbligatorio")]
        public decimal Prezzo { get; set; }
        public string Descrizione { get; set; }

        [Url(ErrorMessage = "Inserisci un URL valido per l'immagine")]
        public string ImmagineCopertina { get; set; } 
        public string ImmagineAggiuntiva1 { get; set; } 
        public string ImmagineAggiuntiva2 { get; set; } 
        
    }
}


