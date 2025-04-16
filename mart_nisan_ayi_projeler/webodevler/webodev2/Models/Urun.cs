using System.ComponentModel.DataAnnotations;

public enum UrunKategorisi
{
    Elektronik, Giyim, Gida, Kirtasiye
}

public class Urun
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Ürün adı boş geçilemez")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Ürün adı en az 2 en fazla 100 karakter olmalıdır")]
    public string Ad { get; set; }

    [Required(ErrorMessage = "Açıklama boş geçilemez")]
    [StringLength(250, ErrorMessage = "Açıklama en fazla 250 karakter olabilir")]
    public string Aciklama { get; set; }

    [Required(ErrorMessage = "Fiyat girilmelidir")]
    [Range(0.01, 100000, ErrorMessage = "Fiyat 0.01 ile 100000 arasında olmalıdır")]
    public decimal Fiyat { get; set; }

    public UrunKategorisi Kategori { get; set; }
}