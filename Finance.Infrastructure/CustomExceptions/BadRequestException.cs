using System;

namespace Finance.Infrastructure.CustomExceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException()
        {
        }

        public BadRequestException(string message) : base(message)
        {
        }
    }
}
