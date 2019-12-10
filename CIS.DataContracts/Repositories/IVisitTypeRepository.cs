using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IVisitTypeRepository
    {
        Task<VisitTypeEntity> CreateVisitTypeAsync(VisitTypeEntity visitTypeEntity, CancellationToken token);

        Task<IEnumerable<VisitTypeEntity>> GetVisitTypeListAsync(CancellationToken token);

        Task<VisitTypeEntity> GetVisitTypeByIdAsync(int visitTypeId, CancellationToken token);

        Task<VisitTypeEntity> UpdateVisitTypeByIdAsync(VisitTypeEntity visitTypeEntity, CancellationToken token);

        Task DeleteVisitTypeByIdAsync(int visitTypeId, CancellationToken token);
    }
}
