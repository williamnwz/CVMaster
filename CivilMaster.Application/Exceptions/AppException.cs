using System;
using System.Collections.Generic;
using System.Text;

namespace CivilMaster.Application.Exceptions
{
    public class AppException : Exception
    {
        public AppException(string message) : base(message)
        {

        }
    }
}
