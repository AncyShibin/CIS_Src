using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IEncounterTypeService
    {
        Task<EncounterTypeServiceObject> CreateEncounterTypeAsync(EncounterTypeServiceObject encounterTypeServiceObject, CancellationToken token);

        Task<IEnumerable<EncounterTypeServiceObject>> GetEncounterTypeListAsync(CancellationToken token);

        Task<EncounterTypeServiceObject> GetEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token);

        Task<EncounterTypeServiceObject> UpdateEncounterTypeByIdAsync(EncounterTypeServiceObject encounterTypeServiceObject, CancellationToken token);

        Task DeleteEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token);
    }
}
