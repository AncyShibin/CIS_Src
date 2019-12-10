using AutoMapper;
using CIS.ServiceContracts.ServiceObjects;
using CIS.API.DataTransferObjects.Companies.Request;
using CIS.API.DataTransferObjects.Companies.Response;
using CIS.API.DataTransferObjects.Facilities.Request;
using CIS.API.DataTransferObjects.Facilities.Response;
using CIS.API.DataTransferObjects.VisitTypes.Response;
using CIS.API.DataTransferObjects.VisitTypes.Request;

namespace CIS.API.Configuration
{
    public sealed class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMapForCompanies();
            this.CreateMapForFacilities();
            this.CreateMapForVisitTypes();
        }     

        private void CreateMapForCompanies()
        {
            this.CreateMap<AddCompanyRequestDto, CompanyServiceObject>();
            this.CreateMap<CompanyServiceObject, AddCompanyResponseDto>();

            this.CreateMap<UpdateCompanyRequestDto, CompanyServiceObject>();
            this.CreateMap<CompanyServiceObject, UpdateCompanyResponseDto>();

            this.CreateMap<CompanyServiceObject, GetCompanyResponseDto>();
        }

        private void CreateMapForFacilities()
        {
            this.CreateMap<AddFacilityRequestDto, FacilityServiceObject>();
            this.CreateMap<FacilityServiceObject, AddFacilityResponseDto>();

            this.CreateMap<UpdateFacilityRequestDto, FacilityServiceObject>();
            this.CreateMap<FacilityServiceObject, UpdateFacilityResponseDto>();

            this.CreateMap<FacilityServiceObject, GetFacilityResponseDto>();
        }

        private void CreateMapForVisitTypes()
        {
            this.CreateMap<AddVisitTypeRequestDto, VisitTypeServiceObject>();
            this.CreateMap<VisitTypeServiceObject, AddVisitTypeResponseDto>();

            this.CreateMap<UpdateVisitTypeRequestDto, VisitTypeServiceObject>();
            this.CreateMap<VisitTypeServiceObject, UpdateVisitTypeResponseDto>();

            this.CreateMap<VisitTypeServiceObject, GetVisitTypeResponseDto>();
        }
    }
}