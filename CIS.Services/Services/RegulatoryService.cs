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
    public sealed class RegulatoryService : IRegulatoryService
    {
        private readonly IRegulatoryRepository _regulatoryRepository;
        private readonly IMapper _mapper;

        public RegulatoryService(
            IRegulatoryRepository regulatoryRepository,
            IMapper mapper)
        {
            _regulatoryRepository = regulatoryRepository;
            _mapper = mapper;
        }

        public async Task<RegulatoryServiceObject> CreateRegulatoryAsync(RegulatoryServiceObject regulatoryServiceObject, CancellationToken token)
        {
            var regulatoryEntity = _mapper.Map<RegulatoryEntity>(regulatoryServiceObject);
            var createdEntity = await _regulatoryRepository.CreateRegulatoryAsync(regulatoryEntity, token);
            return _mapper.Map<RegulatoryServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<RegulatoryServiceObject>> GetRegulatoryListAsync(CancellationToken token)
        {
            var serviceResult = await _regulatoryRepository.GetRegulatoryListAsync(token);
            return _mapper.Map<IEnumerable<RegulatoryServiceObject>>(serviceResult);
        }

        public async Task<RegulatoryServiceObject> GetRegulatoryByIdAsync(int regulatoryId, CancellationToken token)
        {
            var serviceResult = await _regulatoryRepository.GetRegulatoryByIdAsync(regulatoryId, token);
            return _mapper.Map<RegulatoryServiceObject>(serviceResult);
        }

        public async Task<RegulatoryServiceObject> UpdateRegulatoryByIdAsync(RegulatoryServiceObject regulatoryServiceObject, CancellationToken token)
        {
            var regulatoryEntity = _mapper.Map<RegulatoryEntity>(regulatoryServiceObject);
            var updatedEntity = await _regulatoryRepository.UpdateRegulatoryByIdAsync(regulatoryEntity, token);
            return _mapper.Map<RegulatoryServiceObject>(updatedEntity);
        }

        public async Task DeleteRegulatoryByIdAsync(int regulatoryId, CancellationToken token)
        {
            await _regulatoryRepository.DeleteRegulatoryByIdAsync(regulatoryId, token);
        }
    }
}
