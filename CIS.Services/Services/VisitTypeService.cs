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
    public sealed class VisitTypeService : IVisitTypeService
    {
        private readonly IVisitTypeRepository _visitTypeRepository;
        private readonly IMapper _mapper;

        public VisitTypeService(
            IVisitTypeRepository visitTypeRepository,
            IMapper mapper)
        {
            _visitTypeRepository = visitTypeRepository;
            _mapper = mapper;
        }

        public async Task<VisitTypeServiceObject> CreateVisitTypeAsync(VisitTypeServiceObject visitTypeServiceObject, CancellationToken token)
        {
            var visitTypeEntity = _mapper.Map<VisitTypeEntity>(visitTypeServiceObject);
            var createdEntity = await _visitTypeRepository.CreateVisitTypeAsync(visitTypeEntity, token);
            return _mapper.Map<VisitTypeServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<VisitTypeServiceObject>> GetVisitTypeListAsync(CancellationToken token)
        {
            var serviceResult = await _visitTypeRepository.GetVisitTypeListAsync(token);
            return _mapper.Map<IEnumerable<VisitTypeServiceObject>>(serviceResult);
        }

        public async Task<VisitTypeServiceObject> GetVisitTypeByIdAsync(int visitTypeId, CancellationToken token)
        {
            var serviceResult = await _visitTypeRepository.GetVisitTypeByIdAsync(visitTypeId, token);
            return _mapper.Map<VisitTypeServiceObject>(serviceResult);
        }

        public async Task<VisitTypeServiceObject> UpdateVisitTypeByIdAsync(VisitTypeServiceObject visitTypeServiceObject, CancellationToken token)
        {
            var visitTypeEntity = _mapper.Map<VisitTypeEntity>(visitTypeServiceObject);
            var updatedEntity = await _visitTypeRepository.UpdateVisitTypeByIdAsync(visitTypeEntity, token);
            return _mapper.Map<VisitTypeServiceObject>(updatedEntity);
        }

        public async Task DeleteVisitTypeByIdAsync(int visitTypeId, CancellationToken token)
        {
            await _visitTypeRepository.DeleteVisitTypeByIdAsync(visitTypeId, token);
        }
    }
}
