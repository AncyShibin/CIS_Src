using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IVisitTypeService
    {
        Task<VisitTypeServiceObject> CreateVisitTypeAsync(VisitTypeServiceObject visitTypeServiceObject, CancellationToken token);

        Task<IEnumerable<VisitTypeServiceObject>> GetVisitTypeListAsync(CancellationToken token);

        Task<VisitTypeServiceObject> GetVisitTypeByIdAsync(int visitTypeId, CancellationToken token);

        Task<VisitTypeServiceObject> UpdateVisitTypeByIdAsync(VisitTypeServiceObject visitTypeServiceObject, CancellationToken token);

        Task DeleteVisitTypeByIdAsync(int visitTypeId, CancellationToken token);
    }
}
