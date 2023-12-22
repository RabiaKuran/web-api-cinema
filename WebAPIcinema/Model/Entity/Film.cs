using System.ComponentModel.DataAnnotations;

namespace WebAPIcinema.Model.Entity
{
    public class Film
    {
        [Key]
        public int filmId { get; set; }
        public DateTime vizyonTarihi { get; set; }
        public string filmTuru { get; set; }
        public string filmIsmi { get; set; }
        public float hIciFiyat { get; set; }
        public float hSonuFiyat { get; set; }

    }
}
