using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernKonyvtar_AdatbazisBeadando.Exceptions
{
    public class SzerzoException : Exception
    {
        public SzerzoException()
        {
        }

        public SzerzoException(string message)
            : base(message)
        {
        }

        public SzerzoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
