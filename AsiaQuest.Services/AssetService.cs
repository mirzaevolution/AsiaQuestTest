using AsiaQuest.Abstracts;
using AsiaQuest.BusinessObjects.Asssets;
using AsiaQuest.DataAccessLayer;
using AsiaQuest.DataTransferObjects.Asssets;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsiaQuest.Services
{
    public class AssetService: IAssetService
    {
        private readonly CoreDbContext _context;
        private readonly IMapper _mapper;
        public AssetService(
                CoreDbContext context,
                IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Insert(AssetDto dto)
        {
            var entity = _mapper.Map<AssetDto, Asset>(dto);
            _context.Assets.Add(entity);
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
        public async Task<bool> Update(AssetDto dto)
        {
            var entity = _mapper.Map<AssetDto, Asset>(dto);
            _context.Assets.Update(entity);
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
        public async Task<bool> Delete(string id)
        {
            var entity = await _context.Assets.FirstOrDefaultAsync(c => c.Id == id);
            if (entity != null)
            {
                _context.Assets.Remove(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            throw new Exception("Data not found");
        }
        public async Task<List<AssetDto>> GetAssets()
        {
            var entities = await _context.Assets.ToListAsync();
            var dtoList = _mapper.Map<List<Asset>, List<AssetDto>>(entities);
            dtoList = (from item in dtoList
                      select new AssetDto
                      {
                          Id = item.Id,
                          CategoryString = item.AssetCategory.Name,
                          AssetCode = item.AssetCode,
                          AssetName = item.AssetName,
                          DepartmentString = item.Department.Name,
                          AssetCategoryId = item.AssetCategoryId,
                          AssetCategory = item.AssetCategory,
                          CreatedDate = item.CreatedDate,
                          Department = item.Department,
                          DepartmentId = item.DepartmentId,
                          ModifiedDate = item.ModifiedDate,
                          Price = item.Price,
                          PurchaseDate = item.PurchaseDate,
                          SupplierName = item.SupplierName
                      }).ToList();

            return dtoList;
        }
    }
}
