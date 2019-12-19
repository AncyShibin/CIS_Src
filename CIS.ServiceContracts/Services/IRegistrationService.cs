using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IRegistrationService
    {
        Task<RegistrationServiceObject> CreateRegistrationAsync(RegistrationServiceObject registrationServiceObject, CancellationToken token);

        Task<IEnumerable<RegistrationServiceObject>> GetRegistrationListAsync(CancellationToken token);

        Task<RegistrationServiceObject> GetRegistrationByIdAsync(int registrationId, CancellationToken token);

        Task<RegistrationServiceObject> UpdateRegistrationByIdAsync(RegistrationServiceObject registrationServiceObject, CancellationToken token);

        Task DeleteRegistrationByIdAsync(int registrationId, CancellationToken token);
    }
}
