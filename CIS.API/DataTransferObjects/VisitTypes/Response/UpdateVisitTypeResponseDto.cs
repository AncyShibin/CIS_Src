using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.VisitTypes.Response
{
    public sealed class UpdateVisitTypeResponseDto
    {
        public string Id { get; set; }

        public string VisitType { get; set; }

        public string Status { get; set; }
    }
}
