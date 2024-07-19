using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class conversion
    {
        private double _valordolares;
        private double _trm;

        public conversion(double valor)
        {
            _trm = valor;
        }
        public conversion()
        {
            _trm = 3980;
        }
        public double valordolares
        {
            get { return _valordolares; }
            set { _valordolares = value; }
        }
        public double convertir
        {
            get { return _valordolares * _trm; }
        }
    }
}
