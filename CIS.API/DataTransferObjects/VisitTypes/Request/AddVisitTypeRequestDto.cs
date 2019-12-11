using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.VisitTypes.Request
{
    public sealed class AddVisitTypeRequestDto
    {
        public string VisitType { get; set; }

        public bool Status { get; set; }
    }
}
