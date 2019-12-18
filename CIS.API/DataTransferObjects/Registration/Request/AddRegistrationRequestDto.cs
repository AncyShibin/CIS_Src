using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Registration.Request
{
    public sealed class AddRegistrationRequestDto
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string DateOfBirth { get; set; }

        public int GenderId { get; set; }

        public string PhoneNumber { get; set; }

        public string MobileNumber { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string POBox { get; set; }

        public string Area { get; set; }

        public string City { get; set; }

        public string Country { get; set; }


        public AddReferralInformationRequestDto Referral { get; set; }

        public AddInsuranceDetailsRequestDto Insurance { get; set; }
    }
    public sealed class AddReferralInformationRequestDto
    {
        public string Organization { get; set; }

        public string Physician { get; set; }
    }

    public sealed class AddInsuranceDetailsRequestDto
    {
        public string MemberNumber { get; set; }

        public string EmployeeNumber { get; set; }

        public string Validity { get; set; }

        public string Network { get; set; }

        public string SubNetwork { get; set; }
    }

}
