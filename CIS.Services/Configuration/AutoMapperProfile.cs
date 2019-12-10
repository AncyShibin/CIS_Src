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
            this.CreateMapForDepartments();
            this.CreateMapForGender();

            this.CreateMapForPatients();
            this.CreateMapForAppointments();

            this.CreateMapForCompanies();

            this.CreateMapForFacilities();

            this.CreateMapForVisitTypes();
        }

        private void CreateMapForDepartments()
        {
            this.CreateMap<DepartmentServiceObject, DepartmentEntity>()
                .ForMember(departmentEntity => departmentEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(departmentEntity => departmentEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));
            this.CreateMap<DepartmentEntity, DepartmentServiceObject>();
        }

        private void CreateMapForGender()
        {
            this.CreateMap<GenderServiceObject, GenderEntity>()
                .ForMember(genderEntity => genderEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(genderEntity => genderEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));
            this.CreateMap<GenderEntity, GenderServiceObject>();
        }

        private void CreateMapForPatients()
        {
            this.CreateMap<UserServiceObject, UserEntity>()
                .ForMember(patientEntity => patientEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(patientEntity => patientEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<UserEntity, UserServiceObject>();
        }

        private void CreateMapForAppointments()
        {
            this.CreateMap<AppointmentServiceObject, AppointmentEntity>()
                .ForMember(aapointmentEntity => aapointmentEntity.IsActive, opt => opt.MapFrom(x => true))
                .ForMember(aapointmentEntity => aapointmentEntity.ModifiedOn, opt => opt.MapFrom(x => DateTime.UtcNow));

            this.CreateMap<AppointmentEntity, AppointmentServiceObject>();

            this.CreateMap<AppointmentStatusEntity, AppointmentStatusServiceObject>();
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
    }
}