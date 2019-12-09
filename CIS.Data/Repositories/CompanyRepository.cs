using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.Data.Repositories
{
    public sealed class CompanyRepository : ICompanyRepository
    {
        private readonly CISDbContext _dbContext;

        public CompanyRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CompanyEntity> CreateCompanyAsync(CompanyEntity companyEntity, CancellationToken token)
        {
            await _dbContext.Companies.AddAsync(companyEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.Companies
                                .SingleAsync(company => company.Id == companyEntity.Id, token);
        }

        public async Task<IEnumerable<CompanyEntity>> GetCompanyListAsync(CancellationToken token)
        {
            return await _dbContext.Companies
                                   .Where(company => company.IsActive).ToListAsync(token);
        }
    }
}
