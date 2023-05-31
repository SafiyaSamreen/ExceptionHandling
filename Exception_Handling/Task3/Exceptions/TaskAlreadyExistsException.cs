using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class TaskAlreadyExistsException : Exception
    {
        public TaskAlreadyExistsException() : base()
        {

        }

        public TaskAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
