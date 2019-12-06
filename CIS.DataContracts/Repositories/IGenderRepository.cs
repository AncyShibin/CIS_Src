using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IGenderRepository
    {
        Task<GenderEntity> GetGenderByIdAsync(int id, CancellationToken token);

        Task<GenderEntity> CreateGenderAsync(GenderEntity genderEntity, CancellationToken token);

        Task<IEnumerable<GenderEntity>> GetGenderCIStAsync(CancellationToken token);

        Task<GenderEntity> UpdateGenderByIdAsync(GenderEntity genderEntity, CancellationToken token);

        Task DeleteGenderByIdAsync(int genderId, CancellationToken token);
    }
}
