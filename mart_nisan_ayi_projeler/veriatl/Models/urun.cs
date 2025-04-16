using System.ComponentModel.DataAnnotations;
namespace urun.Models
{
    public class urunler
    {
        [Key]
        public int urunId { get; set; }
        [Required(ErrorMessage = "Ad alanı boş bırakılamaz.")]
        public string urunAd { get; set; }
        [Required(ErrorMessage = "Açiklama alanı boş bırakılamaz.")]
        public string urunAciklama { get; set; }
        [Required(ErrorMessage = "Resim alanı boş bırakılamaz.")]
        public string urunResim { get; set; }
        [Required(ErrorMessage = "Fiyat alanı boş bırakılamaz.")]
        public int urunFiyat { get; set; }
    }
}