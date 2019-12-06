using AutoMapper;
using CIS.DataContracts.Entities;
using CIS.DataContracts.Repositories;
using CIS.ServiceContracts.ServiceObjects;
using CIS.ServiceContracts.Services;
using CIS.ServiceContracts.Validations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.Services.Services
{
    public sealed class PatientsService : IPatientsService
    {
        private readonly IMapper _mapper;
        private readonly ICreatePatientValidationService _createPatientValidationService;
        private readonly IPatientRepository _patientRepository;

        public PatientsService(
            IPatientRepository patientRepository,
            ICreatePatientValidationService createPatientValidationService,
            IMapper mapper)
        {
            _patientRepository = patientRepository;
            _createPatientValidationService = createPatientValidationService;
            _mapper = mapper;
        }

        public async Task<UserServiceObject> CreatePatientAsync(UserServiceObject patientServiceObject, CancellationToken token)
        {
            await _createPatientValidationService.Validate(patientServiceObject, token);
            var patientEntity = _mapper.Map<UserEntity>(patientServiceObject);
            var createdEntity = await _patientRepository.CreatePatientAsync(patientEntity, token);
            return _mapper.Map<UserServiceObject>(createdEntity);
        }

        public async Task<UserServiceObject> GetPatientByIdAsync(int patientId, CancellationToken token)
        {
            var serviceResult = await _patientRepository.GetPatientByIdAsync(patientId, token);
            return _mapper.Map<UserServiceObject>(serviceResult);
        }

        public async Task<IEnumerable<UserServiceObject>> SearchPatientAsync(string searchQuery, CancellationToken token)
        {
            var serviceResult = await _patientRepository.SearchPatientAsync(searchQuery, token);
            return _mapper.Map<IEnumerable<UserServiceObject>>(serviceResult);
        }
    }
}
