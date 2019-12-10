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
    public sealed class FacilityService : IFacilityService
    {
        private readonly IFacilityRepository _facilityRepository;
        private readonly IMapper _mapper;

        public FacilityService(
            IFacilityRepository facilityRepository,
            IMapper mapper)
        {
            _facilityRepository = facilityRepository;
            _mapper = mapper;
        }

        public async Task<FacilityServiceObject> CreateFacilityAsync(FacilityServiceObject facilityServiceObject, CancellationToken token)
        {
            var facilityEntity = _mapper.Map<FacilityEntity>(facilityServiceObject);
            var createdEntity = await _facilityRepository.CreateFacilityAsync(facilityEntity, token);
            return _mapper.Map<FacilityServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<FacilityServiceObject>> GetFacilityListAsync(CancellationToken token)
        {
            var serviceResult = await _facilityRepository.GetFacilityListAsync(token);
            return _mapper.Map<IEnumerable<FacilityServiceObject>>(serviceResult);
        }

        public async Task<FacilityServiceObject> GetFacilityByIdAsync(int facilityId, CancellationToken token)
        {
            var serviceResult = await _facilityRepository.GetFacilityByIdAsync(facilityId, token);
            return _mapper.Map<FacilityServiceObject>(serviceResult);
        }

        public async Task<FacilityServiceObject> UpdateFacilityByIdAsync(FacilityServiceObject facilityServiceObject, CancellationToken token)
        {
            var facilityEntity = _mapper.Map<FacilityEntity>(facilityServiceObject);
            var updatedEntity = await _facilityRepository.UpdateFacilityByIdAsync(facilityEntity, token);
            return _mapper.Map<FacilityServiceObject>(updatedEntity);
        }

        public async Task DeleteFacilityByIdAsync(int facilityId, CancellationToken token)
        {
            await _facilityRepository.DeleteFacilityByIdAsync(facilityId, token);
        }
    }
}
