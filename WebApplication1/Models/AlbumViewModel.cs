using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class AlbumViewModel
    {
        public int IdAlbum { get; set; }

        [StringLength(150)]
        public string TitoloAlbum { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime AnnoUscita { get; set; }
        
        public int Brano_ID { get; set; }
        
        public int Band_ID { get; set; }
    }
}
