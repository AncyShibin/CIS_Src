using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IFacilityAndActivityService
    {
        Task<FacilityAndActivityServiceObject> CreateFacilityAndActivityAsync(FacilityAndActivityServiceObject facilityAndActivityServiceObject, CancellationToken token);

        Task<IEnumerable<FacilityAndActivityServiceObject>> GetFacilityAndActivityListAsync(CancellationToken token);

        Task<FacilityAndActivityServiceObject> GetFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token);

        Task<FacilityAndActivityServiceObject> UpdateFacilityAndActivityByIdAsync(FacilityAndActivityServiceObject facilityAndActivityServiceObject, CancellationToken token);

        Task DeleteFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token);
    }
}
