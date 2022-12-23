//ParNepar.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV8Zadatak_2
{
    class ParNepar
    {
        private int _uneseniBroj;

        public int uneseniBroj
        {
            get
            {
                return _uneseniBroj;
            }
            set
            {
                _uneseniBroj = value;
            }
        }

        public bool parnost()
        {
            return _uneseniBroj % 2 == 0;
        }

        public ParNepar(int uneseni_broj)
        {
            this.uneseniBroj = uneseni_broj;
        }
    }
}
