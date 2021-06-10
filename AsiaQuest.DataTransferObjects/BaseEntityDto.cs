using System;

namespace AsiaQuest.DataTransferObjects
{
    public class BaseEntityDto
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
