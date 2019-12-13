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
    public sealed class RegulatoryRepository : IRegulatoryRepository
    {
        private readonly CISDbContext _dbContext;

        public RegulatoryRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<RegulatoryEntity> CreateRegulatoryAsync(RegulatoryEntity regulatoryEntity, CancellationToken token)
        {
            await _dbContext.Regulatories.AddAsync(regulatoryEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.Regulatories
                                .SingleAsync(regulatory => regulatory.Id == regulatoryEntity.Id, token);
        }

        public async Task<IEnumerable<RegulatoryEntity>> GetRegulatoryListAsync(CancellationToken token)
        {
            return await _dbContext.Regulatories
                                   .Where(regulatory => regulatory.IsActive).ToListAsync(token);
        }

        public async Task<RegulatoryEntity> GetRegulatoryByIdAsync(int regulatoryId, CancellationToken token)
        {
            return await _dbContext.Regulatories.FirstOrDefaultAsync(regulatory => regulatory.Id == regulatoryId && regulatory.IsActive, token);
        }

        public async Task<RegulatoryEntity> UpdateRegulatoryByIdAsync(RegulatoryEntity regulatoryEntity, CancellationToken token)
        {
            _dbContext.Regulatories.Update(regulatoryEntity);
            await _dbContext.SaveChangesAsync(token);
            return regulatoryEntity;
        }

        public async Task DeleteRegulatoryByIdAsync(int regulatoryId, CancellationToken token)
        {
            var regulatoryEntity = await _dbContext.Regulatories.SingleAsync(regulatory => regulatory.Id == regulatoryId, token);
            regulatoryEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
