using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernKonyvtar_AdatbazisBeadando.Exceptions
{
    public class KiadoException : Exception
    {
        public KiadoException()
        {
        }

        public KiadoException(string message)
            : base(message)
        {
        }

        public KiadoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
