using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.FacilityAndActivity.Request
{
    public sealed class AddFacilityAndActivityRequestDto
    {
        public int FacilityId { get; set; }

        public int ActivityId { get; set; }
    }
}
