using System;
using System.ComponentModel.DataAnnotations;

namespace AsiaQuest.WebApp.Models.Departments
{
    public class DepartmentViewModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().ToUpper();
        [Required]
        public string Name { get; set; }
    }
}
