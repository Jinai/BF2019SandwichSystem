using OnlineServices.Shared.Exceptions;
using System;

namespace OnlineServices.Shared.FacilityServices.Exceptions
{
    [Serializable]
    public class NotExistingComponentTypeException : LoggedException
    {
        private const string ExceptionMessage = "Not existing ComponentType.";
        public NotExistingComponentTypeException(string message)
            : base($"{ExceptionMessage}. {message}")
        {
        }

        public NotExistingComponentTypeException(string message, Exception innerException)
            : base($"{ExceptionMessage}. {message}", innerException)
        {
        }

        public NotExistingComponentTypeException()
            : base($"{ExceptionMessage}")
        {
        }
    }
}
