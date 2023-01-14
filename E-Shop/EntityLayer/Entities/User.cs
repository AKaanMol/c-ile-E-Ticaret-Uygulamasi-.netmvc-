using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "İsim")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Soyisim")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Email")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        [EmailAddress(ErrorMessage = "E-mail formatında olmalıdır.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Kullanıcı Adı")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Boş Geçilemez")]
        [Display(Name = "Şifre")]
        [StringLength(50, ErrorMessage = "Maksimum 50 karakter girebilirsiniz.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string RePassword { get; set; }
        [StringLength(10, ErrorMessage = "Maksimum 10 karakter girebilirsiniz.")]
        public string Role { get; set; }



    }
}
