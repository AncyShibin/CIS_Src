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
    public sealed class MedicalRecordRepository : IMedicalRecordRepository
    {
        private readonly CISDbContext _dbContext;

        public MedicalRecordRepository(CISDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<MedicalRecordEntity> CreateMedicalRecordAsync(MedicalRecordEntity medicalRecordEntity, CancellationToken token)
        {
            await _dbContext.MedicalRecords.AddAsync(medicalRecordEntity, token);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.MedicalRecords
                                .Include(x => x.Company)
                                .Include(x => x.Facility)
                                .Include(x => x.Encounter)
                                .Include(x => x.Regulatory)
                                .SingleAsync(medicalRecord => medicalRecord.Id == medicalRecordEntity.Id, token);
        }

        public async Task<IEnumerable<MedicalRecordEntity>> GetMedicalRecordListAsync(CancellationToken token)
        {
            return await _dbContext.MedicalRecords
                                .Include(x => x.Company)
                                .Include(x => x.Facility)
                                .Include(x => x.Encounter)
                                .Include(x => x.Regulatory)
                                .Where(medicalRecord => medicalRecord.IsActive).ToListAsync(token);
        }

        public async Task<MedicalRecordEntity> GetMedicalRecordByIdAsync(int medicalRecordId, CancellationToken token)
        {
            return await _dbContext.MedicalRecords
                                .Include(x => x.Company)
                                .Include(x => x.Facility)
                                .Include(x => x.Encounter)
                                .Include(x => x.Regulatory)
                                .FirstOrDefaultAsync(medicalRecord => medicalRecord.Id == medicalRecordId && medicalRecord.IsActive, token);
        }

        public async Task<MedicalRecordEntity> UpdateMedicalRecordByIdAsync(MedicalRecordEntity medicalRecordEntity, CancellationToken token)
        {
            _dbContext.MedicalRecords.Update(medicalRecordEntity);
            await _dbContext.SaveChangesAsync(token);
            return await _dbContext.MedicalRecords
                               .Include(x => x.Company)
                                .Include(x => x.Facility)
                                .Include(x => x.Encounter)
                                .Include(x => x.Regulatory)
                               .SingleAsync(medicalRecord => medicalRecord.Id == medicalRecordEntity.Id, token);
        }

        public async Task DeleteMedicalRecordByIdAsync(int medicalRecordId, CancellationToken token)
        {
            var medicalRecordEntity = await _dbContext.MedicalRecords.SingleAsync(medicalRecord => medicalRecord.Id == medicalRecordId, token);
            medicalRecordEntity.IsActive = false;
            await _dbContext.SaveChangesAsync(token);
        }
    }
}
