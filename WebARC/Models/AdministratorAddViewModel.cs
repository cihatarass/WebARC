using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebARC.Models
{
    public class AdministratorAddViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Girin.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen  Soyadınızı Girin.")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı Adını Girin.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Girin.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Girin.")]
        [Compare("Password", ErrorMessage = "Şifreler Birbiriyle Eşleşmiyor!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Girin.")]
        public string Mail { get; set; }
    }
}
