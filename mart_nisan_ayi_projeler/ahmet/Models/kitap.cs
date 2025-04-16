using System.ComponentModel.DataAnnotations;
namespace urun.Models
{
    public class Kitaplar
    {
        [Key]
        public int kitapID { get; set; }
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string? kitapAd { get; set; }
        [Required(ErrorMessage = "Açıklama alanı boş geçilemez")]
        public string? kitapAciklama { get; set; }
        [Required(ErrorMessage = "Resim alanı boş geçilemez")]
        public string? kitapResim { get; set; }

        [Required(ErrorMessage = "Fiyat alanı boş geçilemez")]
        public double kitapFiyat { get; set; }

        [Required(ErrorMessage = "Stok alanı boş geçilemez")]
        [Range(1, 100, ErrorMessage = "Stok 1 ile 100 arasında olmalıdır")]
        public int kitapStok { get; set; }

        public int kategoriID { get; set; }

    }
}

