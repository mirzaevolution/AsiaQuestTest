using AsiaQuest.DataTransferObjects.Masters;
using System;
namespace AsiaQuest.DataTransferObjects.Asssets
{
    public class AssetDto:BaseEntityDto
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string AssetCategoryId { get; set; }
        public string CategoryString { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentString { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public decimal Price { get; set; }
        public string SupplierName { get; set; }
        public virtual AssetCategoryDto AssetCategory { get; set; }
        public virtual DepartmentDto Department { get; set; }
        
    }
}
