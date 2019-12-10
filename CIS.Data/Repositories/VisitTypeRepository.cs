using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.Data.Repositories
{
    public sealed class VisitTypeRepository : IVisitTypeRepository
    {
        private readonly CISDbContext _dbContext;

        public VisitTypeRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<VisitTypeEntity> CreateVisitTypeAsync(VisitTypeEntity visitTypeEntity, CancellationToken token)
        {
            await _dbContext.VisitTypes.AddAsync(visitTypeEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.VisitTypes
                                .SingleAsync(visitType => visitType.Id == visitTypeEntity.Id, token);
        }

        public async Task<IEnumerable<VisitTypeEntity>> GetVisitTypeListAsync(CancellationToken token)
        {
            return await _dbContext.VisitTypes
                                   .Where(visitType => visitType.IsActive).ToListAsync(token);
        }

        public async Task<VisitTypeEntity> GetVisitTypeByIdAsync(int visitTypeId, CancellationToken token)
        {
            return await _dbContext.VisitTypes.FirstOrDefaultAsync(visitType => visitType.Id == visitTypeId && visitType.IsActive, token);
        }

        public async Task<VisitTypeEntity> UpdateVisitTypeByIdAsync(VisitTypeEntity visitTypeEntity, CancellationToken token)
        {
            _dbContext.VisitTypes.Update(visitTypeEntity);
            await _dbContext.SaveChangesAsync(token);
            return visitTypeEntity;
        }

        public async Task DeleteVisitTypeByIdAsync(int visitTypeId, CancellationToken token)
        {
            var visitTypeEntity = await _dbContext.VisitTypes.SingleAsync(visitType => visitType.Id == visitTypeId, token);
            visitTypeEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
