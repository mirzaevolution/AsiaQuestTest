using AsiaQuest.Abstracts;
using AsiaQuest.DataTransferObjects.Asssets;
using AsiaQuest.WebApp.Models.Assets;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsiaQuest.WebApp.Controllers
{
    public class AssetController : Controller
    {
        private readonly IAssetService _assetService;
        private readonly IMapper _mapper;
        public AssetController(IAssetService assetService, IMapper mapper)
        {
            _assetService= assetService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetAssets()
        {
            var dataList = await _assetService.GetAssets();
            return Json(new
            {
                data = dataList
            });
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(AssetViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = _mapper.Map<AssetViewModel, AssetDto>(model);
                bool result = await _assetService.Insert(dto);
                return RedirectToAction("Index", "Asset");
            }
            return View(model);
        }
    }
}
