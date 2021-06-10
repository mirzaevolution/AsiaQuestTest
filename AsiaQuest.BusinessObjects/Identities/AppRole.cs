using Microsoft.AspNetCore.Identity;
using System;

namespace AsiaQuest.BusinessObjects.Identities
{
    public class BaseRole : IdentityRole<string> 
    {

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
    public class AppRole:BaseRole
    {
        public AppRole()
        {
            this.Id = Guid.NewGuid().ToString().ToUpper();
        }
    }
}
