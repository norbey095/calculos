using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class calculos
    {
        private int _numero1;
        private int _numero2;
        private int _numero3;
        public int numero1
        {
            get { return _numero1; }
            set { _numero1 = value; }
        }
        public int numero2
        {
            get { return _numero2; }
            set { _numero2 = value; }
        }
        public int numero3
        {
            get { return _numero3; }
            set { _numero3 = value; }
        }
        public int sumar
        {
            get
            {
                return _numero1 + _numero2 + _numero3;
            }
        }
    }
}
