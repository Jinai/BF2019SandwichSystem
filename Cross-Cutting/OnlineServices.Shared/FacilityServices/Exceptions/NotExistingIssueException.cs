using OnlineServices.Common.Exceptions;
using System;

namespace OnlineServices.Common.FacilityServices.Exceptions
{
    [Serializable]
    public class NotExistingIssueException : LoggedException
    {
        private const string ExceptionMessage = "Not existing Issue.";
        public NotExistingIssueException(string message)
            : base($"{ExceptionMessage}. {message}")
        {
        }

        public NotExistingIssueException(string message, Exception innerException)
            : base($"{ExceptionMessage}. {message}", innerException)
        {
        }

        public NotExistingIssueException()
            : base($"{ExceptionMessage}")
        {
        }
    }
}
