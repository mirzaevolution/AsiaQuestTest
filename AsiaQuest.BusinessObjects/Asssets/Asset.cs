using AsiaQuest.BusinessObjects.Masters;
using System;

namespace AsiaQuest.BusinessObjects.Asssets
{
    public class Asset:BaseEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public string AssetCode { get; set; }
        public string AssetCategoryId { get; set; }
        public string DepartmentId { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string SupplierName { get; set; }
        public virtual AssetCategory AssetCategory { get; set; }
        public virtual Department Department { get; set; }
        
    }
}
