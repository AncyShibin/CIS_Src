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
    public sealed class RegistrationRepository : IRegistrationRepository
    {
        private readonly CISDbContext _dbContext;

        public RegistrationRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<RegistrationEntity> CreateRegistrationAsync(RegistrationEntity registrationEntity, CancellationToken token)
        {
            await _dbContext.Registrations.AddAsync(registrationEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.Registrations
                                .Include(x => x.Gender)
                                .SingleAsync(registration => registration.Id == registrationEntity.Id, token);
        }

        public async Task<IEnumerable<RegistrationEntity>> GetRegistrationListAsync(CancellationToken token)
        {
            return await _dbContext.Registrations
                                   .Include(x => x.Gender)
                                   .Where(registration => registration.IsActive).ToListAsync(token);
        }

        public async Task<RegistrationEntity> GetRegistrationByIdAsync(int registrationId, CancellationToken token)
        {
            return await _dbContext.Registrations
                                    .Include(x => x.Gender)
                                    .FirstOrDefaultAsync(registration => registration.Id == registrationId && registration.IsActive, token);
        }

        public async Task<RegistrationEntity> UpdateRegistrationByIdAsync(RegistrationEntity registrationEntity, CancellationToken token)
        {
            _dbContext.Registrations.Update(registrationEntity);
            await _dbContext.SaveChangesAsync(token);
            return registrationEntity;
        }

        public async Task DeleteRegistrationByIdAsync(int registrationId, CancellationToken token)
        {
            var registrationEntity = await _dbContext.Registrations
                                    .Include(x => x.Gender).
                                    SingleAsync(registration => registration.Id == registrationId, token);
            registrationEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
