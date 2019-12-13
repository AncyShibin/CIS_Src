using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IRegulatoryRepository
    {
        Task<RegulatoryEntity> CreateRegulatoryAsync(RegulatoryEntity regulatoryEntity, CancellationToken token);

        Task<IEnumerable<RegulatoryEntity>> GetRegulatoryListAsync(CancellationToken token);

        Task<RegulatoryEntity> GetRegulatoryByIdAsync(int regulatoryId, CancellationToken token);

        Task<RegulatoryEntity> UpdateRegulatoryByIdAsync(RegulatoryEntity regulatoryEntity, CancellationToken token);

        Task DeleteRegulatoryByIdAsync(int regulatoryId, CancellationToken token);
    }
}
