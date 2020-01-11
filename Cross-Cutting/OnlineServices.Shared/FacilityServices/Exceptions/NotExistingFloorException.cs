using OnlineServices.Common.Exceptions;
using System;

namespace OnlineServices.Common.FacilityServices.Exceptions
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
