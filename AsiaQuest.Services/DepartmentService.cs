using AsiaQuest.DataAccessLayer;
using AsiaQuest.DataTransferObjects.Masters;
using AsiaQuest.BusinessObjects.Masters;
using AutoMapper;
using System.Threading.Tasks;
using AsiaQuest.Abstracts;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AsiaQuest.Services
{
    public class DepartmentService: IDepartmentService
    {
        private readonly CoreDbContext _context;
        private readonly IMapper _mapper;
        public DepartmentService(
                CoreDbContext context,
                IMapper mapper
            )
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Insert(DepartmentDto dto)
        {
            var entity = _mapper.Map<DepartmentDto, Department>(dto);
            _context.Departments.Add(entity);
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
        public async Task<bool> Update(DepartmentDto dto)
        {
            var entity = _mapper.Map<DepartmentDto, Department>(dto);
            _context.Departments.Update(entity);
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
        public async Task<List<DepartmentDto>> GetDepartments()
        {
            var entities = await _context.Departments.ToListAsync();
            var dtoList = _mapper.Map<List<Department>, List<DepartmentDto>>(entities);
            return dtoList;
        }
    }
}
