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
    public sealed class FacilityRepository : IFacilityRepository
    {
        private readonly CISDbContext _dbContext;

        public FacilityRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FacilityEntity> CreateFacilityAsync(FacilityEntity facilityEntity, CancellationToken token)
        {
            await _dbContext.Facilities.AddAsync(facilityEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.Facilities
                                .SingleAsync(facility => facility.Id == facilityEntity.Id, token);
        }

        public async Task<IEnumerable<FacilityEntity>> GetFacilityListAsync(CancellationToken token)
        {
            return await _dbContext.Facilities
                                   .Where(facility => facility.IsActive).ToListAsync(token);
        }

        public async Task<FacilityEntity> GetFacilityByIdAsync(int facilityId, CancellationToken token)
        {
            return await _dbContext.Facilities.FirstOrDefaultAsync(facility => facility.Id == facilityId && facility.IsActive, token);
        }

        public async Task<FacilityEntity> UpdateFacilityByIdAsync(FacilityEntity facilityEntity, CancellationToken token)
        {
            _dbContext.Facilities.Update(facilityEntity);
            await _dbContext.SaveChangesAsync(token);
            return facilityEntity;
        }

        public async Task DeleteFacilityByIdAsync(int facilityId, CancellationToken token)
        {
            var facilityEntity = await _dbContext.Facilities.SingleAsync(facility => facility.Id == facilityId, token);
            facilityEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
