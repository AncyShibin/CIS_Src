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
    public sealed class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(
            ICompanyRepository companyRepository,
            IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public async Task<CompanyServiceObject> CreateCompanyAsync(CompanyServiceObject companyServiceObject, CancellationToken token)
        {
            var companyEntity = _mapper.Map<CompanyEntity>(companyServiceObject);
            var createdEntity = await _companyRepository.CreateCompanyAsync(companyEntity, token);
            return _mapper.Map<CompanyServiceObject>(createdEntity);
        }

        public async Task<IEnumerable<CompanyServiceObject>> GetCompanyListAsync(CancellationToken token)
        {
            var serviceResult = await _companyRepository.GetCompanyListAsync(token);
            return _mapper.Map<IEnumerable<CompanyServiceObject>>(serviceResult);
        }

        public async Task<CompanyServiceObject> GetCompanyByIdAsync(int companyId, CancellationToken token)
        {
            var serviceResult = await _companyRepository.GetCompanyByIdAsync(companyId, token);
            return _mapper.Map<CompanyServiceObject>(serviceResult);
        }

        public async Task<CompanyServiceObject> UpdateCompanyByIdAsync(CompanyServiceObject companyServiceObject, CancellationToken token)
        {
            var companyEntity = _mapper.Map<CompanyEntity>(companyServiceObject);
            var updatedEntity = await _companyRepository.UpdateCompanyByIdAsync(companyEntity, token);
            return _mapper.Map<CompanyServiceObject>(updatedEntity);
        }

        public async Task DeleteCompanyByIdAsync(int companyId, CancellationToken token)
        {
            await _companyRepository.DeleteCompanyByIdAsync(companyId, token);
        }
    }
}
