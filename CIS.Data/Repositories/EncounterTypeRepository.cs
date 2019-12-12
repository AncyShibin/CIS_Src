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
    public sealed class EncounterTypeRepository : IEncounterTypeRepository
    {
        private readonly CISDbContext _dbContext;

        public EncounterTypeRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<EncounterTypeEntity> CreateEncounterTypeAsync(EncounterTypeEntity encounterTypeEntity, CancellationToken token)
        {
            await _dbContext.EncounterTypes.AddAsync(encounterTypeEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.EncounterTypes
                                .SingleAsync(encounterType => encounterType.Id == encounterTypeEntity.Id, token);
        }

        public async Task<IEnumerable<EncounterTypeEntity>> GetEncounterTypeListAsync(CancellationToken token)
        {
            return await _dbContext.EncounterTypes
                                   .Where(encounterType => encounterType.IsActive).ToListAsync(token);
        }

        public async Task<EncounterTypeEntity> GetEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token)
        {
            return await _dbContext.EncounterTypes.FirstOrDefaultAsync(encounterType => encounterType.Id == encounterTypeId && encounterType.IsActive, token);
        }

        public async Task<EncounterTypeEntity> UpdateEncounterTypeByIdAsync(EncounterTypeEntity encounterTypeEntity, CancellationToken token)
        {
            _dbContext.EncounterTypes.Update(encounterTypeEntity);
            await _dbContext.SaveChangesAsync(token);
            return encounterTypeEntity;
        }

        public async Task DeleteEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token)
        {
            var encounterTypeEntity = await _dbContext.EncounterTypes.SingleAsync(encounterType => encounterType.Id == encounterTypeId, token);
            encounterTypeEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
