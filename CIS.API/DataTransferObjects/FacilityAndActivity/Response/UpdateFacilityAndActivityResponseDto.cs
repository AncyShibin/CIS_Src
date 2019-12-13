using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.FacilityAndActivity.Response
{
    public sealed class UpdateFacilityAndActivityResponseDto
    {
        public string Id { get; set; }

        public int FacilityId { get; set; }

        public int ActivityId { get; set; }

        public bool Status { get; set; }

        public FacilityResponseDto Facility { get; set; }

        public ActivityResponseDto Activity { get; set; }
    }
}
