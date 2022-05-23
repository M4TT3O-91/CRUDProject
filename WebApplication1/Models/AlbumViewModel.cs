using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AlbumViewModel
    {
        public int IdAlbum { get; set; }

        [StringLength(150)]
        public string TitoloAlbum { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AnnoUscita { get; set; }
        [Required]
        public int Brano_ID { get; set; }
        [Required]
        public int Band_ID { get; set; }
    }
}
