using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS.API.DataTransferObjects.Departments.Response
{
    public sealed class CreateDepartmentResponseDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
