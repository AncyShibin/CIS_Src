using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.MedicalRecord.Response
{
    public class FacilitiesResponseDto
    {
        public string Id { get; set; }

        public string FacilityName { get; set; }

        public string FacilityCode { get; set; }

        public string FacilityType { get; set; }
    }
}
