using AsiaQuest.Abstracts;
using AsiaQuest.DataTransferObjects.Asssets;
using AsiaQuest.WebApp.Models.AssetCategories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsiaQuest.WebApp.Controllers
{
    public class AssetCategoryController : Controller
    {
        private readonly IAssetCategoryService _assetCategoryService;
        private readonly IMapper _mapper; 
        public AssetCategoryController(IAssetCategoryService assetCategoryService, IMapper mapper)
        {
            _assetCategoryService = assetCategoryService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetAssetCategories()
        {
            return Json(new
            {
                data = await _assetCategoryService.GetAssetCategories()
            });
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(AssetCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = _mapper.Map<AssetCategoryViewModel, AssetCategoryDto>(model);
                 bool result = await _assetCategoryService.Insert(dto);
                return RedirectToAction("Index", "AssetCategory");
            }
            return View(model);
        }        
    }
}
