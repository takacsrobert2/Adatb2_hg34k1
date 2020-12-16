using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernKonyvtar_AdatbazisBeadando.Exceptions
{
    public class CimException : Exception
    {
        public CimException()
        {
        }

        public CimException(string message)
            : base(message)
        {
        }

        public CimException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
