using System;

namespace AsiaQuest.DataTransferObjects.Identities
{   
    public class AppRoleDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public string Name { get; set; }
    }
}
