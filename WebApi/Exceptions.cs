﻿namespace WebApi
{
    public class Exceptions
    {
        public class NotFoundException : Exception
        {
            public NotFoundException() : base("Not found item.")
            {
            }

            public NotFoundException(string message) : base(message)
            {
            }
            public NotFoundException(string message, Exception innerException) : base(message, innerException)
            {
            }
        }
    }
}
