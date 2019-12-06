using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CIS.Data.Repositories
{
    public sealed class DepartmentRepository : IDepartmentRepository
    {
        private readonly CISDbContext _dbContext;

        public DepartmentRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<DepartmentEntity> GetDepartmentById(int id, CancellationToken token)
        {
            return await _dbContext.Departments
                                   .SingleAsync(department => department.Id == id && department.IsActive, token);
        }

        public async Task<DepartmentEntity> CreateDepartmentAsync(DepartmentEntity departmentEntity, CancellationToken token)
        {
            await _dbContext.Departments.AddAsync(departmentEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return departmentEntity;
        }

        public async Task<IEnumerable<DepartmentEntity>> GetDepartmentsByBranchIdAsync(int branchId, CancellationToken token)
        {
            return await _dbContext.Departments.Where(department => department.BranchId == branchId && department.IsActive).ToListAsync(token);
        }

        public async Task<DepartmentEntity> UpdateDepartmentAsync(DepartmentEntity departmentEntity, CancellationToken token)
        {
            _dbContext.Departments.Update(departmentEntity);
            await _dbContext.SaveChangesAsync(token);
            return departmentEntity;
        }

        public async Task DeleteDepartmentByIdAsync(int departmentId, CancellationToken token)
        {
            var departmentEntity =await _dbContext.Departments.SingleAsync(department => department.Id == departmentId && department.IsActive,token);
            departmentEntity.IsActive = false;
            await _dbContext.SaveChangesAsync();
        }
    }
}