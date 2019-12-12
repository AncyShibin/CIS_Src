using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IActivityTypeRepository
    {
        Task<ActivityTypeEntity> CreateActivityTypeAsync(ActivityTypeEntity activityTypeEntity, CancellationToken token);

        Task<IEnumerable<ActivityTypeEntity>> GetActivityTypeListAsync(CancellationToken token);

        Task<ActivityTypeEntity> GetActivityTypeByIdAsync(int activityTypeId, CancellationToken token);

        Task<ActivityTypeEntity> UpdateActivityTypeByIdAsync(ActivityTypeEntity activityTypeEntity, CancellationToken token);

        Task DeleteActivityTypeByIdAsync(int activityTypeId, CancellationToken token);
    }
}
