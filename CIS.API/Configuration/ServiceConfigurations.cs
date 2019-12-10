using System;
using System.Collections.Generic;
using System.Reflection;
using AutoMapper;
using CIS.Data;
using CIS.Data.Repositories;
using CIS.DataContracts.Repositories;
using CIS.ServiceContracts.Services;
using CIS.ServiceContracts.Validations;
using CIS.Services.Services;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CIS.API.Controllers;

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

            serviceCollection.AddScoped<ICompanyService, CompanyService>();
            serviceCollection.AddScoped<IFacilityService, FacilityService>();
            serviceCollection.AddScoped<IVisitTypeService, VisitTypeService>();
        }

        public static void AddRepositories(this IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }

            serviceCollection.AddScoped<ICompanyRepository, CompanyRepository>();
            serviceCollection.AddScoped<IFacilityRepository, FacilityRepository>();
            serviceCollection.AddScoped<IVisitTypeRepository, VisitTypeRepository>();
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
                typeof(CompanyController).GetTypeInfo().Assembly,
                typeof(CompanyService).GetTypeInfo().Assembly
            };

            serviceCollection.AddAutoMapper(autoMapperAssemblies);
        }

        public static void AddValidators(this IServiceCollection serviceCollection)
        {
            if (serviceCollection == null)
            {
                throw new ArgumentNullException(nameof(serviceCollection));
            }
        }
    }
}