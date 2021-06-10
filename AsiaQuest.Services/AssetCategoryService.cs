using AsiaQuest.Abstracts;
using AsiaQuest.BusinessObjects.Asssets;
using AsiaQuest.DataAccessLayer;
using AsiaQuest.DataTransferObjects.Asssets;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsiaQuest.Services
{
    public class AssetCategoryService:IAssetCategoryService
    {
        private readonly CoreDbContext _context;
        private readonly IMapper _mapper;
        public AssetCategoryService(
                CoreDbContext context,
                IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Insert(AssetCategoryDto dto)
        {
            var entity = _mapper.Map<AssetCategoryDto, AssetCategory>(dto);
            _context.AssetCategories.Add(entity);
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
        public async Task<bool> Update(AssetCategoryDto dto)
        {
            var entity = _mapper.Map<AssetCategoryDto, AssetCategory>(dto);
            _context.AssetCategories.Update(entity);
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }

        public async Task<List<AssetCategoryDto>> GetAssetCategories()
        {
            var entities = await _context.AssetCategories.ToListAsync();
            var dtoList = _mapper.Map<List<AssetCategory>, List<AssetCategoryDto>>(entities);
            return dtoList;
        }
    }
}
