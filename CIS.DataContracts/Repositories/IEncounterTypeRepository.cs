using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IEncounterTypeRepository
    {
        Task<EncounterTypeEntity> CreateEncounterTypeAsync(EncounterTypeEntity encounterTypeEntity, CancellationToken token);

        Task<IEnumerable<EncounterTypeEntity>> GetEncounterTypeListAsync(CancellationToken token);

        Task<EncounterTypeEntity> GetEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token);

        Task<EncounterTypeEntity> UpdateEncounterTypeByIdAsync(EncounterTypeEntity encounterTypeEntity, CancellationToken token);

        Task DeleteEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token);
    }
}
