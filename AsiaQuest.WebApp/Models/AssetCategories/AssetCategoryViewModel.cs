using System;
using System.ComponentModel.DataAnnotations;

namespace AsiaQuest.WebApp.Models.AssetCategories
{
    public class AssetCategoryViewModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        [Required]
        public string Name { get; set; }


    }
}
