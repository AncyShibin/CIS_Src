using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IFacilityService
    {
        Task<FacilityServiceObject> CreateFacilityAsync(FacilityServiceObject facilityServiceObject, CancellationToken token);

        Task<IEnumerable<FacilityServiceObject>> GetFacilityListAsync(CancellationToken token);

        Task<FacilityServiceObject> GetFacilityByIdAsync(int facilityId, CancellationToken token);

        Task<FacilityServiceObject> UpdateFacilityByIdAsync(FacilityServiceObject facilityServiceObject, CancellationToken token);

        Task DeleteFacilityByIdAsync(int facilityId, CancellationToken token);
    }
}
