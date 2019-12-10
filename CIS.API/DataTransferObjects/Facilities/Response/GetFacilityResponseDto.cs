using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Facilities.Response
{
    public sealed class GetFacilityResponseDto
    {
        public int Id { get; set; }

        public string FacilityName { get; set; }

        public string FacilityCode { get; set; }

        public string FacilityType { get; set; }
    }
}
