using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public class CompanyServiceObject
    {
        public int Id { get; set; }

        public string CompanyNameEnglish { get; set; }

        public string CompanyNameArabic { get; set; }

        public string CompanyAddessEnglish { get; set; }

        public string CompanyAddressArabic { get; set; }

        public string CompanyCode { get; set; }

        public string TaxId { get; set; }

        public string Currency { get; set; }

        public string Language { get; set; }

        public DateTime LicenseStartDate { get; set; }

        public DateTime LicenseEndDate { get; set; }

        public string HospitalId { get; set; }

        public string BankAccountNumber { get; set; }

        public string TaxSetup { get; set; }


    }
}
