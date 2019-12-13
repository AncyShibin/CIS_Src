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
    public sealed class ActivityTypeRepository : IActivityTypeRepository
    {
        private readonly CISDbContext _dbContext;

        public ActivityTypeRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ActivityTypeEntity> CreateActivityTypeAsync(ActivityTypeEntity activityTypeEntity, CancellationToken token)
        {
            await _dbContext.ActivityTypes.AddAsync(activityTypeEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.ActivityTypes
                                .SingleAsync(activityType => activityType.Id == activityTypeEntity.Id, token);
        }

        public async Task<IEnumerable<ActivityTypeEntity>> GetActivityTypeListAsync(CancellationToken token)
        {
            return await _dbContext.ActivityTypes
                                   .Where(activityType => activityType.IsActive).ToListAsync(token);
        }

        public async Task<ActivityTypeEntity> GetActivityTypeByIdAsync(int activityTypeId, CancellationToken token)
        {
            return await _dbContext.ActivityTypes.FirstOrDefaultAsync(activityType => activityType.Id == activityTypeId && activityType.IsActive, token);
        }

        public async Task<ActivityTypeEntity> UpdateActivityTypeByIdAsync(ActivityTypeEntity activityTypeEntity, CancellationToken token)
        {
            _dbContext.ActivityTypes.Update(activityTypeEntity);
            await _dbContext.SaveChangesAsync(token);
            return activityTypeEntity;
        }

        public async Task DeleteActivityTypeByIdAsync(int activityTypeId, CancellationToken token)
        {
            var activityTypeEntity = await _dbContext.ActivityTypes.SingleAsync(activityType => activityType.Id == activityTypeId, token);
            activityTypeEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
