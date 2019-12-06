using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IGenderService
    {
        Task<GenderServiceObject> CreateGenderAsync(GenderServiceObject genderServiceObject, CancellationToken token);

        Task<GenderServiceObject> GetGenderByIdAsync(int genderId, CancellationToken token);

        Task<IEnumerable<GenderServiceObject>> GetGenderCIStAsync(CancellationToken token);

        Task<GenderServiceObject> UpdateGenderByIdAsync(GenderServiceObject genderServiceObject, CancellationToken token);

        Task DeleteGenderByIdAsync(int genderId, CancellationToken token);
    }
}
