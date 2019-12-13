using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Regulatory.Response
{
    public sealed class GetRegulatoryResponseDto
    {
        public string Id { get; set; }

        public string RegulatoryName { get; set; }

        public string Status { get; set; }
    }
}
