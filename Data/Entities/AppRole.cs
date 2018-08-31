using Microsoft.AspNetCore.Identity;

namespace ECommerce.Data.Entities
{
    //AppRole
    public class AppRole: IdentityRole<int>
    {
        public AppRole() { }
        public AppRole(string name)
        {
            Name = name;
        }
    }
}