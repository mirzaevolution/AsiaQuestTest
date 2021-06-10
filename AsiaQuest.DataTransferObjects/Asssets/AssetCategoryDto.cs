using System;
using System.Collections.Generic;

namespace AsiaQuest.DataTransferObjects.Asssets
{
    public class AssetCategoryDto: BaseEntityDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public string Name { get; set; }
        public virtual List<AssetDto> Assets { get; set; } = new List<AssetDto>();
        public string ModifiedDateString
        {
            get
            {
                return this.ModifiedDate.ToShortDateString();
            }
        }
    }
}
