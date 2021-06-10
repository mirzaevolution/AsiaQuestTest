using System;

namespace AsiaQuest.DataTransferObjects.Identities
{
    
    public class AppUserDto
    {
        public string Id = Guid.NewGuid().ToString().ToUpper();
        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
