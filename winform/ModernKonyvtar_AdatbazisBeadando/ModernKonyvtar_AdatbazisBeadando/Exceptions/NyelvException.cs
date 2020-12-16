using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernKonyvtar_AdatbazisBeadando.Exceptions
{
    public class NyelvException : Exception
    {
        public NyelvException()
        {
        }

        public NyelvException(string message)
            : base(message)
        {
        }

        public NyelvException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
