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
            this.CreateMapForRegulatories();
            this.CreateMapForEncounterTypes();
            this.CreateMapForActivityTypes();
            this.CreateMapForFacilityAndActivities();
            this.CreateMapForMedicalRecords();
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

        private void CreateMapForRegulatories()
        {
            this.CreateMap<RegulatoryServiceObject, RegulatoryEntity>()
                .ForMember(regulatoryEntity => regulatoryEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(regulatoryEntity => regulatoryEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<RegulatoryEntity, RegulatoryServiceObject>();
            }
        private void CreateMapForEncounterTypes()
        {
            this.CreateMap<EncounterTypeServiceObject, EncounterTypeEntity>()
                .ForMember(encounterTypeEntity => encounterTypeEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(encounterTypeEntity => encounterTypeEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<EncounterTypeEntity, EncounterTypeServiceObject>();
            }

        private void CreateMapForActivityTypes()
        {
            this.CreateMap<ActivityTypeServiceObject, ActivityTypeEntity>()
                .ForMember(activityTypeEntity => activityTypeEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(activityTypeEntity => activityTypeEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<ActivityTypeEntity, ActivityTypeServiceObject>();
        }

        private void CreateMapForFacilityAndActivities()
        {
            this.CreateMap<FacilityAndActivityServiceObject, FacilityAndActivityEntity>()
                .ForMember(facilityAndActivityEntity => facilityAndActivityEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(facilityAndActivityEntity => facilityAndActivityEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<FacilityAndActivityEntity, FacilityAndActivityServiceObject>();
        }
        private void CreateMapForMedicalRecords()
        {
            this.CreateMap<MedicalRecordServiceObject, MedicalRecordEntity>()
                .ForMember(medicalRecordEntity => medicalRecordEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(medicalRecordEntity => medicalRecordEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<MedicalRecordEntity, MedicalRecordServiceObject>();
        }
    }
}