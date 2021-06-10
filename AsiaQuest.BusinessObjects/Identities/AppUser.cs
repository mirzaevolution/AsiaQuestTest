using Microsoft.AspNetCore.Identity;
using System;

namespace AsiaQuest.BusinessObjects.Identities
{
    public class BaseUser : IdentityUser<string> 
    {

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
    public class AppUser: BaseUser
    {
        public AppUser()
        {
            this.Id = Guid.NewGuid().ToString().ToUpper();
        }
        public string FullName { get; set; }
    }
}
