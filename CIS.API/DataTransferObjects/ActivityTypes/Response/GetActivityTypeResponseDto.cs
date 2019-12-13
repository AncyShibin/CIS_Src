using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.ActivityTypes.Response
{
    public sealed class GetActivityTypeResponseDto
    {
        public string Id { get; set; }

        public string ActivityType { get; set; }

        public int ActivityNumber { get; set; }

        public bool Status { get; set; }
    }
}
