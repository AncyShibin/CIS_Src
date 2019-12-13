using AutoMapper;
using CIS.ServiceContracts.ServiceObjects;
using CIS.API.DataTransferObjects.Companies.Request;
using CIS.API.DataTransferObjects.Companies.Response;
using CIS.API.DataTransferObjects.Facilities.Request;
using CIS.API.DataTransferObjects.Facilities.Response;
using CIS.API.DataTransferObjects.VisitTypes.Response;
using CIS.API.DataTransferObjects.VisitTypes.Request;
using CIS.API.DataTransferObjects.Regulatory.Response;
using CIS.API.DataTransferObjects.Regulatory.Request;
using CIS.API.DataTransferObjects.EncounterType.Request;
using CIS.API.DataTransferObjects.EncounterType.Response;
using CIS.API.DataTransferObjects.ActivityTypes.Request;
using CIS.API.DataTransferObjects.ActivityTypes.Response;
using CIS.API.DataTransferObjects.FacilityAndActivity.Request;
using CIS.API.DataTransferObjects.FacilityAndActivity.Response;

namespace CIS.API.Configuration
{
    public sealed class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMapForCompanies();
            this.CreateMapForFacilities();
            this.CreateMapForVisitTypes();
            this.CreateMapForRegulatories();
            this.CreateMapForEncounterTypes();
            this.CreateMapForActivityTypes();
            this.CreateMapForFacilityAndActivities();
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
            this.CreateMap<VisitTypeServiceObject, AddVisitTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<UpdateVisitTypeRequestDto, VisitTypeServiceObject>();
            this.CreateMap<VisitTypeServiceObject, UpdateVisitTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<VisitTypeServiceObject, GetVisitTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));
        }
        private void CreateMapForRegulatories()
        {
            this.CreateMap<AddRegulatoryRequestDto, RegulatoryServiceObject>();
            this.CreateMap<RegulatoryServiceObject, AddRegulatoryResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<UpdateRegulatoryRequestDto, RegulatoryServiceObject>();
            this.CreateMap<RegulatoryServiceObject, UpdateRegulatoryResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<RegulatoryServiceObject, GetRegulatoryResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));
                }
        private void CreateMapForEncounterTypes()
        {
            this.CreateMap<AddEncounterTypeRequestDto, EncounterTypeServiceObject>();
            this.CreateMap<EncounterTypeServiceObject, AddEncounterTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<UpdateEncounterTypeRequestDto, EncounterTypeServiceObject>();
            this.CreateMap<EncounterTypeServiceObject, UpdateEncounterTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<EncounterTypeServiceObject, GetEncounterTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));
}

        private void CreateMapForActivityTypes()
        {
            this.CreateMap<AddActivityTypeRequestDto, ActivityTypeServiceObject>();
            this.CreateMap<ActivityTypeServiceObject, AddActivityTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<UpdateActivityTypeRequestDto, ActivityTypeServiceObject>();
            this.CreateMap<ActivityTypeServiceObject, UpdateActivityTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<ActivityTypeServiceObject, GetActivityTypeResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));
        }

        private void CreateMapForFacilityAndActivities()
        {
            this.CreateMap<AddFacilityAndActivityRequestDto, FacilityAndActivityServiceObject>();
            this.CreateMap<FacilityAndActivityServiceObject, AddFacilityAndActivityResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<UpdateFacilityAndActivityRequestDto, FacilityAndActivityServiceObject>();
            this.CreateMap<FacilityAndActivityServiceObject, UpdateFacilityAndActivityResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<FacilityAndActivityServiceObject, GetFacilityAndActivityResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<FacilityServiceObject, FacilityResponseDto>();
            this.CreateMap<ActivityTypeServiceObject, ActivityResponseDto>();
        }
    }
}