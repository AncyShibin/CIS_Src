using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CIS.DataContracts.Entities;

namespace CIS.DataContracts.Repositories
{
    public interface IDepartmentRepository
    {
        Task<DepartmentEntity> GetDepartmentById(int id, CancellationToken token);

        Task<DepartmentEntity> CreateDepartmentAsync(DepartmentEntity departmentEntity, CancellationToken token);

        Task<IEnumerable<DepartmentEntity>> GetDepartmentsByBranchIdAsync(int branchId, CancellationToken token);

        Task<DepartmentEntity> UpdateDepartmentAsync(DepartmentEntity departmentEntity, CancellationToken token);

        Task DeleteDepartmentByIdAsync(int departmentId, CancellationToken token);
    }
}