using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernKonyvtar_AdatbazisBeadando.Exceptions
{
    public class KategoriaException : Exception
    {
        public KategoriaException()
        {
        }

        public KategoriaException(string message)
            : base(message)
        {
        }

        public KategoriaException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
