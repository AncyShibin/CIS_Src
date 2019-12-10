using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CIS.DataContracts.Entities
{
    [Table("company")]
    public sealed class CompanyEntity : BaseEntity
    {
        [Key] [Column("company_id")] public int Id { get; set; }

        [Column("company_name_english")] public string CompanyNameEnglish { get; set; }

        [Column("company_name_arabic")] public string CompanyNameArabic { get; set; }

        [Column("company_address_english")] public string CompanyAddressEnglish { get; set; }

        [Column("company_address_arabic")] public string CompanyAddressArabic { get; set; }

        [Column("company_code")] public string CompanyCode { get; set; }

        [Column("tex_id")] public string TaxId { get; set; }

        [Column("currency")] public string Currency { get; set; }

        [Column("language")] public string Language { get; set; }

        [Column("licence_start_date")] public DateTime LicenseStartDate { get; set; }

        [Column("licence_end_date")] public DateTime LicenseEndDate { get; set; }

        [Column("hospital_id")] public string HospitalId { get; set; }

        [Column("bank_account_number")] public string BankAccountNumber { get; set; }

        [Column("tax_setup")] public string TaxSetup { get; set; }
    }
}
