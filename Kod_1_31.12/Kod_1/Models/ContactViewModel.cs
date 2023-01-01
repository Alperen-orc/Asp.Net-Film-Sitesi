using System.ComponentModel.DataAnnotations;

namespace Kod_1.Models
{
	public class ContactViewModel
	{
		public int ContactId { get; set; }
		[Required(ErrorMessage = "İsim Alanı Boş olamaz")]
		public string Name { get; set; }
		public string Subject { get; set; }
		[Required(ErrorMessage = "Mail Alanı Boş olamaz")]
		public string Email { get; set; }
		[Required(ErrorMessage ="Mesaj Alanı Boş olamaz")]
		public string Message { get; set; }
	}
}
