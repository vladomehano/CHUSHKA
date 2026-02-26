using Microsoft.AspNetCore.Identity;

namespace kursovProekt.Data.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
