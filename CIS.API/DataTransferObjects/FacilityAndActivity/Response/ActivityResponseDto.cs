using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.FacilityAndActivity.Response
{
    public sealed class ActivityResponseDto
    {
        public int Id { get; set; }

        public string ActivityType { get; set; }

        public int ActivityNumber { get; set; }
    }
}
