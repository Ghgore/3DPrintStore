using Microsoft.AspNetCore.Identity;

namespace _3DPrintStoreBackendAPI.Models
{
    public class User : IdentityUser
    {
        public string? Initials { get; set; }
    }
}
