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
    public sealed class FacilityAndActivityRepository : IFacilityAndActivityRepository
    {
        private readonly CISDbContext _dbContext;

        public FacilityAndActivityRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<FacilityAndActivityEntity> CreateFacilityAndActivityAsync(FacilityAndActivityEntity facilityAndActivityEntity, CancellationToken token)
        {
            await _dbContext.FacilityAndActivityTypes.AddAsync(facilityAndActivityEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.FacilityAndActivityTypes
                                .Include(x => x.Facility)
                                .Include(x => x.Activity)
                                .SingleAsync(facilityAndActivity => facilityAndActivity.Id == facilityAndActivityEntity.Id, token);
        }

        public async Task<IEnumerable<FacilityAndActivityEntity>> GetFacilityAndActivityListAsync(CancellationToken token)
        {
            return await _dbContext.FacilityAndActivityTypes
                                .Include(x => x.Facility)
                                .Include(x => x.Activity)
                                .Where(facilityAndActivity => facilityAndActivity.IsActive).ToListAsync(token);
        }

        public async Task<FacilityAndActivityEntity> GetFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token)
        {
            return await _dbContext.FacilityAndActivityTypes
                                .Include(x => x.Facility)
                                .Include(x => x.Activity)
                                .FirstOrDefaultAsync(facilityAndActivity => facilityAndActivity.Id == facilityAndActivityId && facilityAndActivity.IsActive, token);
        }

        public async Task<FacilityAndActivityEntity> UpdateFacilityAndActivityByIdAsync(FacilityAndActivityEntity facilityAndActivityEntity, CancellationToken token)
        {
            _dbContext.FacilityAndActivityTypes.Update(facilityAndActivityEntity);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.FacilityAndActivityTypes
                               .Include(x => x.Facility)
                               .Include(x => x.Activity)
                               .SingleAsync(facilityAndActivity => facilityAndActivity.Id == facilityAndActivityEntity.Id, token);
        }

        public async Task DeleteFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token)
        {
            var facilityAndActivityEntity = await _dbContext.FacilityAndActivityTypes.SingleAsync(facilityAndActivity => facilityAndActivity.Id == facilityAndActivityId, token);
            facilityAndActivityEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
