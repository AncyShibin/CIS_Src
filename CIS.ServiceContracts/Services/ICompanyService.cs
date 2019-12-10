﻿using CIS.ServiceContracts.ServiceObjects;
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

        Task<CompanyServiceObject> GetCompanyByIdAsync(int companyId, CancellationToken token);

        Task<CompanyServiceObject> UpdateCompanyByIdAsync(CompanyServiceObject companyServiceObject, CancellationToken token);

        Task DeleteCompanyByIdAsync(int companyId, CancellationToken token);
    }
}
