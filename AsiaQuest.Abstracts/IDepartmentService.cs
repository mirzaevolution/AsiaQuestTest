using AsiaQuest.DataTransferObjects.Masters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsiaQuest.Abstracts
{
    public interface IDepartmentService
    {
        Task<bool> Insert(DepartmentDto dto);
        Task<bool> Update(DepartmentDto dto);
        Task<List<DepartmentDto>> GetDepartments();
    }
}
