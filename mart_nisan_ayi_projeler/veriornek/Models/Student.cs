using System.ComponentModel.DataAnnotations;
namespace veriornek.Models
{
    public enum DevamsizlikTuru
    {
        Izinli,
        Devamsiz,
        Gec
    }

    public class Ogrenci
    {
        [Required(ErrorMessage = "Adınızı giriniz")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Soyadınızı giriniz")]
        [StringLength(50, ErrorMessage = "50 karakterden fazla girilmez.")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Okul no giriniz")]
        [Range(0, 10000, ErrorMessage = "0 ile 10000 arasında giriniz")]
        public int OkulNumarasi { get; set; }
        public DevamsizlikTuru DevamsizlikTuru { get; set; }
    }
}