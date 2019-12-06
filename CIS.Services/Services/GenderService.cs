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
    public sealed class GenderService:IGenderService
    {
        private readonly IGenderRepository _genderRepository;

        private readonly IMapper _mapper;
        public GenderService(
           IGenderRepository genderRepository,
           IMapper mapper)
        {
            _genderRepository = genderRepository;
            _mapper = mapper;
        }
        public async Task<GenderServiceObject> CreateGenderAsync(GenderServiceObject genderServiceObject, CancellationToken token)
        {
            var genderEntity = _mapper.Map<GenderEntity>(genderServiceObject);
            var createdEntity = await _genderRepository.CreateGenderAsync(genderEntity, token);
            return _mapper.Map<GenderServiceObject>(createdEntity);
        }
        public async Task<GenderServiceObject> GetGenderByIdAsync(int genderId, CancellationToken token)
        {
            var genderEntity = await _genderRepository.GetGenderByIdAsync(genderId, token);
            return _mapper.Map<GenderServiceObject>(genderEntity);
        }
        public async Task<IEnumerable<GenderServiceObject>> GetGenderCIStAsync(CancellationToken token)
        {
            var serviceResult = await _genderRepository.GetGenderCIStAsync(token);
            return _mapper.Map<IEnumerable<GenderServiceObject>>(serviceResult);
        }
        public async Task<GenderServiceObject> UpdateGenderByIdAsync(GenderServiceObject genderServiceObject, CancellationToken token)
        {
            var genderEntity = _mapper.Map<GenderEntity>(genderServiceObject);
            var updatedEntity = await _genderRepository.UpdateGenderByIdAsync(genderEntity, token);
            return _mapper.Map<GenderServiceObject>(updatedEntity);
        }
        public async Task DeleteGenderByIdAsync(int genderId, CancellationToken token)
        {
            await _genderRepository.DeleteGenderByIdAsync(genderId, token);
        }
    }
}
