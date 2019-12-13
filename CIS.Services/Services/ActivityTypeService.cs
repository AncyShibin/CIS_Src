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
    public sealed class ActivityTypeService : IActivityTypeService
    {
        private readonly IActivityTypeRepository _activityTypeRepository;
        private readonly IMapper _mapper;

        public ActivityTypeService(
            IActivityTypeRepository activityTypeRepository,
            IMapper mapper)
        {
            _activityTypeRepository = activityTypeRepository;
            _mapper = mapper;
        }

        public async Task<ActivityTypeServiceObject> CreateActivityTypeAsync(ActivityTypeServiceObject activityTypeServiceObject, CancellationToken token)
        {
            var activityTypeEntity = _mapper.Map<ActivityTypeEntity>(activityTypeServiceObject);
            var createdEntity = await _activityTypeRepository.CreateActivityTypeAsync(activityTypeEntity, token);
            return _mapper.Map<ActivityTypeServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<ActivityTypeServiceObject>> GetActivityTypeListAsync(CancellationToken token)
        {
            var serviceResult = await _activityTypeRepository.GetActivityTypeListAsync(token);
            return _mapper.Map<IEnumerable<ActivityTypeServiceObject>>(serviceResult);
        }

        public async Task<ActivityTypeServiceObject> GetActivityTypeByIdAsync(int activityTypeId, CancellationToken token)
        {
            var serviceResult = await _activityTypeRepository.GetActivityTypeByIdAsync(activityTypeId, token);
            return _mapper.Map<ActivityTypeServiceObject>(serviceResult);
        }

        public async Task<ActivityTypeServiceObject> UpdateActivityTypeByIdAsync(ActivityTypeServiceObject activityTypeServiceObject, CancellationToken token)
        {
            var activityTypeEntity = _mapper.Map<ActivityTypeEntity>(activityTypeServiceObject);
            var updatedEntity = await _activityTypeRepository.UpdateActivityTypeByIdAsync(activityTypeEntity, token);
            return _mapper.Map<ActivityTypeServiceObject>(updatedEntity);
        }

        public async Task DeleteActivityTypeByIdAsync(int activityTypeId, CancellationToken token)
        {
            await _activityTypeRepository.DeleteActivityTypeByIdAsync(activityTypeId, token);
        }
    }
}
