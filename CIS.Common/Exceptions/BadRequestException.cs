using System;
using CIS.Common.Models;

namespace CIS.Common.Exceptions
{
    public sealed class BadRequestException : Exception
    {
        public ValidationError Error { get; }

        public BadRequestException(ValidationError error)
        {
            this.Error = error;
        }
    }
}