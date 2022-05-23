using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ArtistaViewModel
    {
        public int IdArtista { get; set; }
        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(150)]
        public string Cognome { get; set; }

        [StringLength(150)]
        public string NomeArte { get; set; }

        [StringLength(150)]
        public string Tipo { get; set; }
    }
}
