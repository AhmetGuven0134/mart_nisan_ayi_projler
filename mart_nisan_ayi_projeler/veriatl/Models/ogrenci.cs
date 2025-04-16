using System.ComponentModel.DataAnnotations;

public enum Devamsizlikturu
{
    İzinli, Devamsız, Gec, Raporlu
}
public class Ogrenci
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Ad alanı boş geçilemez")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad alanı en az 3 en fazla 50 karakter olmalıdır")]
    public string Ad { get; set; }
    [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Soyad alanı en az 3 en fazla 50 karakter olmalıdır")]
    public string Soyad { get; set; }
    [Required(ErrorMessage = "Numara alanı boş geçilemez")]
    [Range(1, 1000, ErrorMessage = "Numara alanı 1 ile 1000 arasında olmalıdır")]
    public int Numara { get; set; }
    public Devamsizlikturu devamdurumu { get; set; }

}