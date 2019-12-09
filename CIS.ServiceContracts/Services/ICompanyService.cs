using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CIS.ServiceContracts.Services
{
    public interface ICompanyService
    {
        Task<CompanyServiceObject> CreateCompanyAsync(CompanyServiceObject companyServiceObject, CancellationToken token);

        Task<IEnumerable<CompanyServiceObject>> GetCompanyListAsync(CancellationToken token);
    }
}
