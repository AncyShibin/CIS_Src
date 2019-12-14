using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.MedicalRecord.Response
{
    public class CompanyResponseDto
    {
        public string Id { get; set; }

        public string CompanyNameEnglish { get; set; }

        public string CompanyNameArabic { get; set; }
    }
}
