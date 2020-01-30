﻿using OnlineServices.Common.Exceptions;
using System;

namespace OnlineServices.Common.FacilityServices.Exceptions
{
#if NETSTANDARD2_0
    [Serializable]
#endif
    public class NullRoomException : LoggedException
    {
        private const string ExceptionMessage = "Not existing Room.";
        public NullRoomException(string message)
            : base($"{ExceptionMessage}. {message}")
        {
        }

        public NullRoomException(string message, Exception innerException)
            : base($"{ExceptionMessage}. {message}", innerException)
        {
        }

        public NullRoomException()
            : base($"{ExceptionMessage}")
        {
        }
    }
}