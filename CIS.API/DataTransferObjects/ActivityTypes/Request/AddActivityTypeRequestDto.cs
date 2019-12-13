using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.ActivityTypes.Request
{
    public sealed class AddActivityTypeRequestDto
    {
        public string ActivityType { get; set; }

        public int ActivityNumber { get; set; }
    }
}
