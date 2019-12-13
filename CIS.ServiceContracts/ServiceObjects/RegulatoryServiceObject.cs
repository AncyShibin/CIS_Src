using System;
using System.Collections.Generic;
using System.Text;

namespace CIS.ServiceContracts.ServiceObjects
{
    public sealed class RegulatoryServiceObject
    {
        public int Id { get; set; }

        public string RegulatoryName { get; set; }

        public string IsActive { get; set; }
    }
}
