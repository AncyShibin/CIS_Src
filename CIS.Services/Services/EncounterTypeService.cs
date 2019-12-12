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
    public class EncounterTypeService : IEncounterTypeService
    {
        private readonly IEncounterTypeRepository _encounterTypeRepository;
        private readonly IMapper _mapper;

        public EncounterTypeService(
            IEncounterTypeRepository encounterTypeRepository,
            IMapper mapper)
        {
            _encounterTypeRepository = encounterTypeRepository;
            _mapper = mapper;
        }

        public async Task<EncounterTypeServiceObject> CreateEncounterTypeAsync(EncounterTypeServiceObject encounterTypeServiceObject, CancellationToken token)
        {
            var encounterTypeEntity = _mapper.Map<EncounterTypeEntity>(encounterTypeServiceObject);
            var createdEntity = await _encounterTypeRepository.CreateEncounterTypeAsync(encounterTypeEntity, token);
            return _mapper.Map<EncounterTypeServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<EncounterTypeServiceObject>> GetEncounterTypeListAsync(CancellationToken token)
        {
            var serviceResult = await _encounterTypeRepository.GetEncounterTypeListAsync(token);
            return _mapper.Map<IEnumerable<EncounterTypeServiceObject>>(serviceResult);
        }

        public async Task<EncounterTypeServiceObject> GetEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token)
        {
            var serviceResult = await _encounterTypeRepository.GetEncounterTypeByIdAsync(encounterTypeId, token);
            return _mapper.Map<EncounterTypeServiceObject>(serviceResult);
        }

        public async Task<EncounterTypeServiceObject> UpdateEncounterTypeByIdAsync(EncounterTypeServiceObject encounterTypeServiceObject, CancellationToken token)
        {
            var encounterTypeEntity = _mapper.Map<EncounterTypeEntity>(encounterTypeServiceObject);
            var updatedEntity = await _encounterTypeRepository.UpdateEncounterTypeByIdAsync(encounterTypeEntity, token);
            return _mapper.Map<EncounterTypeServiceObject>(updatedEntity);
        }

        public async Task DeleteEncounterTypeByIdAsync(int encounterTypeId, CancellationToken token)
        {
            await _encounterTypeRepository.DeleteEncounterTypeByIdAsync(encounterTypeId, token);
        }
    }
}
