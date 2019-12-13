using System;
using AutoMapper;
using CIS.DataContracts.Entities;
using CIS.ServiceContracts.ServiceObjects;

namespace CIS.Services.Configuration
{
    public sealed class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMapForCompanies();
            this.CreateMapForFacilities();
            this.CreateMapForVisitTypes();
            this.CreateMapForRegulatory();
        }

        private void CreateMapForCompanies()
        {
            this.CreateMap<CompanyServiceObject, CompanyEntity>()
                .ForMember(companyEntity => companyEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(companyEntity => companyEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<CompanyEntity, CompanyServiceObject>();
        }

        private void CreateMapForFacilities()
        {
            this.CreateMap<FacilityServiceObject, FacilityEntity>()
                .ForMember(facilityEntity => facilityEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(facilityEntity => facilityEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<FacilityEntity, FacilityServiceObject>();
        }

        private void CreateMapForVisitTypes()
        {
            this.CreateMap<VisitTypeServiceObject, VisitTypeEntity>()
                .ForMember(visitTypeEntity => visitTypeEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(visitTypeEntity => visitTypeEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<VisitTypeEntity, VisitTypeServiceObject>();
        }

        private void CreateMapForRegulatory()
        {
            this.CreateMap<RegulatoryServiceObject, RegulatoryEntity>()
                .ForMember(regulatoryEntity => regulatoryEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(regulatoryEntity => regulatoryEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<RegulatoryEntity, RegulatoryServiceObject>();
        }
    }
}