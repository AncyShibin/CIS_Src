using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IRegistrationRepository
    {
        Task<RegistrationEntity> CreateRegistrationAsync(RegistrationEntity registrationEntity, CancellationToken token);

        Task<IEnumerable<RegistrationEntity>> GetRegistrationListAsync(CancellationToken token);

        Task<RegistrationEntity> GetRegistrationByIdAsync(int registrationId, CancellationToken token);

        Task<RegistrationEntity> UpdateRegistrationByIdAsync(RegistrationEntity registrationEntity, CancellationToken token);

        Task DeleteRegistrationByIdAsync(int registrationId, CancellationToken token);
    }
}
