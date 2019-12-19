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
using CIS.API.DataTransferObjects.MedicalRecord.Request;
using CIS.API.DataTransferObjects.MedicalRecord.Response;
using CIS.API.DataTransferObjects.Appointment.Request;
using CIS.API.DataTransferObjects.Appointment.Response;
using CIS.API.DataTransferObjects.Registration.Request;
using CIS.API.DataTransferObjects.Registration.Response;

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
            this.CreateMapForMedicalRecords();
            this.CreateMapForAppointments();
            this.CreateMapForRegistrations();
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
        private void CreateMapForMedicalRecords()
        {
            this.CreateMap<AddMedicalRecordRequestDto, MedicalRecordServiceObject>();
            this.CreateMap<MedicalRecordServiceObject, AddMedicalRecordResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<UpdateMedicalRecordRequestDto, MedicalRecordServiceObject>();
            this.CreateMap<MedicalRecordServiceObject, UpdateMedicalRecordResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<MedicalRecordServiceObject, GetMedicalRecordResponseDto>()
                .ForMember(dto => dto.Status, opt => opt.MapFrom(so => so.IsActive));

            this.CreateMap<FacilityServiceObject, FacilitiesResponseDto>();
            this.CreateMap<CompanyServiceObject, CompanyResponseDto>();
            this.CreateMap<EncounterTypeServiceObject, EncounterResponseDto>();
            this.CreateMap<RegulatoryServiceObject, RegulatoryResponseDto>();
        }
        private void CreateMapForAppointments()
        {
            this.CreateMap<AddAppointmentRequestDto, AppointmentServiceObject>()
                .ForMember(so => so.POBox, opt => opt.MapFrom(dto => dto.Address.POBox))
                .ForMember(so => so.Area, opt => opt.MapFrom(dto => dto.Address.Area))
                .ForMember(so => so.City, opt => opt.MapFrom(dto => dto.Address.City))
                .ForMember(so => so.Country, opt => opt.MapFrom(dto => dto.Address.Country))
                .ForMember(so => so.Schedule, opt => opt.MapFrom(dto => dto.Schedule.ScheduledDate))
                .ForMember(so => so.Comment, opt => opt.MapFrom(dto => dto.Comment.Comment));
              
            this.CreateMap<AppointmentServiceObject, AddAppointmentResponseDto>()
                .ForMember(dto => dto.Address, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Schedule, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Comment, opt => opt.MapFrom(so => so));

            this.CreateMap<UpdateAppointmentRequestDto, AppointmentServiceObject>()
                .ForMember(so => so.POBox, opt => opt.MapFrom(dto => dto.Address.POBox))
                .ForMember(so => so.Area, opt => opt.MapFrom(dto => dto.Address.Area))
                .ForMember(so => so.City, opt => opt.MapFrom(dto => dto.Address.City))
                .ForMember(so => so.Country, opt => opt.MapFrom(dto => dto.Address.Country))
                .ForMember(so => so.Schedule, opt => opt.MapFrom(dto => dto.Schedule.ScheduledDate))
                .ForMember(so => so.Comment, opt => opt.MapFrom(dto => dto.Comment.Comment));

            this.CreateMap<AppointmentServiceObject, UpdateAppointmentResponseDto>()
                .ForMember(dto => dto.Address, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Schedule, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Comment, opt => opt.MapFrom(so => so));

            this.CreateMap<AppointmentServiceObject, GetAppointmentResponseDto>()
                .ForMember(dto => dto.Address, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Schedule, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Comment, opt => opt.MapFrom(so => so));

            this.CreateMap<AppointmentServiceObject, AddAddressInformationResponseDto>();
            this.CreateMap<AppointmentServiceObject, AddScheduleInformationResponseDto>();
            this.CreateMap<AppointmentServiceObject, AddCommentResponseDto>();
            this.CreateMap<AppointmentServiceObject, GetAddressInformationResponseDto>();
            this.CreateMap<AppointmentServiceObject, GetScheduleInformationResponseDto>();
            this.CreateMap<AppointmentServiceObject, GetCommentResponseDto>();
            this.CreateMap<AppointmentServiceObject, UpdateAddressInformationResponseDto>();
            this.CreateMap<AppointmentServiceObject, UpdateScheduleInformationResponseDto>();
            this.CreateMap<AppointmentServiceObject, UpdateCommentResponseDto>();

            this.CreateMap<GenderServiceObject, AddGenderDto>();
            this.CreateMap<GenderServiceObject, GetGenderDto>();
            this.CreateMap<GenderServiceObject, UpdateGenderDto>();
        }

        private void CreateMapForRegistrations()
        {
            this.CreateMap<AddRegistrationRequestDto, RegistrationServiceObject>()
                .ForMember(so => so.Organization, opt => opt.MapFrom(dto => dto.Referral.Organization))
                .ForMember(so => so.Physician, opt => opt.MapFrom(dto => dto.Referral.Physician))
                .ForMember(so => so.MemberNumber, opt => opt.MapFrom(dto => dto.Insurance.MemberNumber))
                .ForMember(so => so.EmployeeNumber, opt => opt.MapFrom(dto => dto.Insurance.EmployeeNumber))
                .ForMember(so => so.Validity, opt => opt.MapFrom(dto => dto.Insurance.Validity))
                .ForMember(so => so.Network, opt => opt.MapFrom(dto => dto.Insurance.Network))
                .ForMember(so => so.SubNetwork, opt => opt.MapFrom(dto => dto.Insurance.SubNetwork));

            this.CreateMap<RegistrationServiceObject, AddRegistrationResponseDto>()
                .ForMember(dto => dto.Referral, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Insurance, opt => opt.MapFrom(so => so));

            this.CreateMap<UpdateRegistrationRequestDto, RegistrationServiceObject>()
               .ForMember(so => so.Organization, opt => opt.MapFrom(dto => dto.Referral.Organization))
                .ForMember(so => so.Physician, opt => opt.MapFrom(dto => dto.Referral.Physician))
                .ForMember(so => so.MemberNumber, opt => opt.MapFrom(dto => dto.Insurance.MemberNumber))
                .ForMember(so => so.EmployeeNumber, opt => opt.MapFrom(dto => dto.Insurance.EmployeeNumber))
                .ForMember(so => so.Validity, opt => opt.MapFrom(dto => dto.Insurance.Validity))
                .ForMember(so => so.Network, opt => opt.MapFrom(dto => dto.Insurance.Network))
                .ForMember(so => so.SubNetwork, opt => opt.MapFrom(dto => dto.Insurance.SubNetwork));

            this.CreateMap<RegistrationServiceObject, UpdateRegistrationResponseDto>()
                .ForMember(dto => dto.Referral, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Insurance, opt => opt.MapFrom(so => so));

            this.CreateMap<RegistrationServiceObject, GetRegistrationResponseDto>()
               .ForMember(dto => dto.Referral, opt => opt.MapFrom(so => so))
                .ForMember(dto => dto.Insurance, opt => opt.MapFrom(so => so));

            this.CreateMap<RegistrationServiceObject, AddReferralInformationRequestDto>();
            this.CreateMap<RegistrationServiceObject, AddInsuranceDetailsRequestDto>();
            this.CreateMap<RegistrationServiceObject, GetReferralInformationResponseDto>();
            this.CreateMap<RegistrationServiceObject, GetInsuranceDetailsResponseDto>();
            this.CreateMap<RegistrationServiceObject, UpdateReferralInformationResponseDto>();
            this.CreateMap<RegistrationServiceObject, UpdateInsuranceDetailsRequestDto>();

            this.CreateMap<GenderServiceObject, AddRegistrationGenderDto>();
            this.CreateMap<GenderServiceObject, GetRegistrationGenderDto>();
            this.CreateMap<GenderServiceObject, UpdateRegistrationGenderDto>();
        }
    }
}