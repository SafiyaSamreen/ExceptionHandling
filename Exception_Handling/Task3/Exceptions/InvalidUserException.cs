using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException() : base()
        {
        
        }

        public InvalidUserException(string message) : base(message)
        {

        }

    }
}
