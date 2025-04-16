using System.ComponentModel.DataAnnotations;

public enum UrununDurumu
{
    Taze,Bozuk,Ezikmis
}
public class Urun
{
    [Key]
    
    [Required(ErrorMessage = "Ad alanı boş geçilemez")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad alanı en az 3 en fazla 50 karakter olmalıdır")]
    public string UrunAd { get; set; }
    [Required(ErrorMessage = "Ürünün Türü alanı boş geçilemez")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "Ürünün Türü alanı en az 3 en fazla 50 karakter olmalıdır")]
    public string UrunTuru { get; set; }
    [Required(ErrorMessage = "Numara alanı boş geçilemez")]
    [Range(1, 1000, ErrorMessage = "Numara alanı 1 ile 1000 arasında olmalıdır")]
    public int Numara { get; set; }
    public UrununDurumu devamdurumu { get; set; }

}