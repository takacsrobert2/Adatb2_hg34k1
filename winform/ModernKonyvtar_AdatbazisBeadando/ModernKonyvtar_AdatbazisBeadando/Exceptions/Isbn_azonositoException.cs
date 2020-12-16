using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernKonyvtar_AdatbazisBeadando.Exceptions
{
    public class Isbn_azonositoException : Exception
    {
        public Isbn_azonositoException()
        {
        }

        public Isbn_azonositoException(string message)
            : base(message)
        {
        }

        public Isbn_azonositoException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
