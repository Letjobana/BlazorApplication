using EmployeeManagement.Models;
using System.Collections.Generic;

namespace EmployeeManagement.Api.Repositories.Abstracts
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
