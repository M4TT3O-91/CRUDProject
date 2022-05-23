using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class BandViewModel
    {
        public int IdBand { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Url]
        public string Immagine { get; set; }

        [Required]
        public int Artista_ID { get; set; }
    }
}
