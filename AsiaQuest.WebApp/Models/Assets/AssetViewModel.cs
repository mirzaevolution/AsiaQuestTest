using System;
using System.ComponentModel.DataAnnotations;

namespace AsiaQuest.WebApp.Models.Assets
{
    public class AssetViewModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        [Required]
        public string AssetCode { get; set; }
        [Required]
        public string AssetName { get; set; }
        public string AssetCategoryId { get; set; }
        public string CategoryString { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentString { get; set; }
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string SupplierName { get; set; }

    }
}
