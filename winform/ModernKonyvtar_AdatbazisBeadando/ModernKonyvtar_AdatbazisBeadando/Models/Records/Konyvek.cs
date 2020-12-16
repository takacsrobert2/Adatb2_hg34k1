using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernKonyvtar_AdatbazisBeadando.Exceptions;

namespace ModernKonyvtar_AdatbazisBeadando.Models.Records
{
    public class Konyvek
    {
        private string cim;

        public string Cim
        {
            get
            {
                return cim;
            }
            set
            {
                if (value == null)
                {
                    throw new CimException("A cím nem lehet null");

                }
                cim = value;
            }
        }

        private string szerzo;

        public string Szerzo
        {
            get
            {
                return szerzo;
            }
            set
            {
                if (value == null)
                {
                    throw new SzerzoException("A szerzőnek mindenképp van értéke");

                }
                szerzo = value;
            }
        }

        private string kiado;

        public string Kiado
        {
            get
            {
                return kiado;
            }
            set
            {
                if (value == null)
                {
                    throw new KiadoException("A könyvnek rendelkeznie kell egy kiadóval");

                }
                kiado = value;
            }
        }

        private DateTime kiadas_eve;

        public DateTime Kiadas_eve
        {
            get
            {
                return kiadas_eve;
            }
            set
            {
                kiadas_eve = value;
            }
        }

        private string isbn_azonosito;

        public string Isbn_azonosito
        {
            get
            {
                return isbn_azonosito;
            }
            set
            {
                if (value == null)
                {
                    throw new Isbn_azonositoException("Isbn azonosítónak kell hogy legyen értéke");

                }
                isbn_azonosito = value;
            }
        }

        private string nyelv;

        public string Nyelv
        {
            get
            {
                return nyelv;
            }
            set
            {
                if (value == null)
                {
                    throw new NyelvException("A nyelv értéke nem lehet null");

                }
                nyelv = value;
            }
        }

        private string kategoria;

        public string Kategoria
        {
            get
            {
                return kategoria;
            }
            set
            {
                if (value == null)
                {
                    throw new KategoriaException("A kategória nem lehet null");

                }
                kategoria = value;
            }
        }
       


    }
}
