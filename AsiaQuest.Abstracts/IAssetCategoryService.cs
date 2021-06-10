using AsiaQuest.DataTransferObjects.Asssets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsiaQuest.Abstracts
{
    public interface IAssetCategoryService
    {
        Task<bool> Insert(AssetCategoryDto dto);
        Task<bool> Update(AssetCategoryDto dto);
        Task<List<AssetCategoryDto>> GetAssetCategories();
    }
}
