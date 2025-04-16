using System.ComponentModel.DataAnnotations;
namespace veri1.Models
{
    public enum Devamsizlikturu
    {İzinli,Devamsiz,Gec,Raporlu}
    
    public class Ogrenci{
        [Key]
        
        public int Id {get; set;}
        [Required(ErrorMessage ="Ad alanı boş geçilmez")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Ad alanı en az 3 en fazla 50 karakter olmalı")]

        public string Ad{get; set;}
        [Required(ErrorMessage ="Soyad alanı boş geçilmez")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Soyad alanı en az 3 en fazla 50 karakter olmalı")]

        public string Soyad{get; set;}
        [Required(ErrorMessage ="Numara alanı boş geçilmez")]
        [Range(1,1000,ErrorMessage ="Numara alanı 1 ile 1000 arasında olmalı")]

        public int Numara{get; set;}
        public Devamsizlikturu devamdurumu{get; set;}
    }
}