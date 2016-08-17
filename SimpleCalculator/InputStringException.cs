using System;

namespace SimpleCalculator.Exceptions
{
    public class InputStringException : Exception
    {

        public InputStringException()
        {
        }

        public InputStringException(string message)
            : base(message)
        {
        }
    }
}
