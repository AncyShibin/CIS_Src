using CIS.DataContracts.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.DataContracts.Repositories
{
    public interface IMedicalRecordRepository
    {
        Task<MedicalRecordEntity> CreateMedicalRecordAsync(MedicalRecordEntity medicalRecordEntity, CancellationToken token);

        Task<IEnumerable<MedicalRecordEntity>> GetMedicalRecordListAsync(CancellationToken token);

        Task<MedicalRecordEntity> GetMedicalRecordByIdAsync(int medicalRecordId, CancellationToken token);

        Task<MedicalRecordEntity> UpdateMedicalRecordByIdAsync(MedicalRecordEntity medicalRecordEntity, CancellationToken token);

        Task DeleteMedicalRecordByIdAsync(int medicalRecordId, CancellationToken token);
    }
}
