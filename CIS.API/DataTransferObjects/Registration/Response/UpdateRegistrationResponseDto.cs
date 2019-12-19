using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Registration.Response
{
    public sealed class UpdateRegistrationResponseDto
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public UpdateRegistrationGenderDto Gender { get; set; }


        public UpdateReferralInformationResponseDto Referral { get; set; }

        public UpdateInsuranceDetailsResponseDto Insurance { get; set; }
    }

    public sealed class UpdateReferralInformationResponseDto
    {
        public string Organization { get; set; }

        public string Physician { get; set; }
    }

    public sealed class UpdateInsuranceDetailsResponseDto
    {
        public string MemberNumber { get; set; }

        public string EmployeeNumber { get; set; }

        public string Validity { get; set; }

        public string Network { get; set; }

        public string SubNetwork { get; set; }
    }
    public sealed class UpdateRegistrationGenderDto
    {
        public string Id { get; set; }

        public string Name { get; set; }
    }
}
