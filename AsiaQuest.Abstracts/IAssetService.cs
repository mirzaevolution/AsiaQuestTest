using AsiaQuest.DataTransferObjects.Asssets;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsiaQuest.Abstracts
{
    public interface IAssetService
    {
        Task<bool> Insert(AssetDto dto);
        Task<bool> Update(AssetDto dto);
        Task<bool> Delete(string id);
        Task<List<AssetDto>> GetAssets();
    }
}
