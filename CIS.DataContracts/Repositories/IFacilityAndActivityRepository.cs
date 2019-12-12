using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IFacilityAndActivityRepository
    {
        Task<FacilityAndActivityEntity> CreateFacilityAndActivityAsync(FacilityAndActivityEntity facilityAndActivityEntity, CancellationToken token);

        Task<IEnumerable<FacilityAndActivityEntity>> GetFacilityAndActivityListAsync(CancellationToken token);

        Task<FacilityAndActivityEntity> GetFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token);

        Task<FacilityAndActivityEntity> UpdateFacilityAndActivityByIdAsync(FacilityAndActivityEntity facilityAndActivityEntity, CancellationToken token);

        Task DeleteFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token);
    }
}
