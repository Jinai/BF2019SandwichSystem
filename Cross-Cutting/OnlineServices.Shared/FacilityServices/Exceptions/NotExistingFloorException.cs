using OnlineServices.Shared.Exceptions;
using System;

namespace OnlineServices.Shared.FacilityServices.Exceptions
{
    [Serializable]
    public class NotExistingFloorException : LoggedException
    {
        private const string ExceptionMessage = "Not existing Floor.";
        public NotExistingFloorException(string message)
            : base($"{ExceptionMessage}. {message}")
        {
        }

        public NotExistingFloorException(string message, Exception innerException)
            : base($"{ExceptionMessage}. {message}", innerException)
        {
        }

        public NotExistingFloorException()
            : base($"{ExceptionMessage}")
        {
        }
    }
}
