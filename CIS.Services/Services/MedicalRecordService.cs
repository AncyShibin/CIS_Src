using AutoMapper;
using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using CIS.ServiceContracts.ServiceObjects;
using CIS.ServiceContracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.Services.Services
{
    public sealed class MedicalRecordService : IMedicalRecordService
    {
        private readonly IMedicalRecordRepository _medicalRecordRepository;
        private readonly IMapper _mapper;

        public MedicalRecordService(
            IMedicalRecordRepository medicalRecordRepository,
            IMapper mapper)
        {
            _medicalRecordRepository = medicalRecordRepository;
            _mapper = mapper;
        }

        public async Task<MedicalRecordServiceObject> CreateMedicalRecordAsync(MedicalRecordServiceObject medicalRecordServiceObject, CancellationToken token)
        {
            var medicalRecordEntity = _mapper.Map<MedicalRecordEntity>(medicalRecordServiceObject);
            var createdEntity = await _medicalRecordRepository.CreateMedicalRecordAsync(medicalRecordEntity, token);
            return _mapper.Map<MedicalRecordServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<MedicalRecordServiceObject>> GetMedicalRecordListAsync(CancellationToken token)
        {
            var serviceResult = await _medicalRecordRepository.GetMedicalRecordListAsync(token);
            return _mapper.Map<IEnumerable<MedicalRecordServiceObject>>(serviceResult);
        }

        public async Task<MedicalRecordServiceObject> GetMedicalRecordByIdAsync(int medicalRecordId, CancellationToken token)
        {
            var serviceResult = await _medicalRecordRepository.GetMedicalRecordByIdAsync(medicalRecordId, token);
            return _mapper.Map<MedicalRecordServiceObject>(serviceResult);
        }

        public async Task<MedicalRecordServiceObject> UpdateMedicalRecordByIdAsync(MedicalRecordServiceObject medicalRecordServiceObject, CancellationToken token)
        {
            var medicalRecordEntity = _mapper.Map<MedicalRecordEntity>(medicalRecordServiceObject);
            var updatedEntity = await _medicalRecordRepository.UpdateMedicalRecordByIdAsync(medicalRecordEntity, token);
            return _mapper.Map<MedicalRecordServiceObject>(updatedEntity);
        }

        public async Task DeleteMedicalRecordByIdAsync(int medicalRecordId, CancellationToken token)
        {
            await _medicalRecordRepository.DeleteMedicalRecordByIdAsync(medicalRecordId, token);
        }
    }
}
