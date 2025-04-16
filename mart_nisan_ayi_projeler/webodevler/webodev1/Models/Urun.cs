using System.ComponentModel.DataAnnotations;

namespace webodev1.Models
{
    public enum StokDurumu
    {
        StoktaVar,
        StoktaYok,
        AzStok
    }

    public class Urun
    {
        [Required(ErrorMessage = "Ürün adı giriniz")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Açıklama giriniz")]
        [StringLength(200, ErrorMessage = "En fazla 200 karakter olabilir.")]
        public string Aciklama { get; set; }

        [Required(ErrorMessage = "Fiyat giriniz")]
        [Range(0.01, 100000, ErrorMessage = "Geçerli bir fiyat giriniz")]
        public decimal Fiyat { get; set; }

        public StokDurumu StokDurumu { get; set; }
    }
}