using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KurumsalTarimProjesi.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen İsim Giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen E-Posta Giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz")]
        [Compare("Password", ErrorMessage = "Lüften Şİfreleri Düzgün Girdiğinize Emin Olun")]
        public string ConfirmPassword { get; set; }
    }
}
