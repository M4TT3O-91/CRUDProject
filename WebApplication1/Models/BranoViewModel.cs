using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class BranoViewModel
    {
        public int IdBrano { get; set; }

        [Required]
        [StringLength(150)]
        public string TitoloBrano { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime AnnoUscita { get; set; }

        [Range (0,999.99)]
        public decimal Durata { get; set; }

        [StringLength(150)]
        public string Genere { get; set; }
    }
}
