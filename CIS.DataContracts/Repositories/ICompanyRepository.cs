using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface ICompanyRepository
    {
        Task<CompanyEntity> CreateCompanyAsync(CompanyEntity companyEntity, CancellationToken token);

        Task<IEnumerable<CompanyEntity>> GetCompanyListAsync(CancellationToken token);
    }
}
