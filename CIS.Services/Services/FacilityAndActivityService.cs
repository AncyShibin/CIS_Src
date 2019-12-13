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
    public sealed class FacilityAndActivityService : IFacilityAndActivityService
    {
        private readonly IFacilityAndActivityRepository _facilityAndActivityRepository;
        private readonly IMapper _mapper;

        public FacilityAndActivityService(
            IFacilityAndActivityRepository facilityAndActivityRepository,
            IMapper mapper)
        {
            _facilityAndActivityRepository = facilityAndActivityRepository;
            _mapper = mapper;
        }

        public async Task<FacilityAndActivityServiceObject> CreateFacilityAndActivityAsync(FacilityAndActivityServiceObject facilityAndActivityServiceObject, CancellationToken token)
        {
            var facilityAndActivityEntity = _mapper.Map<FacilityAndActivityEntity>(facilityAndActivityServiceObject);
            var createdEntity = await _facilityAndActivityRepository.CreateFacilityAndActivityAsync(facilityAndActivityEntity, token);
            return _mapper.Map<FacilityAndActivityServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<FacilityAndActivityServiceObject>> GetFacilityAndActivityListAsync(CancellationToken token)
        {
            var serviceResult = await _facilityAndActivityRepository.GetFacilityAndActivityListAsync(token);
            return _mapper.Map<IEnumerable<FacilityAndActivityServiceObject>>(serviceResult);
        }

        public async Task<FacilityAndActivityServiceObject> GetFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token)
        {
            var serviceResult = await _facilityAndActivityRepository.GetFacilityAndActivityByIdAsync(facilityAndActivityId, token);
            return _mapper.Map<FacilityAndActivityServiceObject>(serviceResult);
        }

        public async Task<FacilityAndActivityServiceObject> UpdateFacilityAndActivityByIdAsync(FacilityAndActivityServiceObject facilityAndActivityServiceObject, CancellationToken token)
        {
            var facilityAndActivityEntity = _mapper.Map<FacilityAndActivityEntity>(facilityAndActivityServiceObject);
            var updatedEntity = await _facilityAndActivityRepository.UpdateFacilityAndActivityByIdAsync(facilityAndActivityEntity, token);
            return _mapper.Map<FacilityAndActivityServiceObject>(updatedEntity);
        }

        public async Task DeleteFacilityAndActivityByIdAsync(int facilityAndActivityId, CancellationToken token)
        {
            await _facilityAndActivityRepository.DeleteFacilityAndActivityByIdAsync(facilityAndActivityId, token);
        }
    }
}
