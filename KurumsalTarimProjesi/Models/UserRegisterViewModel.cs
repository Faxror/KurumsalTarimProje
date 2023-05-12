using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Kullanıı Adınızı Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen E-Posta Adresinizi Giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lütfen Şifrenizin Doğru Olduğuna Emin Olun")]

        public string confrimpassword { get; set; }
    }

}
