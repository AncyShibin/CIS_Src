using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.ActivityTypes.Response
{
    public sealed class AddActivityTypeResponseDto
    {
        public string Id { get; set; }

        public string ActivityNumber { get; set; }

        public string Status { get; set; }
    }
}
