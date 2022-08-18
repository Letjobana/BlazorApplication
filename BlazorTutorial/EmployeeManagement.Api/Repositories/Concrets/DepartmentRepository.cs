using EmployeeManagement.Api.Data;
using EmployeeManagement.Api.Repositories.Abstracts;
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Repositories.Concrets
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext context;

        public DepartmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<Department> GetDepartment(int departmentId)
        {
            return await context.Departments.FirstOrDefaultAsync(d => d.DepartmentId == departmentId);
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
