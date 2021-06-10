using AutoMapper;
using AsiaQuest.BusinessObjects.Asssets;
using AsiaQuest.BusinessObjects.Identities;
using AsiaQuest.BusinessObjects.Masters;
using AsiaQuest.DataTransferObjects.Asssets;
using AsiaQuest.DataTransferObjects.Identities;
using AsiaQuest.DataTransferObjects.Masters;
using AsiaQuest.WebApp.Models.AssetCategories;
using AsiaQuest.WebApp.Models.Departments;
using AsiaQuest.WebApp.Models.Assets;

namespace AsiaQuest.WebApp
{
    public class AutomapperConfig:Profile
    {
        public AutomapperConfig()
        {
            CreateMap<AssetCategory, AssetCategoryDto>().ReverseMap();
            CreateMap<AssetCategoryViewModel, AssetCategoryDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<DepartmentViewModel, DepartmentDto>().ReverseMap();
            CreateMap<Asset, AssetDto>().ReverseMap();
            CreateMap<AssetViewModel, AssetDto>().ReverseMap();
            CreateMap<AppUser, AppUserDto>().ReverseMap();
        }
    }
}
