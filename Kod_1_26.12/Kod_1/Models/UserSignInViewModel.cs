using Microsoft.Build.Framework;
using Kod_1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Kod_1.Models
{
    public class UserSignInViewModel
    {
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
        public string username { get; set; }
        [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lütfen şifrenizi giriniz")]
        public string password { get; set; }
    }
}
