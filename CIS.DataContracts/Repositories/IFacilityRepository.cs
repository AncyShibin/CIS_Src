using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IFacilityRepository
    {
        Task<FacilityEntity> CreateFacilityAsync(FacilityEntity facilityEntity, CancellationToken token);

        Task<IEnumerable<FacilityEntity>> GetFacilityListAsync(CancellationToken token);

        Task<FacilityEntity> GetFacilityByIdAsync(int facilityId, CancellationToken token);

        Task<FacilityEntity> UpdateFacilityByIdAsync(FacilityEntity facilityEntity, CancellationToken token);

        Task DeleteFacilityByIdAsync(int facilityId, CancellationToken token);
    }
}
