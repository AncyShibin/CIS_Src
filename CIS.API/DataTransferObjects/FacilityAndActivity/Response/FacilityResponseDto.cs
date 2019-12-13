using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.FacilityAndActivity.Response
{
    public sealed class FacilityResponseDto
    {
        public int Id { get; set; }

        public string FacilityName { get; set; }

        public string FacilityCode { get; set; }

        public string FacilityType { get; set; }
    }
}
