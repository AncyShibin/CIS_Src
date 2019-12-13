using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IRegulatoryService
    {
        Task<RegulatoryServiceObject> CreateRegulatoryAsync(RegulatoryServiceObject regulatoryServiceObject, CancellationToken token);

        Task<IEnumerable<RegulatoryServiceObject>> GetRegulatoryListAsync(CancellationToken token);

        Task<RegulatoryServiceObject> GetRegulatoryByIdAsync(int regulatoryId, CancellationToken token);

        Task<RegulatoryServiceObject> UpdateRegulatoryByIdAsync(RegulatoryServiceObject regulatoryServiceObject, CancellationToken token);

        Task DeleteRegulatoryByIdAsync(int regulatoryId, CancellationToken token);
    }
}
