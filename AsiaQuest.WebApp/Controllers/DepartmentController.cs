using AsiaQuest.Abstracts;
using AsiaQuest.DataTransferObjects.Masters;
using AsiaQuest.WebApp.Models;
using AsiaQuest.WebApp.Models.Departments;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsiaQuest.WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;
        private readonly IMapper _mapper;
        public DepartmentController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<JsonResult> GetDepartments()
        {
            return Json(new
            {
                data = await _departmentService.GetDepartments()
            });
        }
        public IActionResult Insert()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Insert(DepartmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var dto = _mapper.Map<DepartmentViewModel, DepartmentDto>(model);
                bool result = await _departmentService.Insert(dto);
                return RedirectToAction("Index", "Department");
            }
            return View(model);
        }
    }
}
