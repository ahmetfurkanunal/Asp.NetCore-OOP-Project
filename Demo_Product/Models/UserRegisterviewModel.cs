
using System.ComponentModel.DataAnnotations;

namespace Demo_Product.Models
{
    public class UserRegisterviewModel
    {

        [Required(ErrorMessage="Lütfen isim giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soy isim giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz.")]
        public string Mail { get; set; }
       
        
        [Required(ErrorMessage = "Lütfen şifre giriniz.")]
        public string Password { get; set; }
       

        [Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz giriniz.")]
        [Compare("Password", ErrorMessage = "Lütfen şifreyi eşleştiridğinziden emin olunuz .")]

        public string Confirmpassword { get; set; }
    }
}
