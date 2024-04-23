using System.ComponentModel.DataAnnotations;

namespace Projem.Entities
{
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        [Display(Name = "Adı"), Required(ErrorMessage = "{0}Boş Bırakılamaz!")]
        public string Adi { get; set; } = string.Empty;
        [StringLength(50), Display(Name = "Soyadı"), Required(ErrorMessage = "{0}Boş Bırakılamaz!")]
        public string Soyadi { get; set; } = string.Empty;
        [StringLength(50)]
        public string Email { get; set; } = string.Empty;
        [StringLength(50), Required(ErrorMessage = "{0}Boş Bırakılamaz!")]
        public string? Telefon { get; set; }
        [StringLength(50)]
        public string? KullaniciAdi { get; set; }
        [StringLength(50), Required(ErrorMessage = "{0}Boş Bırakılamaz!")]
        public string Sifre { get; set; } = string.Empty;
        public bool AktifMi { get; set; }
        [Display(Name = "Kayıt Tarihi"), ScaffoldColumn(false)]
        public DateTime? EklenmeTarihi { get; set; } = DateTime.Now;
        [Display(Name = "Kullanıcı Rolü"), Required(ErrorMessage = "{0}Boş Bırakılamaz!")]
        public int RolId { get; set; }
        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }
    }
}