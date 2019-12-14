using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Services
{
    public interface IMedicalRecordService
    {
        Task<MedicalRecordServiceObject> CreateMedicalRecordAsync(MedicalRecordServiceObject medicalRecorServiceObject, CancellationToken token);

        Task<IEnumerable<MedicalRecordServiceObject>> GetMedicalRecordListAsync(CancellationToken token);

        Task<MedicalRecordServiceObject> GetMedicalRecordByIdAsync(int medicalRecorId, CancellationToken token);

        Task<MedicalRecordServiceObject> UpdateMedicalRecordByIdAsync(MedicalRecordServiceObject medicalRecorServiceObject, CancellationToken token);

        Task DeleteMedicalRecordByIdAsync(int medicalRecorId, CancellationToken token);
    }
}
