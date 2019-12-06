using System;
using System.Collections.Generic;
using System.Reflection;
using AutoMapper;
using CIS.API.DataTransferObjects.Departments.Request;
using CIS.API.Validators.Departments;
using CIS.Data;
using CIS.Data.Repositories;
using CIS.DataContracts.Repositories;
using CIS.ServiceContracts.Services;
using CIS.ServiceContracts.Validations;
using CIS.Services.Services;
using CIS.Services.Validations;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CIS.API.DataTransferObjects.Gender.Request;
using CIS.API.Validators.Gender;
using CIS.API.DataTransferObjects.Patients.Request;
using CIS.API.Validators.Patients;
using CIS.API.DataTransferObjects.Appointments.Request;
using CIS.API.Validators.Appointments;

namespace CIS.API.Configuration
{
    public static class ServiceConfigurations
    {
        public static void AddServices(this IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            serviceCollection.AddScoped<IGenderService,GenderService>();
            serviceCollection.AddScoped<IDepartmentService, DepartmentService>();

            serviceCollection.AddScoped<IPatientsService, PatientsService>();
            serviceCollection.AddScoped<IAppointmentsService, AppointmentsService>();
        }

        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }
            serviceCollection.AddScoped<IDepartmentRepository, DepartmentRepository>();
            serviceCollection.AddScoped<IGenderRepository, GenderRepository>();

            serviceCollection.AddScoped<IPatientRepository, PatientRepository>();
            serviceCollection.AddScoped<IAppointmentRepository, AppointmentRepository>();
        }

        public static void AddSqlServerDbContext(this IServiceCollection serviceCollection, string connectionString)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            serviceCollection.AddDbContext<CISDbContext>(options => options.UseSqlServer(connectionString));
        }

        public static void AddAutoMapperProfiles(this IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            var autoMapperAssemblies = new List<Assembly>
            {
                
            };

            serviceCollection.AddAutoMapper(autoMapperAssemblies);
        }

        public static void AddValidators(this IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            serviceCollection.AddTransient<IValidator<AddGenderRequestDto>, AddGenderRequestDtoValidator>();
            serviceCollection.AddTransient<IValidator<UpdateGenderRequestDto>, UpdateGenderRequestDtoValidator>();

            serviceCollection.AddTransient<IValidator<CreateDepartmentRequestDto>, CreateDepartmentRequestDtoValidator>();
            serviceCollection.AddTransient<IValidator<UpdateDepartmentRequestDto>, UpdateDepartmentRequestDtoValidator>();

            serviceCollection.AddTransient<IValidator<CreatePatientRequestDto>, CreatePatientRequestDtoValidator>();
            serviceCollection.AddTransient<IValidator<CreateAppointmentRequestDto>, CreateAppointmentRequestDtoValidator>();
            serviceCollection.AddTransient<ICreatePatientValidationService, CreatePatientValidationService>();
        }
    }
}