using EmployeeManagement.Api.Data;
using EmployeeManagement.Api.Repositories.Abstracts;
using EmployeeManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Api.Repositories.Concrets
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Department GetDepartment(int departmentId)
        {
            return context.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return context.Departments;
        }
    }
}
