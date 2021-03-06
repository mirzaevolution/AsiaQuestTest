using AsiaQuest.BusinessObjects.Asssets;
using System;
using System.Collections.Generic;

namespace AsiaQuest.BusinessObjects.Masters
{
    public class Department:BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public string Name { get; set; }
        public virtual List<Asset> Assets { get; set; } = new List<Asset>();
    }
}
