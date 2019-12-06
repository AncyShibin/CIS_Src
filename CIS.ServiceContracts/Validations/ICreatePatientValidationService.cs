using CIS.ServiceContracts.ServiceObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CIS.ServiceContracts.Validations
{
    public interface ICreatePatientValidationService
    {
        Task Validate(UserServiceObject createPatientValidationServiceObject, CancellationToken token);
    }
}
