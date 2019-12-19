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
    public sealed class RegistrationService : IRegistrationService
    {
        private readonly IRegistrationRepository _registrationRepository;
        private readonly IMapper _mapper;

        public RegistrationService(
            IRegistrationRepository registrationRepository,
            IMapper mapper)
        {
            _registrationRepository = registrationRepository;
            _mapper = mapper;
        }
        public async Task<RegistrationServiceObject> CreateRegistrationAsync(RegistrationServiceObject registrationServiceObject, CancellationToken token)
        {
            var registrationEntity = _mapper.Map<RegistrationEntity>(registrationServiceObject);
            var createdEntity = await _registrationRepository.CreateRegistrationAsync(registrationEntity, token);
            return _mapper.Map<RegistrationServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<RegistrationServiceObject>> GetRegistrationListAsync(CancellationToken token)
        {
            var serviceResult = await _registrationRepository.GetRegistrationListAsync(token);
            return _mapper.Map<IEnumerable<RegistrationServiceObject>>(serviceResult);
        }

        public async Task<RegistrationServiceObject> GetRegistrationByIdAsync(int registrationId, CancellationToken token)
        {
            var serviceResult = await _registrationRepository.GetRegistrationByIdAsync(registrationId, token);
            return _mapper.Map<RegistrationServiceObject>(serviceResult);
        }

        public async Task<RegistrationServiceObject> UpdateRegistrationByIdAsync(RegistrationServiceObject registrationServiceObject, CancellationToken token)
        {
            var registrationEntity = _mapper.Map<RegistrationEntity>(registrationServiceObject);
            var updatedEntity = await _registrationRepository.UpdateRegistrationByIdAsync(registrationEntity, token);
            return _mapper.Map<RegistrationServiceObject>(updatedEntity);
        }

        public async Task DeleteRegistrationByIdAsync(int registrationId, CancellationToken token)
        {
            await _registrationRepository.DeleteRegistrationByIdAsync(registrationId, token);
        }
    }
}
