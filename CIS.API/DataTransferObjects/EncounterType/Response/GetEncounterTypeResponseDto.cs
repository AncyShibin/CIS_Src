﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.EncounterType.Response
{
    public sealed class GetEncounterTypeResponseDto
    {
        public string Id { get; set; }

        public string EncounterType { get; set; }

        public string Status { get; set; }
    }
}
