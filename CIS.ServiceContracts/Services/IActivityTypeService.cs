using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IActivityTypeService
    {
        Task<ActivityTypeServiceObject> CreateActivityTypeAsync(ActivityTypeServiceObject activityTypeServiceObject, CancellationToken token);

        Task<IEnumerable<ActivityTypeServiceObject>> GetActivityTypeListAsync(CancellationToken token);

        Task<ActivityTypeServiceObject> GetActivityTypeByIdAsync(int activityTypeId, CancellationToken token);

        Task<ActivityTypeServiceObject> UpdateActivityTypeByIdAsync(ActivityTypeServiceObject activityTypeServiceObject, CancellationToken token);

        Task DeleteActivityTypeByIdAsync(int activityTypeId, CancellationToken token);
    }
}
