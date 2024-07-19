using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class pagos
    {
        private int _dias;
        private int _valor;
        public int dias
        {
            get { return _dias; }
            set { _dias = value; }
        }
        public int valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public int multiplicar
        {
            get
            {
                return _dias * _valor;
            }
        }
            

    }
}
