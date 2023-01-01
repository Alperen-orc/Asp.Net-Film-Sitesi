using Kod_1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Kod_1.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Lütfen adınızı giriniz")]
		public string Name { get; set; }
		[Required(ErrorMessage = "Lütfen soyadınızı giriniz")]
		public string SurName { get; set; }
		[Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen adınızı giriniz")]
		public string Mail { get; set; }
		[Required(ErrorMessage = "Lütfen şifreyi giriniz")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz")]
		[Compare("Password",ErrorMessage ="Girdiğiniz şifreler uyumlu değil!")]
		public string ConfirmPassword { get; set; }
	}
}
