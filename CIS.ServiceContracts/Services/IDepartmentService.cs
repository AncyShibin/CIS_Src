using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IDepartmentService
    {
        Task<DepartmentServiceObject> CreateDepartmentAsync(DepartmentServiceObject departmentServiceObject, CancellationToken token);

        Task<IEnumerable<DepartmentServiceObject>> GetDepartmentsByBranchIdAsync(int branchId, CancellationToken token);

        Task<DepartmentServiceObject> UpdateDepartmentAsync(DepartmentServiceObject departmentServiceObject, CancellationToken token);

        Task DeleteDepartmentByIdAsync(int departmentId, CancellationToken token);
    }
}
