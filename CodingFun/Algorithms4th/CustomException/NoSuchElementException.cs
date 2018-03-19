using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms4th.CustomException
{
    public class NoSuchElementException : Exception
    {
        public NoSuchElementException()
        {
        }

        public NoSuchElementException(string message) : base(message)
        {
        }

        public NoSuchElementException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
