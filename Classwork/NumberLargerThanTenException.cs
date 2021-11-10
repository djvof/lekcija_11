using System;

namespace Classwork
{
    public class NumberLargerThanTenException : Exception
    {
        public NumberLargerThanTenException()
        {

        }

        public NumberLargerThanTenException(string message) : base(message)
        {

        }

        public NumberLargerThanTenException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
