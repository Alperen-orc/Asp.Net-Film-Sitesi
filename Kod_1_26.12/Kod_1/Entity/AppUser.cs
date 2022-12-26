using Microsoft.AspNetCore.Identity;

namespace Kod_1.Entity
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
		
		public string Password { get; set; }
	}
}
